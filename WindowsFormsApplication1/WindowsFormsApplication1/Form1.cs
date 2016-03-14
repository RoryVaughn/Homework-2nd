using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void attack_Click(object sender, EventArgs e)
        {
            List<int> theData = new List<int> { 5, 6, 2, 1, 6, 4, 3, 6, 2, 3, 6, 1, 6, 3, 3, 4, 1 };
            for (int i = 0; i < theData.Count; ++i)
            {
                theData.Sort();
                chart1.Series["Damage"].Points.Add(theData[i]);
                
            }
           
        }

    }


}
