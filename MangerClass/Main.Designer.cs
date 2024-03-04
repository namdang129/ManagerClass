namespace ManagerClass
{
    partial class ManagerClass
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
            this.tabStu = new System.Windows.Forms.TabPage();
            this.DGV_Stu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_IdStu = new System.Windows.Forms.TextBox();
            this.lb_IDStu = new System.Windows.Forms.Label();
            this.btn_DelS = new System.Windows.Forms.Button();
            this.btn_UpdateS = new System.Windows.Forms.Button();
            this.lbCLass = new System.Windows.Forms.Label();
            this.lbNation = new System.Windows.Forms.Label();
            this.tb_Adres = new System.Windows.Forms.TextBox();
            this.btn_AddS = new System.Windows.Forms.Button();
            this.lbBday = new System.Windows.Forms.Label();
            this.tb_NameS = new System.Windows.Forms.TextBox();
            this.dtpBorn = new System.Windows.Forms.DateTimePicker();
            this.cb_Class = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.tabClass = new System.Windows.Forms.TabPage();
            this.DGV_Class = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_ClassId = new System.Windows.Forms.TextBox();
            this.lb_ClassId = new System.Windows.Forms.Label();
            this.cb_Grade = new System.Windows.Forms.ComboBox();
            this.tb_Class = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.Label();
            this.NameClass = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_UpdateC = new System.Windows.Forms.Button();
            this.btn_AddC = new System.Windows.Forms.Button();
            this.tabManager = new System.Windows.Forms.TabControl();
            this.tabStu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stu)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Class)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStu
            // 
            this.tabStu.Controls.Add(this.DGV_Stu);
            this.tabStu.Controls.Add(this.panel2);
            this.tabStu.Location = new System.Drawing.Point(4, 22);
            this.tabStu.Name = "tabStu";
            this.tabStu.Padding = new System.Windows.Forms.Padding(3);
            this.tabStu.Size = new System.Drawing.Size(605, 397);
            this.tabStu.TabIndex = 1;
            this.tabStu.Text = "Học sinh";
            this.tabStu.UseVisualStyleBackColor = true;
            // 
            // DGV_Stu
            // 
            this.DGV_Stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Stu.Location = new System.Drawing.Point(6, 176);
            this.DGV_Stu.Name = "DGV_Stu";
            this.DGV_Stu.Size = new System.Drawing.Size(590, 209);
            this.DGV_Stu.TabIndex = 1;
            this.DGV_Stu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Stu_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_IdStu);
            this.panel2.Controls.Add(this.lb_IDStu);
            this.panel2.Controls.Add(this.btn_DelS);
            this.panel2.Controls.Add(this.btn_UpdateS);
            this.panel2.Controls.Add(this.lbCLass);
            this.panel2.Controls.Add(this.lbNation);
            this.panel2.Controls.Add(this.tb_Adres);
            this.panel2.Controls.Add(this.btn_AddS);
            this.panel2.Controls.Add(this.lbBday);
            this.panel2.Controls.Add(this.tb_NameS);
            this.panel2.Controls.Add(this.dtpBorn);
            this.panel2.Controls.Add(this.cb_Class);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 164);
            this.panel2.TabIndex = 0;
            // 
            // tb_IdStu
            // 
            this.tb_IdStu.Enabled = false;
            this.tb_IdStu.Location = new System.Drawing.Point(85, 6);
            this.tb_IdStu.Name = "tb_IdStu";
            this.tb_IdStu.Size = new System.Drawing.Size(285, 20);
            this.tb_IdStu.TabIndex = 24;
            // 
            // lb_IDStu
            // 
            this.lb_IDStu.AutoSize = true;
            this.lb_IDStu.Location = new System.Drawing.Point(11, 9);
            this.lb_IDStu.Name = "lb_IDStu";
            this.lb_IDStu.Size = new System.Drawing.Size(65, 13);
            this.lb_IDStu.TabIndex = 23;
            this.lb_IDStu.Text = "Mã học sinh";
            // 
            // btn_DelS
            // 
            this.btn_DelS.Location = new System.Drawing.Point(454, 106);
            this.btn_DelS.Name = "btn_DelS";
            this.btn_DelS.Size = new System.Drawing.Size(96, 42);
            this.btn_DelS.TabIndex = 28;
            this.btn_DelS.Text = "Xóa";
            this.btn_DelS.UseVisualStyleBackColor = true;
            this.btn_DelS.Click += new System.EventHandler(this.btn_DelS_Click);
            // 
            // btn_UpdateS
            // 
            this.btn_UpdateS.Location = new System.Drawing.Point(454, 58);
            this.btn_UpdateS.Name = "btn_UpdateS";
            this.btn_UpdateS.Size = new System.Drawing.Size(96, 42);
            this.btn_UpdateS.TabIndex = 27;
            this.btn_UpdateS.Text = "Sửa thông tin";
            this.btn_UpdateS.UseVisualStyleBackColor = true;
            this.btn_UpdateS.Click += new System.EventHandler(this.btn_UpdateS_Click);
            // 
            // lbCLass
            // 
            this.lbCLass.AutoSize = true;
            this.lbCLass.Location = new System.Drawing.Point(13, 120);
            this.lbCLass.Name = "lbCLass";
            this.lbCLass.Size = new System.Drawing.Size(25, 13);
            this.lbCLass.TabIndex = 21;
            this.lbCLass.Text = "Lớp";
            // 
            // lbNation
            // 
            this.lbNation.AutoSize = true;
            this.lbNation.Location = new System.Drawing.Point(12, 92);
            this.lbNation.Name = "lbNation";
            this.lbNation.Size = new System.Drawing.Size(56, 13);
            this.lbNation.TabIndex = 20;
            this.lbNation.Text = "Quê Quán";
            // 
            // tb_Adres
            // 
            this.tb_Adres.Location = new System.Drawing.Point(85, 89);
            this.tb_Adres.Name = "tb_Adres";
            this.tb_Adres.Size = new System.Drawing.Size(285, 20);
            this.tb_Adres.TabIndex = 23;
            // 
            // btn_AddS
            // 
            this.btn_AddS.Location = new System.Drawing.Point(454, 11);
            this.btn_AddS.Name = "btn_AddS";
            this.btn_AddS.Size = new System.Drawing.Size(96, 41);
            this.btn_AddS.TabIndex = 26;
            this.btn_AddS.Text = "Thêm mới";
            this.btn_AddS.UseVisualStyleBackColor = true;
            this.btn_AddS.Click += new System.EventHandler(this.btn_AddS_Click);
            // 
            // lbBday
            // 
            this.lbBday.AutoSize = true;
            this.lbBday.Location = new System.Drawing.Point(12, 63);
            this.lbBday.Name = "lbBday";
            this.lbBday.Size = new System.Drawing.Size(56, 13);
            this.lbBday.TabIndex = 19;
            this.lbBday.Text = "Ngày Sinh";
            // 
            // tb_NameS
            // 
            this.tb_NameS.Location = new System.Drawing.Point(85, 32);
            this.tb_NameS.Name = "tb_NameS";
            this.tb_NameS.Size = new System.Drawing.Size(285, 20);
            this.tb_NameS.TabIndex = 22;
            // 
            // dtpBorn
            // 
            this.dtpBorn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorn.Location = new System.Drawing.Point(85, 63);
            this.dtpBorn.Name = "dtpBorn";
            this.dtpBorn.Size = new System.Drawing.Size(285, 20);
            this.dtpBorn.TabIndex = 24;
            this.dtpBorn.Value = new System.DateTime(2024, 2, 28, 0, 0, 0, 0);
            // 
            // cb_Class
            // 
            this.cb_Class.FormattingEnabled = true;
            this.cb_Class.Location = new System.Drawing.Point(85, 119);
            this.cb_Class.Name = "cb_Class";
            this.cb_Class.Size = new System.Drawing.Size(285, 21);
            this.cb_Class.TabIndex = 25;
            this.cb_Class.SelectedIndexChanged += new System.EventHandler(this.cb_Class_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(11, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(58, 13);
            this.lbName.TabIndex = 18;
            this.lbName.Text = "Họ và Tên";
            // 
            // tabClass
            // 
            this.tabClass.Controls.Add(this.DGV_Class);
            this.tabClass.Controls.Add(this.panel1);
            this.tabClass.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabClass.Location = new System.Drawing.Point(4, 22);
            this.tabClass.Name = "tabClass";
            this.tabClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabClass.Size = new System.Drawing.Size(605, 397);
            this.tabClass.TabIndex = 0;
            this.tabClass.Text = "Lớp học";
            this.tabClass.UseVisualStyleBackColor = true;
            // 
            // DGV_Class
            // 
            this.DGV_Class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Class.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Class.Location = new System.Drawing.Point(9, 169);
            this.DGV_Class.Name = "DGV_Class";
            this.DGV_Class.Size = new System.Drawing.Size(590, 208);
            this.DGV_Class.TabIndex = 1;
            this.DGV_Class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Class_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_ClassId);
            this.panel1.Controls.Add(this.lb_ClassId);
            this.panel1.Controls.Add(this.cb_Grade);
            this.panel1.Controls.Add(this.tb_Class);
            this.panel1.Controls.Add(this.Grade);
            this.panel1.Controls.Add(this.NameClass);
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_UpdateC);
            this.panel1.Controls.Add(this.btn_AddC);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 157);
            this.panel1.TabIndex = 0;
            // 
            // tb_ClassId
            // 
            this.tb_ClassId.Enabled = false;
            this.tb_ClassId.Location = new System.Drawing.Point(106, 19);
            this.tb_ClassId.Name = "tb_ClassId";
            this.tb_ClassId.Size = new System.Drawing.Size(117, 20);
            this.tb_ClassId.TabIndex = 25;
            // 
            // lb_ClassId
            // 
            this.lb_ClassId.AutoSize = true;
            this.lb_ClassId.Location = new System.Drawing.Point(26, 26);
            this.lb_ClassId.Name = "lb_ClassId";
            this.lb_ClassId.Size = new System.Drawing.Size(43, 13);
            this.lb_ClassId.TabIndex = 24;
            this.lb_ClassId.Text = "Mã Lớp";
            // 
            // cb_Grade
            // 
            this.cb_Grade.FormattingEnabled = true;
            this.cb_Grade.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cb_Grade.Location = new System.Drawing.Point(106, 83);
            this.cb_Grade.Name = "cb_Grade";
            this.cb_Grade.Size = new System.Drawing.Size(117, 21);
            this.cb_Grade.TabIndex = 24;
            // 
            // tb_Class
            // 
            this.tb_Class.Location = new System.Drawing.Point(106, 45);
            this.tb_Class.Name = "tb_Class";
            this.tb_Class.Size = new System.Drawing.Size(117, 20);
            this.tb_Class.TabIndex = 23;
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Location = new System.Drawing.Point(26, 91);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(28, 13);
            this.Grade.TabIndex = 22;
            this.Grade.Text = "Khối";
            // 
            // NameClass
            // 
            this.NameClass.AutoSize = true;
            this.NameClass.Location = new System.Drawing.Point(26, 52);
            this.NameClass.Name = "NameClass";
            this.NameClass.Size = new System.Drawing.Size(47, 13);
            this.NameClass.TabIndex = 21;
            this.NameClass.Text = "Tên Lớp";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(377, 110);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(96, 42);
            this.btn_Del.TabIndex = 20;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_UpdateC
            // 
            this.btn_UpdateC.Location = new System.Drawing.Point(377, 62);
            this.btn_UpdateC.Name = "btn_UpdateC";
            this.btn_UpdateC.Size = new System.Drawing.Size(96, 42);
            this.btn_UpdateC.TabIndex = 19;
            this.btn_UpdateC.Text = "Cập nhật";
            this.btn_UpdateC.UseVisualStyleBackColor = true;
            this.btn_UpdateC.Click += new System.EventHandler(this.btn_UpdateC_Click);
            // 
            // btn_AddC
            // 
            this.btn_AddC.Location = new System.Drawing.Point(377, 10);
            this.btn_AddC.Name = "btn_AddC";
            this.btn_AddC.Size = new System.Drawing.Size(96, 41);
            this.btn_AddC.TabIndex = 18;
            this.btn_AddC.Text = "Thêm mới";
            this.btn_AddC.UseVisualStyleBackColor = true;
            this.btn_AddC.Click += new System.EventHandler(this.btn_AddC_Click);
            // 
            // tabManager
            // 
            this.tabManager.Controls.Add(this.tabClass);
            this.tabManager.Controls.Add(this.tabStu);
            this.tabManager.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabManager.Location = new System.Drawing.Point(12, 12);
            this.tabManager.Name = "tabManager";
            this.tabManager.SelectedIndex = 0;
            this.tabManager.Size = new System.Drawing.Size(613, 423);
            this.tabManager.TabIndex = 12;
            // 
            // ManagerClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 431);
            this.Controls.Add(this.tabManager);
            this.Name = "ManagerClass";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.ManagerClass_Load);
            this.tabStu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Class)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabStu;
        private System.Windows.Forms.DataGridView DGV_Stu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_DelS;
        private System.Windows.Forms.Button btn_UpdateS;
        private System.Windows.Forms.Label lbCLass;
        private System.Windows.Forms.Label lbNation;
        private System.Windows.Forms.TextBox tb_Adres;
        private System.Windows.Forms.Button btn_AddS;
        private System.Windows.Forms.Label lbBday;
        private System.Windows.Forms.TextBox tb_NameS;
        private System.Windows.Forms.DateTimePicker dtpBorn;
        private System.Windows.Forms.ComboBox cb_Class;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TabPage tabClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_Grade;
        private System.Windows.Forms.TextBox tb_Class;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label NameClass;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_UpdateC;
        private System.Windows.Forms.Button btn_AddC;
        private System.Windows.Forms.DataGridView DGV_Class;
        private System.Windows.Forms.TabControl tabManager;
        private System.Windows.Forms.TextBox tb_ClassId;
        private System.Windows.Forms.Label lb_ClassId;
        private System.Windows.Forms.TextBox tb_IdStu;
        private System.Windows.Forms.Label lb_IDStu;
    }
}

