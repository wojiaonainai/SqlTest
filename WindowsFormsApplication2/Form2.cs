using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtZH.Text==""||txtMM.Text=="")
            {
                MessageBox.Show("请输入账号或密码!");
                return;
            }
            string sql = "select * from tblUser where username='"+ txtZH.Text + "' and userpwd='"+ txtMM.Text + "'";
           /// string sql1 = string.Format("select * from tblUser where username='{0}' and userpwd='{1}'", txtZH.Text, txtMM.Text);
            DataSet ds=SqlHelper.QuerybySql(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Form1 f = new Form1();
                f.Show();
            }
            else {
                MessageBox.Show("账号或密码错误！");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
