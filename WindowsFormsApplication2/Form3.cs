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
    public partial class Form3 : Form
    {

        Form1 f;
        public Form3(Form1 f)
        {
            this.f = f;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into tbluser(username,userpwd)values('{0}','{1}')",txtZH.Text,txtMM.Text);
            if (SqlHelper.ExecuteSql(sql) > 0)
                f.BindData();
            else
                MessageBox.Show("添加失败");
        }
    }
}
