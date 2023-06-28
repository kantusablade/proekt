using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace plakplakproekt
{
    public partial class Form2 : Form
    {
        private string detailedSolution; // Добавьте поле для хранения подробного решения

        public Form2()
        {
            InitializeComponent();
        }

        public string GetDetailedSolution()
        {
            return detailedSolution;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            detailedSolution = PodrobnoTextBox.Text; // Сохраните подробное решение при нажатии кнопки "ОК"
            this.Close(); // Закройте форму Form2
        }


        private double a;
        private double b;
        private double c;
        private double d;

        public string DistanceFormula { get; set; }
        public string ResultText { get; set; }

        public Form2(double x, double y, double z, double distance, double a, double b, double c, double d)
        {
            InitializeComponent();
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            string detailedSolution = $"Расстояние от точки ({x}, {y}, {z}) до плоскости {a}x + {b}y + {c}z + {d} = 0 равно {distance}.";
            PodrobnoTextBox.Text = detailedSolution;
            DataBase.firstStep1 = detailedSolution;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
     
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PodrobnoTextBox.ReadOnly = true;
            PodrobnoTextBox.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        public string XValue {  get; private set; }
        public string YValue { get; private set; }
        public string ZValue { get; private set; }
        public string AValue { get; private set; }
        public string BValue { get; private set; }
        public string CValue { get; private set; }
        public string DValue { get; private set; }
    

    }
}