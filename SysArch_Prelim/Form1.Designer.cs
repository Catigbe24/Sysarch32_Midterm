namespace SysArch_Prelim
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCollegeName = new System.Windows.Forms.ComboBox();
            this.txtCollegeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete_College = new System.Windows.Forms.Button();
            this.btnUpdate_College = new System.Windows.Forms.Button();
            this.btnCreate_College = new System.Windows.Forms.Button();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCollegeCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbSelectedColl = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepartmentCollegeID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepartmentID = new System.Windows.Forms.TextBox();
            this.btnDelete_Department = new System.Windows.Forms.Button();
            this.btnUpdate_Department = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate_Department = new System.Windows.Forms.Button();
            this.cbDeptActive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewCollege = new System.Windows.Forms.DataGridView();
            this.dataGridViewDepartment = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollege)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCollegeName);
            this.groupBox1.Controls.Add(this.txtCollegeID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDelete_College);
            this.groupBox1.Controls.Add(this.btnUpdate_College);
            this.groupBox1.Controls.Add(this.btnCreate_College);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCollegeCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "College";
            // 
            // cbCollegeName
            // 
            this.cbCollegeName.FormattingEnabled = true;
            this.cbCollegeName.Items.AddRange(new object[] {
            "College of Engineering",
            "College of Business & Finance",
            "College of Information Tech.",
            "College of Arts & Sciences",
            "College of Health Sciences"});
            this.cbCollegeName.Location = new System.Drawing.Point(195, 79);
            this.cbCollegeName.Name = "cbCollegeName";
            this.cbCollegeName.Size = new System.Drawing.Size(210, 28);
            this.cbCollegeName.TabIndex = 10;
            this.cbCollegeName.SelectedIndexChanged += new System.EventHandler(this.cbCollegeName_SelectedIndexChanged);
            // 
            // txtCollegeID
            // 
            this.txtCollegeID.Enabled = false;
            this.txtCollegeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeID.Location = new System.Drawing.Point(195, 26);
            this.txtCollegeID.Name = "txtCollegeID";
            this.txtCollegeID.Size = new System.Drawing.Size(210, 35);
            this.txtCollegeID.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "College ID";
            // 
            // btnDelete_College
            // 
            this.btnDelete_College.Location = new System.Drawing.Point(298, 212);
            this.btnDelete_College.Name = "btnDelete_College";
            this.btnDelete_College.Size = new System.Drawing.Size(112, 31);
            this.btnDelete_College.TabIndex = 7;
            this.btnDelete_College.Text = "Delete";
            this.btnDelete_College.UseVisualStyleBackColor = true;
            this.btnDelete_College.Click += new System.EventHandler(this.btnDelete_College_Click);
            // 
            // btnUpdate_College
            // 
            this.btnUpdate_College.Location = new System.Drawing.Point(166, 212);
            this.btnUpdate_College.Name = "btnUpdate_College";
            this.btnUpdate_College.Size = new System.Drawing.Size(112, 31);
            this.btnUpdate_College.TabIndex = 6;
            this.btnUpdate_College.Text = "Update";
            this.btnUpdate_College.UseVisualStyleBackColor = true;
            this.btnUpdate_College.Click += new System.EventHandler(this.btnUpdate_College_Click);
            // 
            // btnCreate_College
            // 
            this.btnCreate_College.Location = new System.Drawing.Point(33, 212);
            this.btnCreate_College.Name = "btnCreate_College";
            this.btnCreate_College.Size = new System.Drawing.Size(112, 31);
            this.btnCreate_College.TabIndex = 5;
            this.btnCreate_College.Text = "Create";
            this.btnCreate_College.UseVisualStyleBackColor = true;
            this.btnCreate_College.Click += new System.EventHandler(this.btnCreate_College_Click);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(195, 168);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(78, 24);
            this.cbActive.TabIndex = 2;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "College Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "College Name";
            // 
            // txtCollegeCode
            // 
            this.txtCollegeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCollegeCode.Location = new System.Drawing.Point(195, 122);
            this.txtCollegeCode.Name = "txtCollegeCode";
            this.txtCollegeCode.Size = new System.Drawing.Size(210, 35);
            this.txtCollegeCode.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDepartment);
            this.groupBox2.Controls.Add(this.cmbSelectedColl);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDepartmentCollegeID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDepartmentID);
            this.groupBox2.Controls.Add(this.btnDelete_Department);
            this.groupBox2.Controls.Add(this.btnUpdate_Department);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnCreate_Department);
            this.groupBox2.Controls.Add(this.cbDeptActive);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDepartmentCode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(254, 214);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(151, 28);
            this.cmbDepartment.TabIndex = 12;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // cmbSelectedColl
            // 
            this.cmbSelectedColl.FormattingEnabled = true;
            this.cmbSelectedColl.Location = new System.Drawing.Point(301, 156);
            this.cmbSelectedColl.Name = "cmbSelectedColl";
            this.cmbSelectedColl.Size = new System.Drawing.Size(104, 28);
            this.cmbSelectedColl.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Selected College Name";
            // 
            // txtDepartmentCollegeID
            // 
            this.txtDepartmentCollegeID.Enabled = false;
            this.txtDepartmentCollegeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentCollegeID.Location = new System.Drawing.Point(243, 93);
            this.txtDepartmentCollegeID.Name = "txtDepartmentCollegeID";
            this.txtDepartmentCollegeID.Size = new System.Drawing.Size(162, 35);
            this.txtDepartmentCollegeID.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "College ID";
            // 
            // txtDepartmentID
            // 
            this.txtDepartmentID.Enabled = false;
            this.txtDepartmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentID.Location = new System.Drawing.Point(243, 37);
            this.txtDepartmentID.Name = "txtDepartmentID";
            this.txtDepartmentID.Size = new System.Drawing.Size(162, 35);
            this.txtDepartmentID.TabIndex = 9;
            // 
            // btnDelete_Department
            // 
            this.btnDelete_Department.Location = new System.Drawing.Point(293, 364);
            this.btnDelete_Department.Name = "btnDelete_Department";
            this.btnDelete_Department.Size = new System.Drawing.Size(112, 31);
            this.btnDelete_Department.TabIndex = 8;
            this.btnDelete_Department.Text = "Delete";
            this.btnDelete_Department.UseVisualStyleBackColor = true;
            this.btnDelete_Department.Click += new System.EventHandler(this.btnDelete_Department_Click);
            // 
            // btnUpdate_Department
            // 
            this.btnUpdate_Department.Location = new System.Drawing.Point(161, 364);
            this.btnUpdate_Department.Name = "btnUpdate_Department";
            this.btnUpdate_Department.Size = new System.Drawing.Size(112, 31);
            this.btnUpdate_Department.TabIndex = 7;
            this.btnUpdate_Department.Text = "Update";
            this.btnUpdate_Department.UseVisualStyleBackColor = true;
            this.btnUpdate_Department.Click += new System.EventHandler(this.btnUpdate_Department_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Department ID";
            // 
            // btnCreate_Department
            // 
            this.btnCreate_Department.Location = new System.Drawing.Point(20, 364);
            this.btnCreate_Department.Name = "btnCreate_Department";
            this.btnCreate_Department.Size = new System.Drawing.Size(112, 31);
            this.btnCreate_Department.TabIndex = 6;
            this.btnCreate_Department.Text = "Create";
            this.btnCreate_Department.UseVisualStyleBackColor = true;
            this.btnCreate_Department.Click += new System.EventHandler(this.btnCreate_Department_Click);
            // 
            // cbDeptActive
            // 
            this.cbDeptActive.AutoSize = true;
            this.cbDeptActive.Location = new System.Drawing.Point(243, 320);
            this.cbDeptActive.Name = "cbDeptActive";
            this.cbDeptActive.Size = new System.Drawing.Size(78, 24);
            this.cbDeptActive.TabIndex = 5;
            this.cbDeptActive.Text = "Active";
            this.cbDeptActive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Department Code";
            // 
            // txtDepartmentCode
            // 
            this.txtDepartmentCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentCode.Location = new System.Drawing.Point(243, 263);
            this.txtDepartmentCode.Name = "txtDepartmentCode";
            this.txtDepartmentCode.Size = new System.Drawing.Size(162, 35);
            this.txtDepartmentCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Department Name";
            // 
            // dataGridViewCollege
            // 
            this.dataGridViewCollege.ColumnHeadersHeight = 34;
            this.dataGridViewCollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCollege.Location = new System.Drawing.Point(499, 12);
            this.dataGridViewCollege.Name = "dataGridViewCollege";
            this.dataGridViewCollege.ReadOnly = true;
            this.dataGridViewCollege.RowHeadersVisible = false;
            this.dataGridViewCollege.RowHeadersWidth = 62;
            this.dataGridViewCollege.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCollege.RowTemplate.Height = 28;
            this.dataGridViewCollege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCollege.Size = new System.Drawing.Size(730, 285);
            this.dataGridViewCollege.TabIndex = 2;
            this.dataGridViewCollege.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCollege_CellClick);
            // 
            // dataGridViewDepartment
            // 
            this.dataGridViewDepartment.ColumnHeadersHeight = 34;
            this.dataGridViewDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDepartment.Location = new System.Drawing.Point(499, 351);
            this.dataGridViewDepartment.Name = "dataGridViewDepartment";
            this.dataGridViewDepartment.ReadOnly = true;
            this.dataGridViewDepartment.RowHeadersVisible = false;
            this.dataGridViewDepartment.RowHeadersWidth = 62;
            this.dataGridViewDepartment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewDepartment.RowTemplate.Height = 28;
            this.dataGridViewDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartment.Size = new System.Drawing.Size(730, 326);
            this.dataGridViewDepartment.TabIndex = 3;
            this.dataGridViewDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartment_CellClick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(808, 309);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(112, 31);
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(755, 683);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(226, 46);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1279, 750);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.dataGridViewDepartment);
            this.Controls.Add(this.dataGridViewCollege);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollege)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCollegeCode;
        private System.Windows.Forms.TextBox txtDepartmentCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.CheckBox cbDeptActive;
        private System.Windows.Forms.Button btnCreate_College;
        private System.Windows.Forms.Button btnCreate_Department;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewCollege;
        private System.Windows.Forms.DataGridView dataGridViewDepartment;
        private System.Windows.Forms.Button btnDelete_College;
        private System.Windows.Forms.Button btnUpdate_College;
        private System.Windows.Forms.Button btnDelete_Department;
        private System.Windows.Forms.Button btnUpdate_Department;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCollegeID;
        private System.Windows.Forms.TextBox txtDepartmentCollegeID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepartmentID;
        private System.Windows.Forms.ComboBox cbCollegeName;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSelectedColl;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnLoad;
    }
}

