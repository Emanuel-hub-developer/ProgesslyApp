namespace WinFormsProgessly
{
    partial class FormViewModelAvances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewModelAvances));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            buttnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(223, 47);
            label1.Name = "label1";
            label1.Size = new Size(848, 47);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO/A  A LOS AVANCES DE TUS PROYECTOS";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1143, 412);
            dataGridView1.TabIndex = 1;
            // 
            // buttnVolver
            // 
            buttnVolver.BackColor = Color.Lavender;
            buttnVolver.Location = new Point(543, 543);
            buttnVolver.Name = "buttnVolver";
            buttnVolver.Size = new Size(143, 40);
            buttnVolver.TabIndex = 14;
            buttnVolver.Text = "Volver";
            buttnVolver.UseVisualStyleBackColor = false;
            buttnVolver.Click += buttnVolver_Click;
            // 
            // FormViewModelAvances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1315, 639);
            Controls.Add(buttnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormViewModelAvances";
            Text = "Avances";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button buttnVolver;
    }
}