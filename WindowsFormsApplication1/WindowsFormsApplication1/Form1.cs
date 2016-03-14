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
            List<int> theData = new List<int> { 5, 6, 2, 1, 6, 4, 6,1,2,3,5,4,3,2,2,1,2,2,1,4,4,5,4,3,3,5,5,6, 3, 6, 2, 3, 6, 1, 6, 3, 3, 4, 1 };
            //This loop adds all of the integers to a list and stops adding when every int has been added.
            for (int i = 0; i < theData.Count; ++i)
            {
                //this sorts the previosly declared list
                theData.Sort();
                //this adds the integers to the lists. It is placed behind the sort because otherwise -->
                //the first int would not be sorteded becaus eof the loop.
                chart1.Series["Damage"].Points.Add(theData[i]);
                
            }
           
        }

    }


}
