using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGP125;

public enum State
{
    INIT,
    ATTACK,
    E_ATTACK,
    END

}

namespace ADGP125
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Team.Fighter Jeff = new Team.Fighter("skjdfkjsdf",23);
            

            ///////////////////////////////
            //attacks
            textBox33.Text = "Enemy 1";
            textBox34.Text = "Enemy 2";
            textBox35.Text = "Enemy 1";
            textBox36.Text = "Enemy 2";
            //////////////////////////////////////
            //player 1 attributes
            textBox1.Text = "Player 1:";
            textBox2.Text = "Level: ";
            textBox5.Text = "Exp:";
            textBox4.Text = "Health: ";
            textBox3.Text = "Mana:";
            textBox8.Text = "Strength: ";
            textBox7.Text = "Attack: ";
            textBox6.Text = "Defence:";

            //player 2 attributes
            textBox24.Text = "Player 2:";
            textBox22.Text = "Level: ";
            textBox21.Text = "Exp:";
            textBox23.Text = "Health: ";
            textBox20.Text = "Mana:";
            textBox19.Text = "Strength: ";
            textBox18.Text = "Attack: ";
            textBox17.Text = "Defence:";
            /////////////////////////////////////////
            //Enemy 1 attributes
            textBox9.Text = "Enemy 1";
            textBox15.Text = "Level: ";
            textBox14.Text = "Exp:";
            textBox13.Text = "Health: ";
            textBox12.Text = "Mana:";
            textBox11.Text = "Strength: ";
            textBox10.Text = "Attack: ";
            textBox16.Text = "Defence:";
            // Enemy 2 Attributes
            textBox25.Text = "Enemy 2";
            textBox32.Text = "Level: ";
            textBox31.Text = "Exp:";
            textBox30.Text = "Health: ";
            textBox29.Text = "Mana:";
            textBox28.Text = "Strength: ";
            textBox27.Text = "Attack: ";
            textBox26.Text = "Defence:";
            //////////////////////////////////////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You thought this thing worked?!  XD");
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
  
        }
    }
}
