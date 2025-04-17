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
    public partial class GestionarProyectos : Form
    {
        public GestionarProyectos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionarProyectos_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void txtNameProject_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateCampWithSpaces(txtNameProject, errorProvider1, button1, button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgesslyAppMenu menu = new ProgesslyAppMenu();
            menu.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textIdResponsable_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateOnlyNumbers(textIdResponsable, errorProvider1, button1, button2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
