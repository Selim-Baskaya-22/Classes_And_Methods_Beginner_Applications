using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top=0, left=0; 
            Button[,] buttonlar = new Button[8, 8];
            for (int i = 0; i <= buttonlar.GetUpperBound(0); i++)
            {
                for (int j = 0; j <=buttonlar.GetUpperBound(1) ; j++)
                {
                    Button b = new Button();
                    b.Width = 50;
                    b.Height = 50;
                    b.Top = top;
                    b.Left =left;
                    top += 50;
                    if ((i+j)%2==0)
                    {
                        b.BackColor = Color.Black;
                    }
                    else
                    {
                      b.BackColor = Color.White;
                    }
                    this.Controls.Add(b);
                }
                left += 50;
                top = 0;
            }     
        }
    }
}
