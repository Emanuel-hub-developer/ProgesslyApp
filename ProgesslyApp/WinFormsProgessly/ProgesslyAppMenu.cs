
namespace WinFormsProgessly
{
    public partial class ProgesslyAppMenu : Form
    {
        public ProgesslyAppMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionarProyectos frm = new GestionarProyectos();

            frm.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGestionarTareas frm = new FormGestionarTareas();

            frm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestionarResponsables frm = new FormGestionarResponsables();

            frm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProgesslyAppMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormViewModelAvances frm = new FormViewModelAvances();

            frm.Show();

            this.Hide();
        }
    }
}
