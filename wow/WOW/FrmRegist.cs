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
    public partial class FrmRegist : Form
    {
        public FrmRegist(FrmLogin fi)
        {
            InitializeComponent();
            info = fi;
        }
        public static LoginInfo[] log = new LoginInfo[30];
        private void btnCanle_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin log = new FrmLogin();
            log.Show();
        }
        public FrmLogin info;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoginInfo f1 = new LoginInfo();
            if(txtName.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("请输入用户名！");
               
            }
            else if (txtCard.Text.Trim().Equals(string.Empty))
            {
                 MessageBox.Show("请输入身份证号码！");
            }
            else if (txtAddress.Text.Trim().Equals(string.Empty) || txtAddress1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请检查邮箱地址！");
            }else if(txtAddress.Text.Trim()!=txtAddress1.Text.Trim()){
                MessageBox.Show("邮箱地址不一致！");
            }
            else if (txtpwd.Text.Trim().Equals(string.Empty) || txtpwd1.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请检查密码！");
            }else if( txtpwd.Text.Trim() != txtpwd1.Text.Trim()){
                MessageBox.Show("密码不一致！");
            }
            else  {
               
                f1.Name = txtName.Text;
                f1.Password = txtpwd.Text;
                f1.Id = txtCard.Text;
                f1.Email = txtAddress.Text;
                
                MessageBox.Show("恭喜，通过验证！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                FrmLogin lon = new FrmLogin();
                lon.Show();
            }
            for (int i = 0; i <log.Length; i++)
            {
                if (log[i] == null)
                {
                    log[i] = f1;
                    break;
                }
            }
              
        }
    }
}
