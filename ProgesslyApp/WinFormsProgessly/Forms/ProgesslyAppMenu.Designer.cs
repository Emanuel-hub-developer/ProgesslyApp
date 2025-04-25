namespace WinFormsProgessly
{
    partial class ProgesslyAppMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgesslyAppMenu));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-108, -73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1474, 738);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(142, 140);
            button1.Name = "button1";
            button1.Size = new Size(281, 50);
            button1.TabIndex = 1;
            button1.Text = "Gestionar Proyectos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(142, 216);
            button2.Name = "button2";
            button2.Size = new Size(281, 43);
            button2.TabIndex = 2;
            button2.Text = "Gestionar Tareas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(142, 277);
            button3.Name = "button3";
            button3.Size = new Size(281, 57);
            button3.TabIndex = 3;
            button3.Text = "Gestionar Responsables";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(142, 419);
            button4.Name = "button4";
            button4.Size = new Size(281, 46);
            button4.TabIndex = 4;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 84);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 5;
            label1.Text = "Menú";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(1185, 573);
            label2.Name = "label2";
            label2.Size = new Size(128, 47);
            label2.TabIndex = 6;
            label2.Text = "DEMO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(258, 0);
            label3.Name = "label3";
            label3.Size = new Size(853, 65);
            label3.TabIndex = 7;
            label3.Text = "SISTEMA DE GESTIÓN DE PROYECTOS";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Algerian", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(142, 351);
            button5.Name = "button5";
            button5.Size = new Size(281, 46);
            button5.TabIndex = 8;
            button5.Text = "Avances ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ProgesslyAppMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 629);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgesslyAppMenu";
            Text = "ProgresslyApp";
            Load += ProgesslyAppMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button5;
    }
}
