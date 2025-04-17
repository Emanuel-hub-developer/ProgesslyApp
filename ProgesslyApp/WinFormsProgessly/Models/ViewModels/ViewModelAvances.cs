using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProgessly.Helpers;

namespace WinFormsProgessly
{
    public partial class ViewModelAvances : Form
    {
        public ViewModelAvances()
        {
            InitializeComponent();
            LoadViewProjects();
            LoadViewTareas();
        }

        SqlConnection connection = new SqlConnection(ConnectionStringDb.GetsConnectionString());


        private void LoadViewProjects()
        {

            string query = "select * from Projects";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void LoadViewTareas()
        {

            string query = "select * from Tareas";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttnVolver_Click(object sender, EventArgs e)
        {
            ProgesslyAppMenu menu = new ProgesslyAppMenu();
            menu.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
