using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandleVirtualData
{
    public partial class MainFormForm : Form
    {
        protected static string ConnectionString = HotMap.Utils.Config.ConfigHelper.ReadConnectionStringConfig("SqlConStr");
        public MainFormForm()
        {
            InitializeComponent();
        }

        private void btn_ImportTeacher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textB_teacherId.Text) || string.IsNullOrWhiteSpace(textB_teacherName.Text))
            {
                MessageBox.Show("工号和姓名不能为空！");
                return;
            }

            string teacherId = textB_teacherId.Text.Trim();
            string name = textB_teacherName.Text.Trim();
            string sql = "select isnull((select top(1) 1 from UserInfo where UserId=@UserId), 0)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserId", SqlDbType.VarChar, 10) {Value = teacherId}
            };
            object retVal = HotMap.Utils.Data.SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql, parameters);
            if (Convert.ToBoolean(retVal))
            {
                MessageBox.Show("工号已存在！");
                return;
            }

            string password =
                HotMap.Utils.Security.MD5Encryptor.Encrypt(HotMap.Utils.Security.MD5Encryptor.Encrypt(teacherId));
            sql = "insert into UserInfo (UserId,Password,Type) values (@UserId,@Password,@Type)";
            parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", SqlDbType.VarChar, 10) {Value = teacherId},
                new SqlParameter("@Password", SqlDbType.VarChar, 50) {Value = password},
                new SqlParameter("@Type", SqlDbType.Int) {Value = 1}
            };
            int rowNum =
                HotMap.Utils.Data.SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sql, parameters);
            if (rowNum <= 0)
            {
                MessageBox.Show("导入失败-用户信息表！");
                return;
            }
            sql = "insert into TeacherInfo (TeacherId,Name) values (@TeacherId,@Name)";
            parameters = new SqlParameter[]
            {
                new SqlParameter("@TeacherId", SqlDbType.VarChar, 10) { Value = teacherId },
                new SqlParameter("@Name", SqlDbType.VarChar, 10) { Value = name },
            };
            rowNum =
                HotMap.Utils.Data.SqlHelper.ExecuteNonQuery(ConnectionString, CommandType.Text, sql, parameters);
            if (rowNum <= 0)
            {
                MessageBox.Show("导入失败-教师新表！");
                return;
            }

            MessageBox.Show("添加成功！");
        }

        private void btn_SelectExcelPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel文件|*.xlsx;*.xls";
            openFileDialog.Title = "选择Excel数据";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                textB_ExcelPath.Text = fileName;
                List<string> excelTableNameList = HotMap.Utils.Data.ExcelHelper.GetExcelTableNameList(fileName);
                this.comb_TableNameList.Items.Clear();
                foreach (string tableName in excelTableNameList)
                {
                    comb_TableNameList.Items.Add(tableName);
                }
                if (excelTableNameList.Count > 0)
                {
                    comb_TableNameList.SelectedIndex = 0;
                }
            }
        }

        private void comb_TableNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            comb_StudentIdFieldList.Items.Clear();
            comb_StudentNameFieldList.Items.Clear();
            if(comb_TableNameList.SelectedIndex ==-1)return;
            DataTable sourceTable = HotMap.Utils.Data.ExcelHelper.GetExcelTable(textB_ExcelPath.Text, comb_TableNameList.Text);
            if (sourceTable == null)
            {
                return;
            }
            dataGridViewEx.SourceTable = sourceTable;
            for (int i = 0; i < sourceTable.Columns.Count; i++)
            {
                comb_StudentIdFieldList.Items.Add(sourceTable.Columns[i].ColumnName);
                comb_StudentNameFieldList.Items.Add(sourceTable.Columns[i].ColumnName);
            }
        }

        private void btn_ImportStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewEx.SourceTable == null || dataGridViewEx.SourceTable.Rows.Count == 0)
            {
                MessageBox.Show("未导入数据！");
                return;
            }

            if (comb_StudentIdFieldList.SelectedIndex == -1 || comb_StudentNameFieldList.SelectedIndex == -1)
            {
                MessageBox.Show("未选择匹配字段！");
                return;
            }

            if (string.IsNullOrWhiteSpace(textB_PaperId.Text))
            {
                MessageBox.Show("试卷Id不能为空！");
                return;
            }

            string paperId = textB_PaperId.Text.Trim();
            string sql = "select isnull((select top(1) 1 from TestPaperInfo where PaperId=@PaperId), 0)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@PaperId", SqlDbType.VarChar, 50) {Value = paperId},
            };
            object retVal = HotMap.Utils.Data.SqlHelper.ExecuteScalar(ConnectionString, CommandType.Text, sql,parameters);
            if (!Convert.ToBoolean(retVal))
            {
                MessageBox.Show("试卷ID不存在！");
                return;
            }

            sql = "select * from UserInfo";
            DataTable userInfo = HotMap.Utils.Data.SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql)
                .Tables[0];
            userInfo.PrimaryKey =new DataColumn[]{userInfo.Columns["UserId"]};
            sql = "select * from StudentInfo where StudentId = '-1'";
            DataTable studentInfo = HotMap.Utils.Data.SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql)
                .Tables[0];
            sql = "select * from StudentPaper where StudentId = '-1' and PaperId = '-1'";
            DataTable studentPaper = HotMap.Utils.Data.SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql)
                .Tables[0];
            List<string> classIdList = new List<string>();
            DataTable addUserInfo = userInfo.Clone();
            addUserInfo.TableName = "UserInfo";
            DataTable addStudentInfo = studentInfo.Clone();
            addStudentInfo.TableName = "StudentInfo";
            DataTable addStudentPaper = studentPaper.Clone();
            addStudentPaper.TableName = "StudentPaper";
            for (int i = 0; i < dataGridViewEx.SourceTable.Rows.Count; i++)
            {
                DataRow dataRow = dataGridViewEx.SourceTable.Rows[i];
                string studentId = dataRow[comb_StudentIdFieldList.SelectedIndex].ToString();
                string studentName = dataRow[comb_StudentNameFieldList.SelectedIndex].ToString();
                if(string.IsNullOrWhiteSpace(studentId)||string.IsNullOrWhiteSpace(studentName))continue;
                DataRow tempRow = userInfo.Rows.Find(studentId);
                if(tempRow != null) continue;
                DataRow newRow = addUserInfo.NewRow();
                newRow["UserId"] = studentId;
                newRow["Password"] =
                    HotMap.Utils.Security.MD5Encryptor.Encrypt(HotMap.Utils.Security.MD5Encryptor.Encrypt(studentId));
                newRow["Type"] = 0;
                addUserInfo.Rows.Add(newRow);
               
                string classId = studentId.Substring(0, 7);
                if (!classIdList.Contains(classId))
                {
                    classIdList.Add(classId);
                }

                newRow = addStudentInfo.NewRow();
                newRow["StudentId"] = studentId;
                newRow["Name"] = studentName;
                newRow["ClassId"] = classId;
                addStudentInfo.Rows.Add(newRow);

                newRow = addStudentPaper.NewRow();
                newRow["StudentId"] = studentId;
                newRow["PaperId"] = paperId;
                newRow["Status"] = 0;
                addStudentPaper.Rows.Add(newRow);
            }
            sql = "select * from ClassInfo";
            DataTable classInfo = HotMap.Utils.Data.SqlHelper.ExecuteDataSet(ConnectionString, CommandType.Text, sql)
                .Tables[0];
            classInfo.TableName = "ClassInfo";
            classInfo.PrimaryKey=new DataColumn[]{classInfo.Columns["ClassId"]};
            for (int i = 0; i < classIdList.Count; i++)
            {
                string classId = classIdList[i];
                if(classInfo.Rows.Find(classId)!=null)continue;
                DataRow newRow = classInfo.NewRow();
                newRow["ClassId"] = classId;
                newRow["ClassName"] = $"{classId}土木工程";
                classInfo.Rows.Add(newRow);
            }

            HotMap.Utils.Data.SqlHelper.UpdateDataSet(ConnectionString, classInfo.DataSet, "ClassInfo",
                "select * from ClassInfo");
            HotMap.Utils.Data.SqlHelper.BatchInsertBySqlBulkCopy(ConnectionString,addUserInfo);
            HotMap.Utils.Data.SqlHelper.BatchInsertBySqlBulkCopy(ConnectionString, addStudentInfo);
            HotMap.Utils.Data.SqlHelper.BatchInsertBySqlBulkCopy(ConnectionString, addStudentPaper);
            MessageBox.Show($"共导入{addStudentInfo.Rows.Count}个学生");
        }
    }
}
