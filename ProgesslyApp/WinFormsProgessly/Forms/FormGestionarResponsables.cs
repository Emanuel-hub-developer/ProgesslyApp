using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsProgessly.Entities;
using WinFormsProgessly.Helpers;
using WinFormsProgessly.Services;

namespace WinFormsProgessly
{
    public partial class FormGestionarResponsables : Form
    {
        private readonly ResponsableService _responsableService = new ResponsableService();
        public FormGestionarResponsables()
        {
            InitializeComponent();
            LoadResponsableFromDb();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ProgesslyAppMenu menu = new ProgesslyAppMenu();
            menu.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateCampWithSpaces(txtName, errorProvider1, button1, button2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateCampWithSpaces(txtLastname, errorProvider1, button1, button2);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var responsable = (ResponsableModel)dataGridView1.CurrentRow.DataBoundItem;

                responsable.Name = txtName.Text;
                responsable.Lastname = txtLastname.Text;
                responsable.Email = txtEmail.Text;
                responsable.Telephone = maskedTextBox1.Text;

                _responsableService.UpdateResponsable(responsable);


                MessageBox.Show("Responsable Actualizado Exitosamente!");


                LoadResponsableFromDb();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var nuevoResponsable = new ResponsableModel
            {
                Name = txtName.Text,
                Lastname = txtLastname.Text,
                Email = txtEmail.Text,
                Telephone = maskedTextBox1.Text,

            };
            _responsableService.AddResponsable(nuevoResponsable);

            

            MessageBox.Show("Responsable Creado Exitosamente!");

            ClearCamps();

            LoadResponsableFromDb();
        }

        private void ClearCamps()
        {
            txtName.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            maskedTextBox1.Clear();
           errorProvider1.Clear();
        }
        private void LoadResponsableFromDb()
        {
            var responsables = _responsableService.GetAllResponsableFromDb();
            dataGridView1.DataSource = responsables;

        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.CurrentRow != null)
            {
                var responsable = (ResponsableModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtName.Text = responsable.Name;
                txtLastname.Text = responsable.Lastname;
                txtEmail.Text = responsable.Email;
                maskedTextBox1.Text = responsable.Telephone;
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                var responsable = (ResponsableModel)dataGridView1.CurrentRow.DataBoundItem;


                var confirm = MessageBox.Show("¿Estas seguro de que deseas eliminar este/a responsable?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _responsableService.DeleteResponsable(responsable.Id);
                    MessageBox.Show("Responsable Eliminado Exitosamente");
                    LoadResponsableFromDb();

                }
            }
            else
            {
                MessageBox.Show("Selecciona un responsable para eliminar.");
            }
        }
    }
}
