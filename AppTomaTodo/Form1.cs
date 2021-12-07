using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTomaTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GirarA(int n)
        {
            
        }
        int vueltas = 0;
        int actual = 0;
        int cara = 0;
        string[] caras = new string[] { "TOMA\nTODO", "PON\n1", "TOMA\n2", "TODOS\nPONEN", "TOMA\n1", "PON\n2" };
        private void tmrGiro_Tick(object sender, EventArgs e)
        {
            if (vueltas == 3)
            {
                tmrGiro.Interval += 200;
            }

            actual = ++actual % 6;
            lblPirinola.Text = caras[actual];

            if (cara == actual)
            {
                if (vueltas == 3)
                {
                    tmrGiro.Stop();
                    tmrGiro.Interval = 200;
                    vueltas = 0;
                    vueltas++;
                }
                else
                {
                    vueltas++;
                }
            }
        }

        private void lblPirinola_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            cara = random.Next(6);
            tmrGiro.Start();
        }
    }
}
