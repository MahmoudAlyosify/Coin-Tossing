using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Tossing
{
   
    public partial class Form1 : Form
    {
        static int coinHead = 0;
        static int coinTails = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public void Toss()
        {

            Random randomNumbers;
            const int NUMBER_OF_SIDES = 2;
           
            randomNumbers = new Random();
            int second = randomNumbers.Next(NUMBER_OF_SIDES);
           
            
                if (second == 1)
                {
                   coinHead+=1;
                    richTextBox1.Text = "It's Head ^__^ ";
                    textBox1.Text = coinHead.ToString();
                }

                else
                {
                   coinTails+=1;
                    richTextBox1.Text = "It's Tail ^__^ ";
                    textBox2.Text = coinTails.ToString();
                }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Toss();
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Thanks for Playing ^__^";
            label1.Text = "Game end you get : " + coinHead.ToString() + " Heads and " + coinTails.ToString() + " Tails"; 
            coinHead = 0;
          coinTails = 0;
            textBox2.Text = coinTails.ToString();
            textBox1.Text = coinHead.ToString();
          
        }
    }
}
