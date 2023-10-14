using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudk
{
    public partial class Form1 : Form
    {
        Random nr = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = nr.Next(15);
            int n2 = nr.Next(15);
            int n3 = nr.Next(15);
            int n4 = nr.Next(15);
            int n5 = nr.Next(15);
            int n6 = nr.Next(15);
            int n7 = nr.Next(15);
            int n8 = nr.Next(15);
            int n9 = nr.Next(15);

            int r1 = (n1 * n2) + n3;
            int r2 = n4 + (n5 * n6);
            int r3 = (n7 - n8 + n9);
            int r4 = n1 + n4 - n7;
            int r5 = n2 * n5 + n8;
            int r6 = n3 + (n6 * n9);

            R1.Text = r1.ToString();
            R2.Text = r2.ToString();
            R3.Text = r3.ToString();
            R4.Text = r4.ToString();
            R5.Text = r5.ToString();
            R6.Text = r6.ToString();
            Nl5.Text = n5.ToString();
            Nl9.Text = n9.ToString();
            label18.Text = n1.ToString();
            label19.Text = n2.ToString();
            label20.Text = n3.ToString();
            label21.Text = n4.ToString();
            label22.Text = n5.ToString();
            label23.Text = n6.ToString();
            label24.Text = n7.ToString();
            label25.Text = n8.ToString();
            label26.Text = n9.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string n1 = txt1.Text;
            int N1 = int.Parse(n1);
            string n2 = txt2.Text;
            int N2 = int.Parse(n2);
            string n3 = txt3.Text;
            int N3 = int.Parse(n3);
            string n4 = txt4.Text;
            int N4 = int.Parse(n4);
            string n5 = Nl5.Text;
            int N5 = int.Parse(n5);
            string n6 = txt6.Text;
            int N6 = int.Parse(n6);
            string n7 = txt7.Text;
            int N7 = int.Parse(n7);
            string n8 = txt8.Text;
            int N8 = int.Parse(n8);
            string n9 = Nl9.Text;
            int N9 = int.Parse(n9);

            string r1 = R1.Text;
            int Rr1 = int.Parse(r1);
            string r2 = R2.Text;
            int Rr2 = int.Parse(r2);
            string r3 = R3.Text;
            int Rr3 = int.Parse(r3);
            string r4 = R4.Text;
            int Rr4 = int.Parse(r4);
            string r5 = R5.Text;
            int Rr5 = int.Parse(r5);
            string r6 = R6.Text;
            int Rr6 = int.Parse(r6);

            

            if (Rr1 == (N1 * N2) + N3 && Rr2 == N4 + (N5 * N6) && Rr3 == (N7 - N8 + N9) && Rr4 == N1 + N4 - N7 && Rr5 == N2 * N5 + N8 && Rr6 == N3 + (N6 * N9))
            {
                MessageBox.Show("El resultado es correcto");
            }
            else
            {
                MessageBox.Show("El resultado es incorrecto");
            }
        }
    }
}
