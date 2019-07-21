using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData() {
            string sql = "select * from tblUser";
            DataSet ds = SqlHelper.QuerybySql(sql);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(this);
            f.ShowDialog();
        }
    }
}
