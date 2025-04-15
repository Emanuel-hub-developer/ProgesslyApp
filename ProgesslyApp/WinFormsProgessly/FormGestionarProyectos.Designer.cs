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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNameProject = new TextBox();
            txtDescription = new TextBox();
            txtInitialDate = new TextBox();
            txtEndDate = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(773, 50);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO/A  A TU GESTOR DE PROYECTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 106);
            label2.Name = "label2";
            label2.Size = new Size(250, 30);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE DEL PROYECTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 106);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 2;
            label3.Text = "DESCRIPCION";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(706, 106);
            label4.Name = "label4";
            label4.Size = new Size(177, 30);
            label4.TabIndex = 3;
            label4.Text = "FECHA DE INICIO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(966, 106);
            label5.Name = "label5";
            label5.Size = new Size(253, 30);
            label5.TabIndex = 4;
            label5.Text = "FECHA DE FINALIZACION";
            label5.Click += label5_Click;
            // 
            // txtNameProject
            // 
            txtNameProject.Location = new Point(78, 139);
            txtNameProject.Name = "txtNameProject";
            txtNameProject.Size = new Size(250, 23);
            txtNameProject.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(389, 139);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 23);
            txtDescription.TabIndex = 6;
            // 
            // txtInitialDate
            // 
            txtInitialDate.Location = new Point(672, 139);
            txtInitialDate.Name = "txtInitialDate";
            txtInitialDate.Size = new Size(250, 23);
            txtInitialDate.TabIndex = 7;
            // 
            // txtEndDate
            // 
            txtEndDate.Location = new Point(969, 139);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(250, 23);
            txtEndDate.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(151, 210);
            button1.Name = "button1";
            button1.Size = new Size(250, 35);
            button1.TabIndex = 9;
            button1.Text = "Crear Proyecto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(519, 210);
            button2.Name = "button2";
            button2.Size = new Size(250, 35);
            button2.TabIndex = 10;
            button2.Text = "Actualizar Proyecto";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(867, 210);
            button3.Name = "button3";
            button3.Size = new Size(250, 35);
            button3.TabIndex = 11;
            button3.Text = "Eliminar Proyecto";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1091, 285);
            dataGridView1.TabIndex = 12;
            // 
            // GestionarProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1336, 665);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEndDate);
            Controls.Add(txtInitialDate);
            Controls.Add(txtDescription);
            Controls.Add(txtNameProject);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GestionarProyectos";
            Text = "GestionarProyectos";
            Load += FormGestionarProyectos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtInitialDate;
        private TextBox txtEndDate;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}