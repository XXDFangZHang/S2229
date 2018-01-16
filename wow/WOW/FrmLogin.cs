using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WOW
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblzc_Click(object sender, EventArgs e)
        {
            FrmRegist r = new FrmRegist(this);

            this.Hide();
            r.Show();
        }
        public LoginInfo[] array;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            array = new LoginInfo[20];
            LoginInfo info = new LoginInfo();
            info.Name = "小明";
            info.Id = "2229001";
            info.Password = "123";
            info.Email = "123@qq.com";
            array[0] = info;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "" || txtpwd.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }
            else
            {
                string name = txtAddress.Text;
                string pwd = txtpwd.Text;
                foreach (LoginInfo item in array)
                {
                    if (item != null)
                    {
                        if (item.Email == name && item.Password == pwd)
                        {
                            FrmMain main = new FrmMain();
                            this.Hide();

                            main.lblname.Text = "欢迎，" + item.Name;
                            main.Show();
                            break;
                        }
                       
                    }
                }
                foreach (LoginInfo item in FrmRegist.log)
                {
                    if (item != null)
                    {
                        if (item.Email == name && item.Password == pwd)
                        {
                            FrmMain main = new FrmMain();
                            this.Hide();

                            main.lblname.Text = "欢迎，" + item.Name;
                            main.Show();
                            break;
                        }
                       
                    }

                }
            }



        }
    }
}
