namespace plakplakproekt
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Leelawadee UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(132, 50);
            label1.Name = "label1";
            label1.Size = new Size(749, 65);
            label1.TabIndex = 0;
            label1.Text = "Уважаемый пользователь!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-15, 47);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 149);
            label3.Name = "label3";
            label3.Size = new Size(708, 60);
            label3.TabIndex = 2;
            label3.Text = "Данная программа служит для вычисления расстояния\r\n от плоскости(через уровнение плоскости и точки x,y,z)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(28, 219);
            label4.Name = "label4";
            label4.Size = new Size(1229, 30);
            label4.TabIndex = 3;
            label4.Text = "Для того что пользоваться программой необходимо знать : \"Нужные вам элементы,переменные\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 279);
            label5.Name = "label5";
            label5.Size = new Size(777, 90);
            label5.TabIndex = 4;
            label5.Text = "Программа имеет функции экспорта и импорта в Excel и Word. \r\nДля импорта следует сделать экспорт, \r\nпозже менять данные в самом Excel и Word.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(28, 249);
            label6.Name = "label6";
            label6.Size = new Size(815, 30);
            label6.TabIndex = 5;
            label6.Text = "Максимальное количество элементов в подробном решении: 10.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 382);
            label7.Name = "label7";
            label7.Size = new Size(902, 60);
            label7.TabIndex = 6;
            label7.Text = "Не рекомендуется вводить слишком большие числа,так как это может \r\nвызвать ошибку или сбой программы.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 456);
            label8.Name = "label8";
            label8.Size = new Size(792, 60);
            label8.TabIndex = 7;
            label8.Text = "Так же не рекомендуется вводить символы @,#,$,%,^,&<,*,(,),-,+,_,!\r\n и другие подобные символы,так же нельзя вводить буквы.\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Leelawadee UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(42, 607);
            button1.Name = "button1";
            button1.Size = new Size(822, 96);
            button1.TabIndex = 8;
            button1.Text = "Приступить к работе!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Leelawadee UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 546);
            label9.Name = "label9";
            label9.Size = new Size(634, 30);
            label9.TabIndex = 9;
            label9.Text = "Можно вводить дробные числа такие,как: '3,5' итп.\r\n";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1041);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Label label9;
    }
}