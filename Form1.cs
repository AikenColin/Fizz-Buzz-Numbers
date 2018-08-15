using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fizz_Buzz_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int y = 0;
            int z = 0;
            string A = "Fizz";
            string B = "Buzz";

            for (var i = 1; i < 101; i++)
            {
                y = i % 3;
                z = i % 5;

                if(y==0 && z==0)
                {listBox1.Items.Add(A + B);}
                if (y == 0 && z != 0)
                {listBox1.Items.Add(A);}
                if (y != 0 && z == 0)
                {listBox1.Items.Add(B);}
                if (y != 0 && z != 0)
                {listBox1.Items.Add(i);}
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
