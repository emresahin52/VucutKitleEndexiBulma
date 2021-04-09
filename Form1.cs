using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekCift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, hesapla;
            boy = Convert.ToDouble(txtboy.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            hesapla = kilo / boy * boy;
            if (hesapla<18.50)
            {
                Console.WriteLine("Aferin lan güzel kilo böyle devamm" );

            }
            else if (hesapla>=18.50 && hesapla<=24.99)
            {
                Console.WriteLine("Aferin lan güzel kilo böyle devamm");
            }
            else if (hesapla >= 25 && hesapla <= 29.99)
            {
                Console.WriteLine("Olum azcık Sıç la bu nasıl kilo" );
            }
            else 
            {
                Console.WriteLine("Reis ölmüşsün haberin olsun ha" );
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
