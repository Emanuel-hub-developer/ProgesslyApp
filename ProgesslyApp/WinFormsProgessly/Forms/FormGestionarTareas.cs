using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsProgessly.Entities;
using WinFormsProgessly.Helpers;
using WinFormsProgessly.Services;

namespace WinFormsProgessly
{
    public partial class FormGestionarTareas : Form
    {
        private readonly TareaService _tareaService = new TareaService();
        public FormGestionarTareas()
        {
            InitializeComponent();
            LoadTareaFromDb();
        }

        private void LoadTareaFromDb()
        {
            var tareas = _tareaService.GetAllTareasFromDb();
            dataGridView1.DataSource = tareas;

            dataGridView1.Columns["Project"].Visible = false;
            dataGridView1.Columns["Responsable"].Visible = false;
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
            HelperValidator.ValidateCampWithSpaces(txtNameBox, errorProvider1, button1, button2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateOnlyNumbers(txtIdResponsableBox, errorProvider1, button1, button2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            HelperValidator.ValidateOnlyNumbers(txtIdProyectoBox, errorProvider1, button1, button2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var nueva = new TareaModel
            {
                Name = txtNameBox.Text,
                Description = txtDescriptionBox.Text,
                StarDate = dateTimeStarDate.Value,
                DeliveryDate = dateTimeDeliveryDate.Value,
                idProject = int.Parse(txtIdProyectoBox.Text),
                idResponsable = int.Parse(txtIdResponsableBox.Text),
                Status = (EstadoTarea)Enum.Parse(typeof(EstadoTarea), StatusBox.SelectedItem.ToString())
            };


            try
            {
                _tareaService.AddTarea(nueva);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}");
            }

            MessageBox.Show("Tarea Creada Exitosamente!");

            LoadTareaFromDb();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.CurrentRow != null)
            {

                var tarea = (TareaModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtNameBox.Text = tarea.Name;
                txtDescriptionBox.Text = tarea.Description;
                txtIdResponsableBox.Text = tarea.idResponsable.ToString();
                txtIdProyectoBox.Text = tarea.idProject.ToString();
                dateTimeStarDate.Value = tarea.StarDate;
                dateTimeDeliveryDate.Value = tarea.DeliveryDate;
                StatusBox.SelectedItem = tarea.Status.ToString();

                LoadTareaFromDb();
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }


       

        private void textDescriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedStartDateBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedDeliveryDateBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FormGestionarTareas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tarea = (TareaModel)dataGridView1.CurrentRow.DataBoundItem;

            tarea.Name = txtNameBox.Text;
            tarea.Description = txtDescriptionBox.Text;
            tarea.StarDate = dateTimeStarDate.Value;
            tarea.DeliveryDate = dateTimeDeliveryDate.Value;
            tarea.idResponsable = int.Parse(txtIdResponsableBox.Text);
            tarea.idProject = int.Parse(txtIdProyectoBox.Text);
            tarea.Status = (EstadoTarea)Enum.Parse(typeof(EstadoTarea), StatusBox.SelectedItem.ToString());

            try
            {
                _tareaService.UpdateTarea(tarea);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la tarea: {ex.Message}");
            }

            MessageBox.Show("Tarea actualizada exitosamente!");

            LoadTareaFromDb(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
               
                var tarea = (TareaModel)dataGridView1.CurrentRow.DataBoundItem;

               
                var confirm = MessageBox.Show("¿Estas seguro de que deseas eliminar esta tarea?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _tareaService.DeleteTarea(tarea.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar la tarea: {ex.Message}");
                    }

                    LoadTareaFromDb(); 
               
                }
            }
            else
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
            }
        }
    }
}
