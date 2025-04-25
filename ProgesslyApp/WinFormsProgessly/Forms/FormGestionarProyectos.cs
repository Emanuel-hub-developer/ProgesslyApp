using WinFormsProgessly.Data;
using WinFormsProgessly.Entities;
using WinFormsProgessly.Helpers;
using WinFormsProgessly.Services;

namespace WinFormsProgessly
{
    public partial class GestionarProyectos : Form
    {
        private ProjectService _projectService = new ProjectService();
        private ProgesslyContext _context;
        public GestionarProyectos()
        {
            InitializeComponent();
            LoadProjectFromDb();
        }

        private void LoadProjectFromDb()
        {
            var project = _projectService.GetAllProjectsFromDb();
            dataGridView1.DataSource = project;

            dataGridView1.Columns["Responsable"].Visible = false;

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
            var nuevo = new ProjectModel
            {
                Name = txtNameProject.Text,
                Description = txtDescription.Text,
                StartDate = dateTimeStarDate.Value,
                EndDate = dateTimeEndDate.Value,
                idResponsable = int.Parse(textIdResponsable.Text),
                Status = (StatusProject)Enum.Parse(typeof(StatusProject), StatusBox.SelectedItem.ToString())
            };
            
            try
            {
                _projectService.AddProject(nuevo);
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al crear un proyecto: {ex.Message}");
            }
          

            MessageBox.Show("Proyecto Creado Exitosamente!");

            LoadProjectFromDb();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {

                var project = (ProjectModel)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                txtNameProject.Text = project.Name;
                txtDescription.Text = project.Description;
                textIdResponsable.Text = project.idResponsable.ToString();
                dateTimeStarDate.Value = project.StartDate;
                dateTimeEndDate.Value = project.EndDate;
                StatusBox.SelectedItem = project.Status.ToString();

                LoadProjectFromDb();
            }
            dataGridView1.ClearSelection();
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeStarDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var project = (ProjectModel)dataGridView1.CurrentRow.DataBoundItem;

            project.Name = txtNameProject.Text;
            project.Description = txtDescription.Text;
            project.StartDate = dateTimeStarDate.Value;
            project.EndDate = dateTimeEndDate.Value;
            project.idResponsable = int.Parse(textIdResponsable.Text);

            project.Status = (StatusProject)Enum.Parse(typeof(StatusProject), StatusBox.SelectedItem.ToString());

            try
            {
                _projectService.UpdateProject(project);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el proyecto: {ex.Message}");
            }
           

            MessageBox.Show("Proyecto actualizado exitosamente!");

            LoadProjectFromDb();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {

                var project = (ProjectModel)dataGridView1.CurrentRow.DataBoundItem;


                var confirm = MessageBox.Show("¿Estas seguro de que deseas eliminar este proyecto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _projectService.DeleteProject(project.Id);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el proyecto: {ex.Message}");
                    }
                    LoadProjectFromDb();

                }
            }
            else
            {
                MessageBox.Show("Selecciona un projecto para eliminar.");
            }
        }

       
    }
}
