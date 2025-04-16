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
    public partial class FormGestionarTareas : Form
    {
        public FormGestionarTareas()
        {
            InitializeComponent();
        }

        private void btonVolver_Click(object sender, EventArgs e)
        {
            ProgesslyAppMenu menu = new ProgesslyAppMenu();
            menu.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateCampWithSpaces(textBox1, errorProvider1, button1, button2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateOnlyNumbers(textBox4, errorProvider1, button1, button2);
        }
    }
}
