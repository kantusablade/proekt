namespace plakplakproekt
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Formula = new Label();
            PodrobnoTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 51);
            label1.TabIndex = 0;
            label1.Text = "Решение :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(1297, 188);
            label2.TabIndex = 1;
            label2.Text = "Для вычисления расстояния от точки M(Mx; My; Mz) до плоскости Ax + By + Cz + D = 0\r\nиспользуем формулу:   d = |A·Mx + B·My + C·Mz + D| \r\n/\r\n√A2 + B2 + C2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 0);
            label3.Location = new Point(85, 67);
            label3.Name = "label3";
            label3.Size = new Size(149, 43);
            label3.TabIndex = 2;
            label3.Text = "Формула :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(12, 390);
            label4.Name = "label4";
            label4.Size = new Size(549, 56);
            label4.TabIndex = 3;
            label4.Text = "Подставим в формулу данные:";
            label4.Click += label4_Click;
            // 
            // Formula
            // 
            Formula.AutoSize = true;
            Formula.BackColor = Color.Transparent;
            Formula.Font = new Font("Segoe Print", 72F, FontStyle.Bold, GraphicsUnit.Point);
            Formula.Location = new Point(42, 498);
            Formula.Name = "Formula";
            Formula.Size = new Size(195, 170);
            Formula.TabIndex = 4;
            Formula.Text = "d=";
            // 
            // PodrobnoTextBox
            // 
            PodrobnoTextBox.BackColor = SystemColors.MenuBar;
            PodrobnoTextBox.Font = new Font("Segoe Print", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            PodrobnoTextBox.Location = new Point(243, 446);
            PodrobnoTextBox.MaxLength = 130;
            PodrobnoTextBox.Multiline = true;
            PodrobnoTextBox.Name = "PodrobnoTextBox";
            PodrobnoTextBox.Size = new Size(794, 260);
            PodrobnoTextBox.TabIndex = 5;
            PodrobnoTextBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe Print", 48F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(706, 808);
            button1.Name = "button1";
            button1.Size = new Size(603, 134);
            button1.TabIndex = 6;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1041);
            Controls.Add(button1);
            Controls.Add(PodrobnoTextBox);
            Controls.Add(Formula);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Formula;
        private TextBox PodrobnoTextBox;
        private Button button1;
    }
}