namespace HandleVirtualData
{
    partial class MainFormForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewEx = new HotMap.Utils.Controls.DataGridViewEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textB_teacherId = new System.Windows.Forms.TextBox();
            this.textB_teacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ImportTeacher = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textB_ExcelPath = new System.Windows.Forms.TextBox();
            this.btn_SelectExcelPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comb_TableNameList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comb_StudentIdFieldList = new System.Windows.Forms.ComboBox();
            this.comb_StudentNameFieldList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textB_PaperId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_ImportStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ImportTeacher);
            this.groupBox1.Controls.Add(this.textB_teacherName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textB_teacherId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入教师";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewEx);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1015, 602);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入学生";
            // 
            // dataGridViewEx
            // 
            this.dataGridViewEx.AllowUserToAddRows = false;
            this.dataGridViewEx.AllowUserToDeleteRows = false;
            this.dataGridViewEx.AllowUserToResizeRows = false;
            this.dataGridViewEx.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEx.IsAsc = true;
            this.dataGridViewEx.IsOpenEditError = false;
            this.dataGridViewEx.Location = new System.Drawing.Point(3, 119);
            this.dataGridViewEx.Name = "dataGridViewEx";
            this.dataGridViewEx.RowTemplate.Height = 23;
            this.dataGridViewEx.Size = new System.Drawing.Size(1009, 480);
            this.dataGridViewEx.SourceTable = null;
            this.dataGridViewEx.TabIndex = 0;
            this.dataGridViewEx.VirtualMode = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ImportStudent);
            this.panel1.Controls.Add(this.textB_PaperId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.comb_StudentNameFieldList);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comb_StudentIdFieldList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textB_ExcelPath);
            this.panel1.Controls.Add(this.btn_SelectExcelPath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comb_TableNameList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 102);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "工号：";
            // 
            // textB_teacherId
            // 
            this.textB_teacherId.Location = new System.Drawing.Point(80, 40);
            this.textB_teacherId.Name = "textB_teacherId";
            this.textB_teacherId.Size = new System.Drawing.Size(147, 21);
            this.textB_teacherId.TabIndex = 1;
            // 
            // textB_teacherName
            // 
            this.textB_teacherName.Location = new System.Drawing.Point(289, 40);
            this.textB_teacherName.Name = "textB_teacherName";
            this.textB_teacherName.Size = new System.Drawing.Size(147, 21);
            this.textB_teacherName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // btn_ImportTeacher
            // 
            this.btn_ImportTeacher.Location = new System.Drawing.Point(767, 38);
            this.btn_ImportTeacher.Name = "btn_ImportTeacher";
            this.btn_ImportTeacher.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportTeacher.TabIndex = 4;
            this.btn_ImportTeacher.Text = "导入";
            this.btn_ImportTeacher.UseVisualStyleBackColor = true;
            this.btn_ImportTeacher.Click += new System.EventHandler(this.btn_ImportTeacher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Excel路径：";
            // 
            // textB_ExcelPath
            // 
            this.textB_ExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_ExcelPath.Location = new System.Drawing.Point(80, 19);
            this.textB_ExcelPath.Name = "textB_ExcelPath";
            this.textB_ExcelPath.ReadOnly = true;
            this.textB_ExcelPath.Size = new System.Drawing.Size(302, 21);
            this.textB_ExcelPath.TabIndex = 5;
            // 
            // btn_SelectExcelPath
            // 
            this.btn_SelectExcelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectExcelPath.Location = new System.Drawing.Point(385, 17);
            this.btn_SelectExcelPath.Name = "btn_SelectExcelPath";
            this.btn_SelectExcelPath.Size = new System.Drawing.Size(51, 23);
            this.btn_SelectExcelPath.TabIndex = 6;
            this.btn_SelectExcelPath.Text = "…";
            this.btn_SelectExcelPath.UseVisualStyleBackColor = true;
            this.btn_SelectExcelPath.Click += new System.EventHandler(this.btn_SelectExcelPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "数据表：";
            // 
            // comb_TableNameList
            // 
            this.comb_TableNameList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comb_TableNameList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_TableNameList.FormattingEnabled = true;
            this.comb_TableNameList.Location = new System.Drawing.Point(512, 19);
            this.comb_TableNameList.Name = "comb_TableNameList";
            this.comb_TableNameList.Size = new System.Drawing.Size(232, 20);
            this.comb_TableNameList.TabIndex = 9;
            this.comb_TableNameList.SelectedIndexChanged += new System.EventHandler(this.comb_TableNameList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "学号：";
            // 
            // comb_StudentIdFieldList
            // 
            this.comb_StudentIdFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_StudentIdFieldList.FormattingEnabled = true;
            this.comb_StudentIdFieldList.Location = new System.Drawing.Point(80, 59);
            this.comb_StudentIdFieldList.Name = "comb_StudentIdFieldList";
            this.comb_StudentIdFieldList.Size = new System.Drawing.Size(147, 20);
            this.comb_StudentIdFieldList.TabIndex = 10;
            // 
            // comb_StudentNameFieldList
            // 
            this.comb_StudentNameFieldList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_StudentNameFieldList.FormattingEnabled = true;
            this.comb_StudentNameFieldList.Location = new System.Drawing.Point(289, 59);
            this.comb_StudentNameFieldList.Name = "comb_StudentNameFieldList";
            this.comb_StudentNameFieldList.Size = new System.Drawing.Size(147, 20);
            this.comb_StudentNameFieldList.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "姓名：";
            // 
            // textB_PaperId
            // 
            this.textB_PaperId.Location = new System.Drawing.Point(512, 59);
            this.textB_PaperId.Name = "textB_PaperId";
            this.textB_PaperId.Size = new System.Drawing.Size(232, 21);
            this.textB_PaperId.TabIndex = 16;
            this.textB_PaperId.Text = "1ea693c9-7dc3-4b40-81b4-4da90996927b";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "试卷ID：";
            // 
            // btn_ImportStudent
            // 
            this.btn_ImportStudent.Location = new System.Drawing.Point(764, 56);
            this.btn_ImportStudent.Name = "btn_ImportStudent";
            this.btn_ImportStudent.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportStudent.TabIndex = 17;
            this.btn_ImportStudent.Text = "导入";
            this.btn_ImportStudent.UseVisualStyleBackColor = true;
            this.btn_ImportStudent.Click += new System.EventHandler(this.btn_ImportStudent_Click);
            // 
            // MainFormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 687);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFormForm";
            this.Text = "实习用户导入";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HotMap.Utils.Controls.DataGridViewEx dataGridViewEx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ImportTeacher;
        private System.Windows.Forms.TextBox textB_teacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textB_teacherId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB_ExcelPath;
        private System.Windows.Forms.Button btn_SelectExcelPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comb_TableNameList;
        private System.Windows.Forms.Button btn_ImportStudent;
        private System.Windows.Forms.TextBox textB_PaperId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comb_StudentNameFieldList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comb_StudentIdFieldList;
        private System.Windows.Forms.Label label5;
    }
}

