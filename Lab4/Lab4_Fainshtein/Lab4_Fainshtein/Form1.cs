using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_Fainshtein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Обновить";
            label3.Text = "Имена классов фигур";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Треугольник
            Triangle triangle = new Triangle(20, 20, 225, 66, 80, 185);
            triangle.Draw(e);
            triangle.Show(label1);
            listBox1.Items.Add(triangle.GetClassName());

            // Прямоугольник
            Rectangle rectangle = new Rectangle(160, 160, 40, 50);
            rectangle.Draw(e);
            rectangle.Show(label2);
            listBox1.Items.Add(rectangle.GetClassName());

            // Сравнение площадей через оператор
            bool comparison = triangle >= rectangle;
            if (comparison)
            {
                label4.Text = "Площадь треугольника больше,\nчем прямоугольника";
            } else if (!comparison)
            {
                label4.Text = "Площадь прямоугольника больше,\nчем треугольника";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            pictureBox1.Refresh();
        }
    }
}
