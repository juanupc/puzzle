using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rompecabeza
{
    public partial class Form2 : Form
    {
        int mostrador;
        public Form2()
        {
            InitializeComponent();
        }

        public void EmptySpotChecker(Button Butt1,Button Butt2) //cambia el numero al espacio que está vacio
        {
            if (Butt2.Text == "")
            {
                Butt2.Text = Butt1.Text;
                Butt1.Text = "";
            }
        }

        public void SolucionChecker()
        {
            if(button1.Text =="1" && button2.Text =="2" && button3.Text == "3" && button4.Text == "4" &&
                button5.Text == "5" && button6.Text == "6" && button7.Text == "7" && button8.Text == "8" &&
                button9.Text == "9" && button10.Text == "10" && button11.Text == "11" && button12.Text == "12" &&
                button13.Text == "13" && button14.Text == "14" && button15.Text == "15")
            {
                MessageBox.Show("Felicidades, Has ganado ", " PUZZLE GAME ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            mostrador = mostrador + 1;
            textBox1.Text = "Numero de clicks : " + mostrador;
              
        }

        public  void Baraja()
        {
            int[] numeros = new int[16];
            int i=1, j, Verificador;
            Boolean band = false; 
            do
            {
                Random rand = new Random();
                Verificador= Convert.ToInt32(rand.Next(0,15)+1);
                for( j=1; j<=i; j++)
                {
                    if (numeros[j] == Verificador)
                    {
                        band = true;    
                        break;
                    }
                }
                if (band== true)
                {
                    band= false;
                }
                else
                {
                    numeros[i] = Verificador;
                    i=i+1;
                }

            }while (i <= 15) ;

            button1.Text= Convert.ToString(numeros[1]);
            button2.Text = Convert.ToString(numeros[2]);
            button3.Text = Convert.ToString(numeros[3]);
            button4.Text = Convert.ToString(numeros[4]);
            button5.Text = Convert.ToString(numeros[5]);
            button6.Text = Convert.ToString(numeros[6]);
            button7.Text = Convert.ToString(numeros[7]);
            button8.Text = Convert.ToString(numeros[8]);
            button9.Text = Convert.ToString(numeros[9]);
            button10.Text = Convert.ToString(numeros[10]);
            button11.Text = Convert.ToString(numeros[11]);
            button12.Text = Convert.ToString(numeros[12]);
            button13.Text = Convert.ToString(numeros[13]);
            button14.Text = Convert.ToString(numeros[14]);
            button15.Text = Convert.ToString(numeros[15]);
            button16.Text = "";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirme si desea salir", " PUZZLE GAME",
                MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (iExit == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button1.Text= Convert.ToString(1);
            button2.Text = Convert.ToString(2);
            button3.Text = Convert.ToString(3);
            button4.Text = Convert.ToString(4);
            button5.Text = Convert.ToString(5);
            button6.Text = Convert.ToString(6);
            button7.Text = Convert.ToString(7);
            button8.Text = Convert.ToString(8);
            button9.Text = Convert.ToString(9);
            button10.Text = Convert.ToString(10);
            button11.Text = Convert.ToString(11);
            button12.Text = Convert.ToString(12);
            button13.Text = Convert.ToString(13);
            button14.Text = Convert.ToString(14);
            button15.Text = Convert.ToString(15);
            button16.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult iExit = MessageBox.Show("Confirme si desea salir", " PUZZLE",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Baraja();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button1,button2);
            EmptySpotChecker(button1, button5);
            SolucionChecker();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button2, button1);
            EmptySpotChecker(button2, button3);
            EmptySpotChecker(button2, button6);

            SolucionChecker();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button3, button2);
            EmptySpotChecker(button3, button4);
            EmptySpotChecker(button3, button7);

            SolucionChecker();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button4, button3);
            EmptySpotChecker(button4, button8);
            SolucionChecker();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button5, button1);
            EmptySpotChecker(button5, button6);
            EmptySpotChecker(button5, button9);
            SolucionChecker();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button6, button2);
            EmptySpotChecker(button6, button5);
            EmptySpotChecker(button6, button7);
            EmptySpotChecker(button6, button10);
            SolucionChecker();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button7, button3);
            EmptySpotChecker(button7, button6);
            EmptySpotChecker(button7, button8);
            EmptySpotChecker(button7, button11);
            SolucionChecker();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button8, button4);
            EmptySpotChecker(button8, button7);
            EmptySpotChecker(button8, button12);
            SolucionChecker();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button9, button5);
            EmptySpotChecker(button9, button10);
            EmptySpotChecker(button9, button13);
            SolucionChecker();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button10, button6);
            EmptySpotChecker(button10, button9);
            EmptySpotChecker(button10, button11);
            EmptySpotChecker(button10, button14);
            SolucionChecker();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button11, button7);
            EmptySpotChecker(button11, button10);
            EmptySpotChecker(button11, button12);
            EmptySpotChecker(button11, button15);
            SolucionChecker();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button12, button8);
            EmptySpotChecker(button12, button11);
            EmptySpotChecker(button12, button16);
            SolucionChecker();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button13, button9);
            EmptySpotChecker(button13, button14);           
            SolucionChecker();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button14, button10);
            EmptySpotChecker(button14, button13);
            EmptySpotChecker(button14, button15);
            SolucionChecker();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button15, button11);
            EmptySpotChecker(button15, button14);
            EmptySpotChecker(button15, button16);

            SolucionChecker();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EmptySpotChecker(button16, button12);
            EmptySpotChecker(button16, button15);
            SolucionChecker();
        }


        private void button19_Click(object sender, EventArgs e)
        {
            Baraja();

            textBox1.Clear();
           
            this.Refresh();
            this.Hide();
            Form2 newGame = new Form2();
            newGame.Show();
        }
        private void button20_Click(object sender, EventArgs e)
        {
            Baraja();
        }

       
    }
}
