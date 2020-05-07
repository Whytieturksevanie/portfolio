using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace torensvanhanoi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // formule zetten forloop //
            int input;
            int.TryParse(inputTextBox.Text, out input);
            ulong output;
            ulong.TryParse(inputTextBox.Text, out output);
            ulong time = 0;
            ulong number = 0;


                if (input >= 65)
                {
                    MessageBox.Show("Getal moet kleiner zijn dan 65");
                }
                else if (input <= 0)
                {
                    MessageBox.Show("Getal moet groter zijn dan 0");
                }
                else if (input <= 64 && input >= 0)
                {

                    for (int x = 0; x != input; x++)
                    {
                        
                        time = time * 2 + 1;
                        number = number * 2 + 1;
                    }

                    MessageBox.Show(number.ToString() + " zetten");

                    // formule zetten tijden forloop // 
                    ulong second = time % 60;
                    ulong minuut = time / 60 % 60;
                    ulong uren = time / 60 / 60 % 24;
                    ulong dagen = time / 24 / 60 / 60 % 7;
                    ulong weken = time / 7 / 24 / 60 % 4;
                    ulong maanden = time / 4 / 7 / 24 / 60 % 12;
                    ulong jaren = time / 12 / 4 / 7 / 24 / 60 % 10;
                    ulong decenia = time / 10 / 12 / 4 / 7 / 24 / 60 / 60 % 100;
                    ulong eeuwen = time / 10 / 10 / 12 / 4 / 7 / 24 / 60 % 60;
                    outputLabel.Text = string.Format("{0} seconden \r\n{1} minuten \r\n{2} uren \r\n{3} dagen \r\n{4} weken \r\n{5} maanden \r\n{6} jaren \r\n{7} decenia \r\n{8} eeuwen", second, minuut, uren, dagen, weken, maanden, jaren, decenia, eeuwen);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // formule zetten machtsverheffen //
            ulong input;
            ulong output;
            ulong time = 0;
            ulong.TryParse(inputTextBox.Text, out input);
            ulong.TryParse(inputTextBox.Text, out output);
            output = (ulong)System.Math.Pow(2, input) - 1;
            answerLabel.Text = string.Format("{0} zetten om klaar te zijn met het spel", output);


            // formule zetten tijden machtsverheffen //
            for (ulong x = 0; x != input; x++)
            {
                time = time * 2 + 1;
            }
            ulong second = time % 60;
            ulong minuut = time / 60 % 60;
            ulong uren = time / 60 / 60 % 24;
            ulong dagen = time / 24 / 60 / 60 % 7;
            ulong weken = time / 7 / 24 / 60 % 4;
            ulong maanden = time / 4 / 7 / 24 / 60 % 12;
            ulong jaren = time / 12 / 4 / 7 / 24 / 60 % 10;
            ulong decenia = time / 10 / 12 / 4 / 7 / 24 / 60 / 60 % 100;
            ulong eeuwen = time / 10 / 10 / 12 / 4 / 7 / 24 / 60 % 60;
            outputLabel.Text = string.Format("{0} seconden \r\n{1} minuten \r\n{2} uren \r\n{3} dagen \r\n{4} weken \r\n{5} maanden \r\n{6} jaren \r\n{7} decenia \r\n{8} eeuwen", second, minuut, uren, dagen, weken, maanden, jaren, decenia, eeuwen);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // formule zetten recursie //
            ulong input;
            ulong time = 0;
            ulong.TryParse(inputTextBox.Text, out input);
            if (input >= 65)
            {
                MessageBox.Show("Getal moet kleiner zijn dan 65");
            }
            else
            {
                ulong result = count(0, 1, input);
                answerLabel.Text = string.Format("{0} zetten om klaar te zijn met het spel", result);
            }
            // formule zetten tijden recursie
            for (ulong x = 0; x != input; x++)
            {
                time = time * 2 + 1;
            }
            ulong second = time % 60;
            ulong minuut = time / 60 % 60;
            ulong uren = time / 60 / 60 % 24;
            ulong dagen = time / 24 / 60 / 60 % 7;
            ulong weken = time / 7 / 24 / 60 % 4;
            ulong maanden = time / 4 / 7 / 24 / 60 % 12;
            ulong jaren = time / 12 / 4 / 7 / 24 / 60 % 10;
            ulong decenia = time / 10 / 12 / 4 / 7 / 24 / 60 / 60 % 100;
            ulong eeuwen = time / 10 / 10 / 12 / 4 / 7 / 24 / 60 % 60;
            outputLabel.Text = string.Format("{0} seconden \r\n{1} minuten \r\n{2} uren \r\n{3} dagen \r\n{4} weken \r\n{5} maanden \r\n{6} jaren \r\n{7} decenia \r\n{8} eeuwen", second, minuut, uren, dagen, weken, maanden, jaren, decenia, eeuwen);
        }

        ulong count(ulong zetten, ulong huidigeschijf, ulong input)
        {
            if (huidigeschijf > input)
            {
                return zetten;
            }
            else
            {
                zetten = zetten * 2 + 1;
                ulong resultaat = count(zetten, huidigeschijf + 1, input);

                return resultaat;

            }
        }
    }
}
        
