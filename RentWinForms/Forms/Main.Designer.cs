namespace RentWinForms
{
    partial class Main
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
            this.rentDataSet = new RentWinForms.RentDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPgMain = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblFirm = new System.Windows.Forms.Label();
            this.cboFirm = new System.Windows.Forms.ComboBox();
            this.tabPgSettings = new System.Windows.Forms.TabPage();
            this.lblServer = new System.Windows.Forms.Label();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPgMain.SuspendLayout();
            this.tabPgSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPgMain);
            this.tabControl1.Controls.Add(this.tabPgSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 238);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPgMain
            // 
            this.tabPgMain.Controls.Add(this.lblPassword);
            this.tabPgMain.Controls.Add(this.txtPassword);
            this.tabPgMain.Controls.Add(this.lblLogin);
            this.tabPgMain.Controls.Add(this.txtLogin);
            this.tabPgMain.Controls.Add(this.lblFirm);
            this.tabPgMain.Controls.Add(this.cboFirm);
            this.tabPgMain.Location = new System.Drawing.Point(4, 22);
            this.tabPgMain.Name = "tabPgMain";
            this.tabPgMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgMain.Size = new System.Drawing.Size(252, 212);
            this.tabPgMain.TabIndex = 0;
            this.tabPgMain.Text = "Welcome";
            this.tabPgMain.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Admin";
            this.txtPassword.DoubleClick += new System.EventHandler(this.TxtPassword_DoubleClick);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(51, 43);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(97, 40);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "Admin";
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(33, 137);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(58, 13);
            this.lblFirm.TabIndex = 2;
            this.lblFirm.Text = "Компания";
            // 
            // cboFirm
            // 
            this.cboFirm.Location = new System.Drawing.Point(97, 134);
            this.cboFirm.Name = "cboFirm";
            this.cboFirm.Size = new System.Drawing.Size(121, 21);
            this.cboFirm.TabIndex = 1;
            // 
            // tabPgSettings
            // 
            this.tabPgSettings.Controls.Add(this.lblServer);
            this.tabPgSettings.Controls.Add(this.cboServer);
            this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPgSettings.Name = "tabPgSettings";
            this.tabPgSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgSettings.Size = new System.Drawing.Size(252, 212);
            this.tabPgSettings.TabIndex = 1;
            this.tabPgSettings.Text = "Settings";
            this.tabPgSettings.UseVisualStyleBackColor = true;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(5, 9);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(44, 13);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Сервер";
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Items.AddRange(new object[] {
            "SVETA",
            "SASHA"});
            this.cboServer.Location = new System.Drawing.Point(55, 6);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(121, 21);
            this.cboServer.TabIndex = 0;
            this.cboServer.SelectedValueChanged += new System.EventHandler(this.CboServer_SelectedValueChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(216, 253);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(52, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "lblVersion";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 269);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPgMain.ResumeLayout(false);
            this.tabPgMain.PerformLayout();
            this.tabPgSettings.ResumeLayout(false);
            this.tabPgSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RentDataSet rentDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPgMain;
        private System.Windows.Forms.ComboBox cboFirm;
        private System.Windows.Forms.TabPage tabPgSettings;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
    }
}