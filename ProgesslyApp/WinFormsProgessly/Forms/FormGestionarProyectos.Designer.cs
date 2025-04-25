namespace WinFormsProgessly
{
    partial class GestionarProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarProyectos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNameProject = new TextBox();
            txtDescription = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            buttnVolver = new Button();
            label6 = new Label();
            StatusBox = new ComboBox();
            label7 = new Label();
            textIdResponsable = new TextBox();
            dateTimeStarDate = new DateTimePicker();
            dateTimeEndDate = new DateTimePicker();
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
            label1.Location = new Point(361, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1161, 74);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO/A  A TU GESTOR DE PROYECTOS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 177);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(375, 45);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE DEL PROYECTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(483, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(218, 45);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPCION";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(803, 177);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 45);
            label4.TabIndex = 3;
            label4.Text = "FECHA DE INICIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1078, 177);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(329, 38);
            label5.TabIndex = 4;
            label5.Text = "FECHA DE FINALIZACION";
            label5.Click += label5_Click;
            // 
            // txtNameProject
            // 
            txtNameProject.Location = new Point(67, 232);
            txtNameProject.Margin = new Padding(4, 5, 4, 5);
            txtNameProject.Name = "txtNameProject";
            txtNameProject.Size = new Size(277, 31);
            txtNameProject.TabIndex = 5;
            txtNameProject.TextChanged += txtNameProject_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(400, 235);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(355, 31);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(1510, 360);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(277, 63);
            button1.TabIndex = 9;
            button1.Text = "Crear ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 128);
            button2.Location = new Point(1510, 463);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(277, 62);
            button2.TabIndex = 10;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(1510, 567);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(277, 68);
            button3.TabIndex = 11;
            button3.Text = "Eliminar ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(304, 335);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1059, 607);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // buttnVolver
            // 
            buttnVolver.BackColor = Color.Lavender;
            buttnVolver.Location = new Point(1510, 682);
            buttnVolver.Margin = new Padding(4, 5, 4, 5);
            buttnVolver.Name = "buttnVolver";
            buttnVolver.Size = new Size(277, 68);
            buttnVolver.TabIndex = 13;
            buttnVolver.Text = "Volver";
            buttnVolver.UseVisualStyleBackColor = false;
            buttnVolver.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(1716, 180);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 48);
            label6.TabIndex = 27;
            label6.Text = "ESTADO";
            // 
            // StatusBox
            // 
            StatusBox.FormattingEnabled = true;
            StatusBox.Items.AddRange(new object[] { "Pendiente", "EnProgreso", "Finalizado" });
            StatusBox.Location = new Point(1701, 235);
            StatusBox.Margin = new Padding(4, 5, 4, 5);
            StatusBox.Name = "StatusBox";
            StatusBox.Size = new Size(171, 33);
            StatusBox.TabIndex = 28;
            StatusBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(1424, 180);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(265, 45);
            label7.TabIndex = 29;
            label7.Text = "ID RESPONSABLE";
            label7.Click += label7_Click;
            // 
            // textIdResponsable
            // 
            textIdResponsable.Location = new Point(1456, 232);
            textIdResponsable.Margin = new Padding(4, 5, 4, 5);
            textIdResponsable.Name = "textIdResponsable";
            textIdResponsable.Size = new Size(194, 31);
            textIdResponsable.TabIndex = 30;
            textIdResponsable.TextChanged += textIdResponsable_TextChanged;
            // 
            // dateTimeStarDate
            // 
            dateTimeStarDate.Location = new Point(803, 232);
            dateTimeStarDate.Margin = new Padding(4, 5, 4, 5);
            dateTimeStarDate.Name = "dateTimeStarDate";
            dateTimeStarDate.Size = new Size(258, 31);
            dateTimeStarDate.TabIndex = 38;
            dateTimeStarDate.ValueChanged += dateTimeStarDate_ValueChanged;
            // 
            // dateTimeEndDate
            // 
            dateTimeEndDate.Location = new Point(1123, 230);
            dateTimeEndDate.Margin = new Padding(4, 5, 4, 5);
            dateTimeEndDate.Name = "dateTimeEndDate";
            dateTimeEndDate.Size = new Size(258, 31);
            dateTimeEndDate.TabIndex = 39;
            // 
            // GestionarProyectos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1909, 1108);
            Controls.Add(dateTimeEndDate);
            Controls.Add(dateTimeStarDate);
            Controls.Add(textIdResponsable);
            Controls.Add(label7);
            Controls.Add(StatusBox);
            Controls.Add(label6);
            Controls.Add(buttnVolver);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDescription);
            Controls.Add(txtNameProject);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarProyectos";
            Text = "GestionarProyectos";
            Load += FormGestionarProyectos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNameProject;
        private TextBox txtDescription;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private Button buttnVolver;
        private Label label6;
        private ComboBox StatusBox;
        private Label label7;
        private TextBox textIdResponsable;
        private DateTimePicker dateTimeEndDate;
        private DateTimePicker dateTimeStarDate;
    }
}