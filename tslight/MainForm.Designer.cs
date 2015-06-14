/*
 * User: Korenev
 * Date: 20.09.2010
 * Time: 12:06
 * 
 */
namespace tslight
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btn_Connect = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Connect = new System.Windows.Forms.Label();
            this.ctl_Connect = new System.Windows.Forms.Panel();
            this.ctl_Tabs = new System.Windows.Forms.TabControl();
            this.tab_Security = new System.Windows.Forms.TabPage();
            this.dg_Security = new System.Windows.Forms.DataGridView();
            this.security_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security_board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security_point_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Param = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.btnPassChange = new System.Windows.Forms.Button();
            this.checkHide = new System.Windows.Forms.CheckBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.edt_Port = new System.Windows.Forms.TextBox();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.edt_IP = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.edt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.edt_Login = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dg_quotation = new System.Windows.Forms.DataGridView();
            this.txtBoxAns = new System.Windows.Forms.RichTextBox();
            this.quotation_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_biddepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_numbids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotation_last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctl_Connect.SuspendLayout();
            this.ctl_Tabs.SuspendLayout();
            this.tab_Security.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Security)).BeginInit();
            this.tab_Param.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_quotation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(341, 40);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(109, 22);
            this.btn_Connect.TabIndex = 0;
            this.btn_Connect.Text = "Подключить";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(829, 35);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(325, 44);
            this.txt_Status.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(872, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 22);
            this.panel1.TabIndex = 2;
            // 
            // txt_Connect
            // 
            this.txt_Connect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_Connect.ForeColor = System.Drawing.Color.Black;
            this.txt_Connect.Location = new System.Drawing.Point(3, 4);
            this.txt_Connect.Name = "txt_Connect";
            this.txt_Connect.Size = new System.Drawing.Size(86, 14);
            this.txt_Connect.TabIndex = 3;
            this.txt_Connect.Text = "offline";
            this.txt_Connect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ctl_Connect
            // 
            this.ctl_Connect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctl_Connect.Controls.Add(this.txt_Connect);
            this.ctl_Connect.Location = new System.Drawing.Point(341, 115);
            this.ctl_Connect.Name = "ctl_Connect";
            this.ctl_Connect.Size = new System.Drawing.Size(96, 22);
            this.ctl_Connect.TabIndex = 4;
            // 
            // ctl_Tabs
            // 
            this.ctl_Tabs.Controls.Add(this.tab_Security);
            this.ctl_Tabs.Controls.Add(this.tab_Param);
            this.ctl_Tabs.Controls.Add(this.tabPage1);
            this.ctl_Tabs.Location = new System.Drawing.Point(12, 12);
            this.ctl_Tabs.Name = "ctl_Tabs";
            this.ctl_Tabs.SelectedIndex = 0;
            this.ctl_Tabs.Size = new System.Drawing.Size(683, 618);
            this.ctl_Tabs.TabIndex = 7;
            // 
            // tab_Security
            // 
            this.tab_Security.Controls.Add(this.dg_Security);
            this.tab_Security.Location = new System.Drawing.Point(4, 22);
            this.tab_Security.Name = "tab_Security";
            this.tab_Security.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Security.Size = new System.Drawing.Size(675, 592);
            this.tab_Security.TabIndex = 1;
            this.tab_Security.Text = "Инструменты";
            this.tab_Security.UseVisualStyleBackColor = true;
            // 
            // dg_Security
            // 
            this.dg_Security.AllowDrop = true;
            this.dg_Security.AllowUserToAddRows = false;
            this.dg_Security.AllowUserToDeleteRows = false;
            this.dg_Security.AllowUserToResizeRows = false;
            this.dg_Security.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Security.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.security_id,
            this.security_name,
            this.security_code,
            this.lotsize,
            this.security_board,
            this.security_point_cost});
            this.dg_Security.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_Security.Location = new System.Drawing.Point(3, 3);
            this.dg_Security.MultiSelect = false;
            this.dg_Security.Name = "dg_Security";
            this.dg_Security.RowHeadersWidth = 20;
            this.dg_Security.RowTemplate.Height = 18;
            this.dg_Security.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Security.Size = new System.Drawing.Size(669, 586);
            this.dg_Security.TabIndex = 0;
            this.dg_Security.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Security_CellContentClick);
            // 
            // security_id
            // 
            this.security_id.DataPropertyName = "security_id";
            this.security_id.Frozen = true;
            this.security_id.HeaderText = "id";
            this.security_id.MinimumWidth = 50;
            this.security_id.Name = "security_id";
            this.security_id.ReadOnly = true;
            this.security_id.Width = 50;
            // 
            // security_name
            // 
            this.security_name.DataPropertyName = "security_name";
            this.security_name.HeaderText = "Название";
            this.security_name.MinimumWidth = 100;
            this.security_name.Name = "security_name";
            this.security_name.ReadOnly = true;
            this.security_name.Width = 150;
            // 
            // security_code
            // 
            this.security_code.DataPropertyName = "security_code";
            this.security_code.HeaderText = "Код";
            this.security_code.MinimumWidth = 50;
            this.security_code.Name = "security_code";
            this.security_code.ReadOnly = true;
            // 
            // lotsize
            // 
            this.lotsize.DataPropertyName = "lotsize";
            this.lotsize.HeaderText = "Лот";
            this.lotsize.MinimumWidth = 30;
            this.lotsize.Name = "lotsize";
            this.lotsize.ReadOnly = true;
            this.lotsize.Width = 50;
            // 
            // security_board
            // 
            this.security_board.DataPropertyName = "security_board";
            this.security_board.HeaderText = "индефек";
            this.security_board.Name = "security_board";
            this.security_board.ReadOnly = true;
            this.security_board.Width = 50;
            // 
            // security_point_cost
            // 
            this.security_point_cost.DataPropertyName = "security_point_cost";
            this.security_point_cost.HeaderText = "цена";
            this.security_point_cost.Name = "security_point_cost";
            this.security_point_cost.ReadOnly = true;
            this.security_point_cost.Width = 50;
            // 
            // tab_Param
            // 
            this.tab_Param.Controls.Add(this.button1);
            this.tab_Param.Controls.Add(this.label4);
            this.tab_Param.Controls.Add(this.label3);
            this.tab_Param.Controls.Add(this.txtOldPass);
            this.tab_Param.Controls.Add(this.ctl_Connect);
            this.tab_Param.Controls.Add(this.btnPassChange);
            this.tab_Param.Controls.Add(this.btn_Connect);
            this.tab_Param.Controls.Add(this.checkHide);
            this.tab_Param.Controls.Add(this.txtNewPass);
            this.tab_Param.Controls.Add(this.label2);
            this.tab_Param.Controls.Add(this.lbl_Port);
            this.tab_Param.Controls.Add(this.edt_Port);
            this.tab_Param.Controls.Add(this.lbl_IP);
            this.tab_Param.Controls.Add(this.edt_IP);
            this.tab_Param.Controls.Add(this.lbl_Password);
            this.tab_Param.Controls.Add(this.edt_Password);
            this.tab_Param.Controls.Add(this.lbl_Login);
            this.tab_Param.Controls.Add(this.edt_Login);
            this.tab_Param.Location = new System.Drawing.Point(4, 22);
            this.tab_Param.Name = "tab_Param";
            this.tab_Param.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Param.Size = new System.Drawing.Size(675, 592);
            this.tab_Param.TabIndex = 2;
            this.tab_Param.Text = "Параметры";
            this.tab_Param.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "стакан";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Новый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Старый";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(135, 218);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(122, 20);
            this.txtOldPass.TabIndex = 29;
            // 
            // btnPassChange
            // 
            this.btnPassChange.Location = new System.Drawing.Point(135, 302);
            this.btnPassChange.Name = "btnPassChange";
            this.btnPassChange.Size = new System.Drawing.Size(75, 23);
            this.btnPassChange.TabIndex = 28;
            this.btnPassChange.Text = "Сменить";
            this.btnPassChange.UseVisualStyleBackColor = true;
            this.btnPassChange.Click += new System.EventHandler(this.btnPassChange_Click);
            // 
            // checkHide
            // 
            this.checkHide.AutoSize = true;
            this.checkHide.Checked = true;
            this.checkHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkHide.Location = new System.Drawing.Point(135, 274);
            this.checkHide.Name = "checkHide";
            this.checkHide.Size = new System.Drawing.Size(76, 17);
            this.checkHide.TabIndex = 27;
            this.checkHide.Text = "Скрывать";
            this.checkHide.UseVisualStyleBackColor = true;
            this.checkHide.CheckedChanged += new System.EventHandler(this.checkHide_CheckedChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(135, 248);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(122, 20);
            this.txtNewPass.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Смена пароля";
            // 
            // lbl_Port
            // 
            this.lbl_Port.Location = new System.Drawing.Point(22, 118);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(100, 14);
            this.lbl_Port.TabIndex = 17;
            this.lbl_Port.Text = "Порт";
            // 
            // edt_Port
            // 
            this.edt_Port.Location = new System.Drawing.Point(135, 115);
            this.edt_Port.Name = "edt_Port";
            this.edt_Port.Size = new System.Drawing.Size(122, 20);
            this.edt_Port.TabIndex = 16;
            // 
            // lbl_IP
            // 
            this.lbl_IP.Location = new System.Drawing.Point(22, 92);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(100, 14);
            this.lbl_IP.TabIndex = 13;
            this.lbl_IP.Text = "IP адрес";
            // 
            // edt_IP
            // 
            this.edt_IP.Location = new System.Drawing.Point(135, 89);
            this.edt_IP.Name = "edt_IP";
            this.edt_IP.Size = new System.Drawing.Size(122, 20);
            this.edt_IP.TabIndex = 12;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(22, 66);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(100, 14);
            this.lbl_Password.TabIndex = 11;
            this.lbl_Password.Text = "Пароль";
            // 
            // edt_Password
            // 
            this.edt_Password.Location = new System.Drawing.Point(135, 63);
            this.edt_Password.Name = "edt_Password";
            this.edt_Password.Size = new System.Drawing.Size(122, 20);
            this.edt_Password.TabIndex = 10;
            this.edt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Login
            // 
            this.lbl_Login.Location = new System.Drawing.Point(22, 40);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(100, 14);
            this.lbl_Login.TabIndex = 9;
            this.lbl_Login.Text = "Логин";
            this.lbl_Login.Click += new System.EventHandler(this.lbl_Login_Click);
            // 
            // edt_Login
            // 
            this.edt_Login.Location = new System.Drawing.Point(135, 37);
            this.edt_Login.Name = "edt_Login";
            this.edt_Login.Size = new System.Drawing.Size(122, 20);
            this.edt_Login.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dg_quotation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 592);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "котир. по инструм.";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dg_quotation
            // 
            this.dg_quotation.AllowDrop = true;
            this.dg_quotation.AllowUserToAddRows = false;
            this.dg_quotation.AllowUserToDeleteRows = false;
            this.dg_quotation.AllowUserToResizeRows = false;
            this.dg_quotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_quotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quotation_id,
            this.quotation_code,
            this.quotation_open,
            this.quotation_biddepth,
            this.quotation_numbids,
            this.quotation_last});
            this.dg_quotation.Location = new System.Drawing.Point(-4, 0);
            this.dg_quotation.Name = "dg_quotation";
            this.dg_quotation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_quotation.Size = new System.Drawing.Size(656, 580);
            this.dg_quotation.TabIndex = 1;
            // 
            // txtBoxAns
            // 
            this.txtBoxAns.Location = new System.Drawing.Point(949, 87);
            this.txtBoxAns.Name = "txtBoxAns";
            this.txtBoxAns.Size = new System.Drawing.Size(205, 543);
            this.txtBoxAns.TabIndex = 26;
            this.txtBoxAns.Text = "";
            // 
            // quotation_id
            // 
            this.quotation_id.DataPropertyName = "quotation_id";
            this.quotation_id.Frozen = true;
            this.quotation_id.HeaderText = "id";
            this.quotation_id.Name = "quotation_id";
            this.quotation_id.ReadOnly = true;
            // 
            // quotation_code
            // 
            this.quotation_code.DataPropertyName = "quotation_code";
            this.quotation_code.Frozen = true;
            this.quotation_code.HeaderText = "код инструмента";
            this.quotation_code.Name = "quotation_code";
            this.quotation_code.ReadOnly = true;
            // 
            // quotation_open
            // 
            this.quotation_open.DataPropertyName = "quotation_open";
            this.quotation_open.Frozen = true;
            this.quotation_open.HeaderText = "стоим пункт";
            this.quotation_open.Name = "quotation_open";
            this.quotation_open.ReadOnly = true;
            // 
            // quotation_biddepth
            // 
            this.quotation_biddepth.DataPropertyName = "quotation_biddepth";
            this.quotation_biddepth.Frozen = true;
            this.quotation_biddepth.HeaderText = "цена первой сделки";
            this.quotation_biddepth.Name = "quotation_biddepth";
            this.quotation_biddepth.ReadOnly = true;
            // 
            // quotation_numbids
            // 
            this.quotation_numbids.DataPropertyName = "quotation_numbids";
            this.quotation_numbids.Frozen = true;
            this.quotation_numbids.HeaderText = "кол-во лотов на поку";
            this.quotation_numbids.Name = "quotation_numbids";
            this.quotation_numbids.ReadOnly = true;
            // 
            // quotation_last
            // 
            this.quotation_last.DataPropertyName = "quotation_last";
            this.quotation_last.Frozen = true;
            this.quotation_last.HeaderText = "заявак на покупку";
            this.quotation_last.Name = "quotation_last";
            this.quotation_last.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 640);
            this.Controls.Add(this.txtBoxAns);
            this.Controls.Add(this.ctl_Tabs);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Test connector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ctl_Connect.ResumeLayout(false);
            this.ctl_Tabs.ResumeLayout(false);
            this.tab_Security.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Security)).EndInit();
            this.tab_Param.ResumeLayout(false);
            this.tab_Param.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_quotation)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox edt_Port;
		private System.Windows.Forms.Label lbl_Port;
		private System.Windows.Forms.TextBox edt_IP;
		private System.Windows.Forms.TextBox edt_Password;
        private System.Windows.Forms.TextBox edt_Login;
		private System.Windows.Forms.Label lbl_Login;
		private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_IP;
		private System.Windows.Forms.DataGridView dg_Security;
		private System.Windows.Forms.TabPage tab_Param;
		private System.Windows.Forms.TabPage tab_Security;
        private System.Windows.Forms.TabControl ctl_Tabs;
		private System.Windows.Forms.Panel ctl_Connect;
		private System.Windows.Forms.Label txt_Connect;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label txt_Status;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.RichTextBox txtBoxAns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Button btnPassChange;
        private System.Windows.Forms.CheckBox checkHide;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_board;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_point_cost;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dg_quotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_open;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_biddepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_numbids;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotation_last;
	}
}
