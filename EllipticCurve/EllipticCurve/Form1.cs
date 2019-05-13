using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipticCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ScopeCalculating sc = new ScopeCalculating();
        X2Calculating x2 = new X2Calculating();
        Y2Calculating y2 = new Y2Calculating();

        private void Button1_Click(object sender, EventArgs e)
        {
            int valueX = Convert.ToInt32(textBox1.Text);
            int valueY = Convert.ToInt32(textBox2.Text);
            int Mod = Convert.ToInt32(textBox3.Text);


            double Scope=  sc.CalculateScope(valueX, valueY, Mod);
            label6.Text = Scope.ToString();
            int sScope= Convert.ToInt32(Scope);
            int x2x = x2.X2Value(sScope, valueX,Mod);
            label7.Text = x2x.ToString();

            int y2y = y2.CalculateY2(sScope, valueX, x2x, valueY,Mod);
            label8.Text = y2y.ToString();


        }

    }
}
