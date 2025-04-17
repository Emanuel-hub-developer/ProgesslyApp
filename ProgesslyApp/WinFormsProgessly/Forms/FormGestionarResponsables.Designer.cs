namespace WinFormsProgessly
{
    partial class FormGestionarResponsables
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarResponsables));
            buttonVolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtName = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Lavender;
            buttonVolver.Location = new Point(1026, 474);
            buttonVolver.Margin = new Padding(4);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(190, 39);
            buttonVolver.TabIndex = 0;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(295, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(681, 45);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO/A AL GESTOR DE RESPONSABLES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(146, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 2;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(371, 128);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 3;
            label3.Text = "APELLIDO";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(583, 128);
            label4.Name = "label4";
            label4.Size = new Size(80, 32);
            label4.TabIndex = 4;
            label4.Text = "EMAIL";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(788, 128);
            label6.Name = "label6";
            label6.Size = new Size(128, 32);
            label6.TabIndex = 6;
            label6.Text = "TELEFONO";
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 29);
            txtName.TabIndex = 7;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(350, 178);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(159, 29);
            txtLastname.TabIndex = 8;
            txtLastname.TextChanged += textBox2_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(542, 178);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 29);
            txtEmail.TabIndex = 9;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(146, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(792, 342);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(1022, 261);
            button1.Name = "button1";
            button1.Size = new Size(194, 38);
            button1.TabIndex = 13;
            button1.Text = "Crear ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(1018, 330);
            button2.Name = "button2";
            button2.Size = new Size(194, 37);
            button2.TabIndex = 14;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(1022, 395);
            button3.Name = "button3";
            button3.Size = new Size(194, 41);
            button3.TabIndex = 15;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(767, 178);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(160, 29);
            maskedTextBox1.TabIndex = 16;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // FormGestionarResponsables
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1698, 931);
            Controls.Add(maskedTextBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtEmail);
            Controls.Add(txtLastname);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonVolver);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormGestionarResponsables";
            Text = "Gestionar Responsables";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtName;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private ErrorProvider errorProvider1;
        private MaskedTextBox maskedTextBox1;
    }
}