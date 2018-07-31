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

namespace TESTDATA
{
    public partial class Form1 : Form
    {
        SqlConnection _conn = null;
        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=1601DASP;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _conn.Open();
            SqlCommand _Cmd = new SqlCommand("SELECT DISTINCT(PROG_NAME) FROM UN_PROGRAMS", _conn);
        SqlDataReader dr = _Cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
            _conn.Close();

        }
    }
}
