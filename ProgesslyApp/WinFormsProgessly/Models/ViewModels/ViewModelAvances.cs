using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProgessly
{
    public partial class ViewModelAvances : Form
    {
        public ViewModelAvances()
        {
            InitializeComponent();
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
    }
}
