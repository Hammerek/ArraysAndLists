using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_5._2_Arrayer_och_listor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        int[] minArray = new int[5];
        private void button1_Click(object sender, EventArgs e)
        {
            int tal = Convert.ToInt32(textBox1.Text);

            minArray[counter] = tal;
            counter++;

            if (counter == 5)
            {
                button2.Visible = true;
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            negativaTal();
            positivaTal();
            nollTal();
            jamnaUddaTal();
        }

        private void negativaTal()
        {
            int negativCounter = 0;
            foreach (int times in minArray)
            {
                if (times < 0)
                {
                    negativCounter++;
                    richTextBox1.Text = Convert.ToString(negativCounter);
                }
            }
        }
        private void positivaTal()
        {
            int positivCounter = 0;
            foreach (int times in minArray)
            {
                if (times > 0)
                {
                    positivCounter++;
                    richTextBox2.Text = Convert.ToString(positivCounter);
                }
            }
        }

        private void nollTal()
        {
            int nollCounter = 0;
            foreach (int times in minArray)
            {
                if (times == 0)
                {
                    nollCounter++;
                    richTextBox3.Text = Convert.ToString(nollCounter);
                }
            }
        }

        private void jamnaUddaTal()
        {
            int jamnaCounter = 0;
            int uddaCounter = 0;

            foreach (int times in minArray)
            {
                if (times % 2 == 0)
                {
                    jamnaCounter++;
                    richTextBox4.Text = Convert.ToString(jamnaCounter);
                }
                else if (times % 2 != 0)
                {
                    uddaCounter++;
                    richTextBox5.Text = Convert.ToString(uddaCounter);
                }
            }
        }
    }
}
