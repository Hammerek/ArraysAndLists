using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboration_5._2_Arrayer_och_listor //Kamil EEDAT14A
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0; //variabel som kommer räkna antal tryck på knappen 
        int[] minArray = new int[5]; //array som innehåller 5 tal 
        private void button1_Click(object sender, EventArgs e)
        {
            int tal = Convert.ToInt32(textBox1.Text); //variabel till tal som man skriver i textboxen

            minArray[counter] = tal; //tal är arrayen med antal tryckningar 
            counter++;

            if (counter == 5) //om man trycker fem gånger på knappen så 
            {
                button2.Visible = true; //button2 visar sig 
                button1.Enabled = false; //button1 går inte att trycka 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            negativaTal(); //metoder 
            positivaTal();
            nollTal();
            jamnaUddaTal();
        }

        private void negativaTal()
        {
            int negativCounter = 0;//räknare för negativa tal 
            foreach (int times in minArray)//foreach går genom varje tal i arrayen och gör "if" för varje tal
            {
                if (times < 0)// om varje tal i arrayen är mindre än noll 
                {
                    negativCounter++;//antal plussas ihop
                    richTextBox1.Text = Convert.ToString(negativCounter);//visar antal negativa tal i richtextboxen 
                }
            }
        }
        private void positivaTal()
        {
            int positivCounter = 0; //räknare för positiva tal
            foreach (int times in minArray)//för varje tal i arrayen 
            {
                if (times >= 0)//om tal är större eller lika med noll 
                {
                    positivCounter++;//tal plussas ihop
                    richTextBox2.Text = Convert.ToString(positivCounter);//visar antal positiva tal i richtextboxen 
                }
            }
        }

        private void nollTal()
        {
            int nollCounter = 0;//räknare för nollor
            
            foreach (int times in minArray)//for varje nolla i arrayen 
            {
                if (minArray.Contains(0))// om tal innehåller 0 
                {
                    nollCounter++;//tal plussas ihop
                    richTextBox3.Text = Convert.ToString(nollCounter);//visar antal nollor i richtextboxen
                }
            }
        }

        private void jamnaUddaTal()
        {
            int jamnaCounter = 0;//räknare för jämna tal
            int uddaCounter = 0;//räknare för udda tal

            foreach (int times in minArray)//för varje tal i arrayen
            {
                if (times % 2 == 0)//om tal är jämnt
                {
                    jamnaCounter++;//tal plussas ihop
                    richTextBox4.Text = Convert.ToString(jamnaCounter);//visar antal jämna tal i richtextboxen
                }
                else if (times % 2 != 0)//annars om talen är udda
                {
                    uddaCounter++;//tal plussas ihop 
                    richTextBox5.Text = Convert.ToString(uddaCounter);//visar antal udda tal i richtextboxen
                }
            }
        }
    }
}
