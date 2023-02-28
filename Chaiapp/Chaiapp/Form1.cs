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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chaiapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int quantityTea = 1;

        int tea;
        private void button1_Click(object sender, EventArgs e)
        {
            String name = button1.Text;

            label6.Text = name;


            tea = quantityTea * 10;

            String price1 = tea.ToString();

            textBox1.Text = "10 " + "x " + quantityTea + " = " + tea + " Rs/-";

            quantityTea++;

        }
        int quantityElaichi = 1;

        int elaichi;
        private void button2_Click(object sender, EventArgs e)
        {
            String name1 = button2.Text;

             label2.Text = name1;

            elaichi = quantityElaichi * 15;

            String price2 = elaichi.ToString();

            textBox2.Text = "15 " + "x " + quantityElaichi + " = " + elaichi + " Rs/-";

            quantityElaichi++;

        }
        int quantityChoclate = 1;

        int choclate;
        private void button3_Click(object sender, EventArgs e)
        {
            String name2 = button3.Text;

            label3.Text = name2;

            choclate = quantityChoclate * 20;
            String price3 = choclate.ToString();

            textBox3.Text = "20 " + "x " + quantityChoclate + " = " + choclate + " Rs/-";

            quantityChoclate++;
        }
        int quantityMasala = 1;

        int masala;
        private void button4_Click(object sender, EventArgs e)
        {
            String name3 = button4.Text;

           label4.Text = name3;

            masala = quantityMasala * 18;

            String price4 = masala.ToString();

            textBox4.Text = "18 " + "x " + quantityMasala + " = " + masala + " Rs/-";

            quantityMasala++;

        }
        int total;
        private void button5_Click(object sender, EventArgs e)
        {
           
            total = tea + elaichi + choclate + masala;

            String total1 = total.ToString();

            textBox5.Text = total1 + " Rs/-";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button6_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();

            Size size = this.ClientSize;

            bitmap = new Bitmap(size.Width, size.Height, graphics);

            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);

            graphics.CopyFromScreen(point.X, point.Y, 33, 33, size);

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = " ";
        }

        private void Clear4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();

            textBox2.Text = " ";
        }

        private void Clear2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            textBox2.Text = " ";
        }

        private void Clear3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            textBox3.Text = " ";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
