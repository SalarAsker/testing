using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProviderEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int one = 0;
            int two = 0;
            int mul = 0;
            errTbxNumber1.Clear();
            errTbxNumber2.Clear();
            errTbxMultlip.Clear();

            bool ok1 = int.TryParse(tbxNumber1.Text, out one);
            bool ok2 = int.TryParse(tbxNumber2.Text, out two);
            bool ok3 = int.TryParse(tbxMultlip.Text, out mul);

            if (!ok1)
            {
                errTbxNumber1.SetError(tbxNumber1,"Insert only integer");
            }
            if (!ok2)
            {
                errTbxNumber2.SetError(tbxNumber2, "Insert only integer");
            }
            if (!ok3)
            {
                errTbxMultlip.SetError(tbxMultlip, "Insert only integer");
            }

            if (ok1 && ok2 && ok3)
            {
                label4.Text = ((one + two) * mul).ToString();
            }
        }
    }
}
