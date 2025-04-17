namespace WinFormsProgessly
{
    partial class FormGestionarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionarTareas));
            label1 = new Label();
            btonVolver = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNameBox = new TextBox();
            txtDescriptionBox = new TextBox();
            txtIdProyectoBox = new TextBox();
            txtIdResponsableBox = new TextBox();
            label6 = new Label();
            StatusBox = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            label8 = new Label();
            dateTimeStarDate = new DateTimePicker();
            dateTimeDeliveryDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(303, 28);
            label1.Name = "label1";
            label1.Size = new Size(664, 50);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO/A  AL GESTOR DE TAREAS";
            // 
            // btonVolver
            // 
            btonVolver.BackColor = Color.Lavender;
            btonVolver.Location = new Point(1088, 413);
            btonVolver.Name = "btonVolver";
            btonVolver.Size = new Size(148, 46);
            btonVolver.TabIndex = 1;
            btonVolver.Text = "Volver";
            btonVolver.UseVisualStyleBackColor = false;
            btonVolver.Click += btonVolver_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(1060, 221);
            button1.Name = "button1";
            button1.Size = new Size(194, 38);
            button1.TabIndex = 14;
            button1.Text = "Crear ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(1060, 281);
            button2.Name = "button2";
            button2.Size = new Size(194, 37);
            button2.TabIndex = 15;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(1060, 345);
            button3.Name = "button3";
            button3.Size = new Size(194, 44);
            button3.TabIndex = 16;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(175, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 350);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 107);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 18;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(255, 107);
            label3.Name = "label3";
            label3.Size = new Size(161, 32);
            label3.TabIndex = 19;
            label3.Text = "DESCRIPCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(457, 107);
            label4.Name = "label4";
            label4.Size = new Size(158, 32);
            label4.TabIndex = 20;
            label4.Text = "ID PROYECTO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1020, 109);
            label5.Name = "label5";
            label5.Size = new Size(177, 30);
            label5.TabIndex = 21;
            label5.Text = "ID RESPONSABLE";
            label5.Click += label5_Click;
            // 
            // txtNameBox
            // 
            txtNameBox.Location = new Point(40, 142);
            txtNameBox.Name = "txtNameBox";
            txtNameBox.Size = new Size(169, 23);
            txtNameBox.TabIndex = 22;
            txtNameBox.TextChanged += textBox1_TextChanged;
            // 
            // txtDescriptionBox
            // 
            txtDescriptionBox.Location = new Point(255, 142);
            txtDescriptionBox.Name = "txtDescriptionBox";
            txtDescriptionBox.Size = new Size(169, 23);
            txtDescriptionBox.TabIndex = 23;
            txtDescriptionBox.TextChanged += textDescriptionBox_TextChanged;
            // 
            // txtIdProyectoBox
            // 
            txtIdProyectoBox.Location = new Point(479, 142);
            txtIdProyectoBox.Name = "txtIdProyectoBox";
            txtIdProyectoBox.Size = new Size(120, 23);
            txtIdProyectoBox.TabIndex = 24;
            txtIdProyectoBox.TextChanged += textBox3_TextChanged;
            // 
            // txtIdResponsableBox
            // 
            txtIdResponsableBox.Location = new Point(1046, 144);
            txtIdResponsableBox.Name = "txtIdResponsableBox";
            txtIdResponsableBox.Size = new Size(119, 23);
            txtIdResponsableBox.TabIndex = 25;
            txtIdResponsableBox.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1203, 109);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 26;
            label6.Text = "ESTADO";
            label6.Click += label6_Click;
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "Pendiente", "EnProgreso", "Completada" });
            StatusBox.Location = new Point(1200, 142);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(100, 23);
            StatusBox.TabIndex = 27;
            StatusBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(621, 107);
            label7.Name = "label7";
            label7.Size = new Size(205, 32);
            label7.TabIndex = 28;
            label7.Text = "FECHA CREACION";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(832, 109);
            label8.Name = "label8";
            label8.Size = new Size(182, 32);
            label8.TabIndex = 35;
            label8.Text = "FECHA ENTREG.";
            // 
            // dateTimeStarDate
            // 
            dateTimeStarDate.Location = new Point(630, 144);
            dateTimeStarDate.Name = "dateTimeStarDate";
            dateTimeStarDate.Size = new Size(182, 23);
            dateTimeStarDate.TabIndex = 36;
            // 
            // dateTimeDeliveryDate
            // 
            dateTimeDeliveryDate.Location = new Point(832, 144);
            dateTimeDeliveryDate.Name = "dateTimeDeliveryDate";
            dateTimeDeliveryDate.Size = new Size(182, 23);
            dateTimeDeliveryDate.TabIndex = 37;
            // 
            // FormGestionarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1315, 659);
            Controls.Add(dateTimeDeliveryDate);
            Controls.Add(dateTimeStarDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(StatusBox);
            Controls.Add(label6);
            Controls.Add(txtIdResponsableBox);
            Controls.Add(txtIdProyectoBox);
            Controls.Add(txtDescriptionBox);
            Controls.Add(txtNameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btonVolver);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormGestionarTareas";
            Text = "Gestionar Tareas";
            Load += FormGestionarTareas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btonVolver;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNameBox;
        private TextBox txtDescriptionBox;
        private TextBox txtIdProyectoBox;
        private TextBox txtIdResponsableBox;
        private Label label6;
        private ComboBox StatusBox;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimeStarDate;
        private DateTimePicker dateTimeDeliveryDate;
    }
}