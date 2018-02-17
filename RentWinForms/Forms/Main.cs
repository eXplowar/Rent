using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
//using System.Configuration;
using System.Security.Cryptography;

namespace RentWinForms {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetFullPath(@"..\..\"));
        }

        string sveta = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB\MSSQL\Rent.mdf;Integrated Security=True;Connect Timeout=300";
        string sasha = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|DB\MSSQL\Rent.mdf;Integrated Security=True;Connect Timeout=300";

        private void Main_Load(object sender, EventArgs e) {
            RefreshVersionInfo();

            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.RentConnectionString);
            string command = "SELECT tbl_Firm.Firm_ID, tbl_Contragent.FullName FROM tbl_Firm INNER JOIN tbl_Contragent ON tbl_Firm.Contragent_ID = tbl_Contragent.Contragent_ID";
            SqlDataAdapter da = new SqlDataAdapter(command, sqlConn);

            DataSet ds = new DataSet();
            sqlConn.Open();
            da.Fill(ds, "Firms");
            sqlConn.Close();

            cboFirm.DataSource = ds.Tables["Firms"];
            cboFirm.DisplayMember = "FullName";
            cboFirm.ValueMember = "Firm_ID";
            cboFirm.SelectedIndex = -1;

            if (Properties.Settings.Default.RentConnectionString == sveta) {
                this.cboServer.SelectedItem = "SVETA";
                this.Text = "Main (SVETA)";
            } else if (Properties.Settings.Default.RentConnectionString == sasha) {
                this.cboServer.SelectedItem = "SASHA";
                this.Text = "Main (SASHA)";
            }

            this.cboFirm.SelectedIndexChanged += new EventHandler(CboFirm_SelectedIndexChanged);
            this.cboServer.SelectedValueChanged += new EventHandler(CboServer_SelectedValueChanged);
        }

        private void RefreshVersionInfo() {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                this.lblVersion.Text = ad.CurrentVersion.ToString();
            }
        }

        private void CboFirm_SelectedIndexChanged(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(this.txtLogin.Text)) {
                string password = GetMd5Hash(this.txtPassword.Text.ToString()).ToString();
                if (CheckAccount(this.txtLogin.Text, password))
                    OpenRentForm();
                else
                    MessageBox.Show("Неверный логин или пароль!");
            }
        }

        Guid GetMd5Hash(string s) {
            //переводим строку в байт-массим
            byte[] bytes = Encoding.ASCII.GetBytes(s);//Из примера: byte[] bytes = Encoding.Unicode.GetBytes(s); //Из другого примера: byte[] bytes = Encoding.Default.GetBytes(s);

            //создаем объект для получения средст шифрования
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return new Guid(hash);
        }

        private bool CheckAccount(string login, string HashPassword) {
            SqlConnection sqlCn = null;
            try {
                sqlCn = new SqlConnection(Properties.Settings.Default.RentConnectionString);
                sqlCn.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT [Login], [Password] FROM dbo.tbl_Account WHERE [Login]='{0}'", login), sqlCn);
                SqlDataReader reader = cmd.ExecuteReader();
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;
                reader.Read();
                if ((0 == comparer.Compare(login, reader["Login"])) & (0 == comparer.Compare(HashPassword, reader["Password"].ToString()))) {
                    return true;
                } else {
                    return false;
                }
            } catch (Exception e) {
                MessageBox.Show(string.Format("Ошибка в методе CheckAccount(): {0}", e.Message), "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } finally {
                sqlCn.Close();
            }
        }

        private void OpenRentForm() {
            if (cboFirm.SelectedValue is int) {
                Firm.FirmID = (int)cboFirm.SelectedValue;
                Rent rent = new Rent();
                rent.Show();
                this.Visible = false;
            }
        }

        private void CboServer_SelectedValueChanged(object sender, EventArgs e) {
            if (this.cboServer.SelectedItem.ToString() == "SVETA") {
                //Properties.Settings.Default.RentConnectionString = sveta;
                //Properties.Settings.Default.Save();

                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["RentWinForms.Properties.Settings.RentConnectionString"].ConnectionString = sveta;
                config.Save();
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                if (Properties.Settings.Default.RentConnectionString == sveta) {
                    this.Text = "Main (SVETA)";
                }
            } else if (this.cboServer.SelectedItem.ToString() == "SASHA") {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings[1].ConnectionString = sasha;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                if (Properties.Settings.Default.RentConnectionString == sasha) {
                    this.Text = "Main (SASHA)";
                }
            }
            //MessageBox.Show(Properties.Settings.Default.RentConnectionString);
        }

        private void TxtPassword_DoubleClick(object sender, EventArgs e) {
            ((TextBox)sender).Text = this.txtLogin.Text;
        }
    }
}