namespace plakplakproekt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CalculateDistanceButton = new Button();
            XTextBox = new TextBox();
            YTextBox = new TextBox();
            ZTextBox = new TextBox();
            BTextBox = new TextBox();
            CTextBox = new TextBox();
            resultTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            DTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            PodrobnoButton = new Button();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            label2 = new Label();
            ATextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(512, 330);
            label1.Name = "label1";
            label1.Size = new Size(1147, 85);
            label1.TabIndex = 0;
            label1.Text = "Найти расстояние от точки до плоскости";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(816, 540);
            label3.Name = "label3";
            label3.Size = new Size(65, 56);
            label3.TabIndex = 2;
            label3.Text = "X+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1096, 540);
            label4.Name = "label4";
            label4.Size = new Size(63, 56);
            label4.TabIndex = 3;
            label4.Text = "Y+";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1384, 540);
            label5.Name = "label5";
            label5.Size = new Size(67, 56);
            label5.TabIndex = 4;
            label5.Text = "Z+";
            // 
            // CalculateDistanceButton
            // 
            CalculateDistanceButton.BackColor = Color.FromArgb(0, 192, 0);
            CalculateDistanceButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CalculateDistanceButton.Location = new Point(493, 749);
            CalculateDistanceButton.Name = "CalculateDistanceButton";
            CalculateDistanceButton.Size = new Size(434, 75);
            CalculateDistanceButton.TabIndex = 8;
            CalculateDistanceButton.Text = "Рассчитать расстояние";
            CalculateDistanceButton.UseVisualStyleBackColor = false;
            CalculateDistanceButton.Click += CalculateDistanceButton_Click;
            // 
            // XTextBox
            // 
            XTextBox.BackColor = SystemColors.HighlightText;
            XTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            XTextBox.Location = new Point(611, 546);
            XTextBox.MaxLength = 5;
            XTextBox.Multiline = true;
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(199, 50);
            XTextBox.TabIndex = 9;
            XTextBox.TextChanged += XTextBox_TextChanged;
            // 
            // YTextBox
            // 
            YTextBox.BackColor = SystemColors.HighlightText;
            YTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            YTextBox.Location = new Point(887, 546);
            YTextBox.MaxLength = 5;
            YTextBox.Multiline = true;
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(203, 50);
            YTextBox.TabIndex = 10;
            YTextBox.TextChanged += textBox2_TextChanged;
            // 
            // ZTextBox
            // 
            ZTextBox.BackColor = SystemColors.HighlightText;
            ZTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ZTextBox.Location = new Point(1165, 540);
            ZTextBox.MaxLength = 5;
            ZTextBox.Multiline = true;
            ZTextBox.Name = "ZTextBox";
            ZTextBox.Size = new Size(213, 56);
            ZTextBox.TabIndex = 11;
            ZTextBox.TextChanged += ZTextBox_TextChanged;
            // 
            // BTextBox
            // 
            BTextBox.BackColor = SystemColors.HighlightText;
            BTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTextBox.Location = new Point(806, 667);
            BTextBox.MaxLength = 5;
            BTextBox.Multiline = true;
            BTextBox.Name = "BTextBox";
            BTextBox.Size = new Size(181, 57);
            BTextBox.TabIndex = 13;
            BTextBox.TextChanged += BTextBox_TextChanged;
            // 
            // CTextBox
            // 
            CTextBox.BackColor = SystemColors.HighlightText;
            CTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            CTextBox.Location = new Point(1064, 672);
            CTextBox.MaxLength = 5;
            CTextBox.Multiline = true;
            CTextBox.Name = "CTextBox";
            CTextBox.Size = new Size(168, 57);
            CTextBox.TabIndex = 5;
            CTextBox.TextChanged += CTextBox_TextChanged;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.Red;
            resultTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.Location = new Point(1214, 791);
            resultTextBox.MaxLength = 8;
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(173, 56);
            resultTextBox.TabIndex = 5;
            resultTextBox.TextChanged += resultTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1457, 540);
            label9.Name = "label9";
            label9.Size = new Size(67, 56);
            label9.TabIndex = 17;
            label9.Text = "=0";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(1045, 799);
            label10.Name = "label10";
            label10.Size = new Size(144, 48);
            label10.TabIndex = 18;
            label10.Text = "Ответ:";
            // 
            // DTextBox
            // 
            DTextBox.BackColor = SystemColors.HighlightText;
            DTextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DTextBox.Location = new Point(1301, 673);
            DTextBox.MaxLength = 5;
            DTextBox.Multiline = true;
            DTextBox.Name = "DTextBox";
            DTextBox.Size = new Size(168, 57);
            DTextBox.TabIndex = 19;
            DTextBox.TextChanged += DTextBox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 876);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += WordButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(735, 670);
            label11.Name = "label11";
            label11.Size = new Size(75, 56);
            label11.TabIndex = 22;
            label11.Text = "А ,";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(986, 674);
            label12.Name = "label12";
            label12.Size = new Size(72, 56);
            label12.TabIndex = 23;
            label12.Text = "B ,";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(1225, 674);
            label13.Name = "label13";
            label13.Size = new Size(70, 56);
            label13.TabIndex = 24;
            label13.Text = "C ,";
            label13.Click += label13_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe Print", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(1475, 673);
            label14.Name = "label14";
            label14.Size = new Size(49, 56);
            label14.TabIndex = 25;
            label14.Text = "D";
            // 
            // PodrobnoButton
            // 
            PodrobnoButton.BackColor = Color.Yellow;
            PodrobnoButton.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PodrobnoButton.Location = new Point(792, 886);
            PodrobnoButton.Name = "PodrobnoButton";
            PodrobnoButton.Size = new Size(585, 103);
            PodrobnoButton.TabIndex = 28;
            PodrobnoButton.Text = "Посмотреть более подробное решение...";
            PodrobnoButton.UseVisualStyleBackColor = false;
            PodrobnoButton.Click += PodrobnoButton_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(193, 876);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(113, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            pictureBox5.Click += button2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(636, 876);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 113);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            pictureBox3.Click += ImportToWord_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(493, 876);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(126, 113);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            pictureBox4.Click += ExportToExcel_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(535, 831);
            label15.Name = "label15";
            label15.Size = new Size(165, 47);
            label15.TabIndex = 33;
            label15.Text = "ЭКСПОРТ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(230, 821);
            label16.Name = "label16";
            label16.Size = new Size(184, 57);
            label16.TabIndex = 34;
            label16.Text = "ИМПОРТ";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(933, 749);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(91, 75);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 38;
            pictureBox6.TabStop = false;
            pictureBox6.Click += InfoButton_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1403, 470);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(492, 489);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 39;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(259, 549);
            label6.Name = "label6";
            label6.Size = new Size(332, 47);
            label6.TabIndex = 41;
            label6.Text = "Уравнение плоскости:";
            label6.Click += label6_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(179, 676);
            label2.Name = "label2";
            label2.Size = new Size(372, 47);
            label2.TabIndex = 42;
            label2.Text = "Координаты плоскости:";
            // 
            // ATextBox
            // 
            ATextBox.BackColor = SystemColors.HighlightText;
            ATextBox.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            ATextBox.Location = new Point(557, 667);
            ATextBox.MaxLength = 5;
            ATextBox.Multiline = true;
            ATextBox.Name = "ATextBox";
            ATextBox.Size = new Size(181, 57);
            ATextBox.TabIndex = 43;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1001);
            Controls.Add(ATextBox);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(pictureBox6);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(PodrobnoButton);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pictureBox1);
            Controls.Add(DTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(resultTextBox);
            Controls.Add(CTextBox);
            Controls.Add(BTextBox);
            Controls.Add(ZTextBox);
            Controls.Add(YTextBox);
            Controls.Add(XTextBox);
            Controls.Add(CalculateDistanceButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox7);
            Name = "Form1";
            Text = "Основная панель";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CalculateDistanceButton;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox ZTextBox;
        private TextBox BTextBox;
        private TextBox CTextBox;
        private TextBox resultTextBox;
        private Label label9;
        private Label label10;
        private TextBox DTextBox;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button PodrobnoButton;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label15;
        private Label label16;
        private Button InfoButton;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label label6;
        private TextBox ATextBox;
    }
}