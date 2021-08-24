using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTable
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlconnection = null;

        private SqlDataAdapter adapter = null;

        private DataTable table = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            sqlconnection = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\ShowTable\Database1.mdf;Integrated Security=True");

            sqlconnection.Open();

            adapter = new SqlDataAdapter("SELECT DataEmployee.ID_Employee, DataEmployee.Employee_name, Functions.FunctionDesc FROM DataEmployee, Functions WHERE DataEmployee.ID_Employee = Functions.ID_Employee", sqlconnection);

            table = new DataTable();

            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adapter.Fill(table);
            //dataGridView1.DataSource = table;
        }
    }
}
