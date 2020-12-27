using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayi = { 2, 85, 7, 36, 45, 86, 45, 72, 7, 6, 82, 75, 85 };
            for(int i = 0; i < sayi.Length; i++)
            {
                if (sayi[i] % 2 == 0 && sayi[i] > 10)
                {
                    listBox1.Items.Add(sayi[i]);

                }
            }
        }
    }
}
