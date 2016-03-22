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
        Team.Fighter Jeff;
        Team.Fighter Phil;
        public Form1()
        {
            InitializeComponent();

            Jeff = new Team.Fighter("Jeff", 500, 500, 100, 100, 0, 1, 1, 1, 1);
            Phil = new Team.Fighter("Phil", 500, 500, 100, 100, 0, 1, 1, 1, 1);



            ///////////////////////////////
            //attacks
            textBox33.Text = "Enemy 1";
            textBox34.Text = "Enemy 2";
            textBox35.Text = "Enemy 1";
            textBox36.Text = "Enemy 2";
            //////////////////////////////////////
            //player 1 attributes
            textBox1.Text = "Player 1: ";
            textBox2.Text = "Level: " + Jeff.lvl;
            textBox5.Text = "Exp: " + Jeff.exp;
            textBox4.Text = "Health: " + Jeff.health;
            textBox3.Text = "Mana: " + Jeff.mana;
            textBox8.Text = "Strength: " + Jeff.Str;
            textBox7.Text = "Attack: " + Jeff.att;
            textBox6.Text = "Defence: " + Jeff.def;

            //player 2 attributes
            textBox24.Text = "Player 2:";
            textBox22.Text = "Level: " + Phil.lvl;
            textBox21.Text = "Exp: " + Phil.exp;
            textBox23.Text = "Health: " + Phil.health;
            textBox20.Text = "Mana: " + Phil.mana;
            textBox19.Text = "Strength: " + Phil.Str;
            textBox18.Text = "Attack: " + Phil.att;
            textBox17.Text = "Defence: " + Phil.def;
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

        public void update()
        {
            textBox1.Text = "Player 1: ";
            textBox2.Text = "Level: " + Jeff.lvl;
            textBox5.Text = "Exp: " + Jeff.exp;
            textBox4.Text = "Health: " + Jeff.health;
            textBox3.Text = "Mana: " + Jeff.mana;
            textBox8.Text = "Strength: " + Jeff.Str;
            textBox7.Text = "Attack: " + Jeff.att;
            textBox6.Text = "Defence: " + Jeff.def;

            //player 2 attributes
            textBox24.Text = "Player 2:";
            textBox22.Text = "Level: " + Phil.lvl;
            textBox21.Text = "Exp: " + Phil.exp;
            textBox23.Text = "Health: " + Phil.health;
            textBox20.Text = "Mana: " + Phil.mana;
            textBox19.Text = "Strength: " + Phil.Str;
            textBox18.Text = "Attack: " + Phil.att;
            textBox17.Text = "Defence: " + Phil.def;
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Jeff.Auto(Phil);
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Jeff.Auto(Phil);
            update();
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
  
        }
    }
    
}
