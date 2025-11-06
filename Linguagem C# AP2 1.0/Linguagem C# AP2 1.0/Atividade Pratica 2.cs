using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linguagem_C__AP2_1._0
{
    public partial class Form1 : Form
    {
         
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    double celsius = Convert.ToDouble(textBox1.Text);
                    double fahrenheit = (celsius * 1.8) + 32;

                    textBox2.Text = Convert.ToString($"{fahrenheit:F2} ºF");
                }
                catch (Exception)
                {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em Celsius .", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "") // Verifica se o campo não é vazio.
            {
                try
                {
                    double kelvin = Convert.ToDouble(textBox1.Text);

                    double fahrenheit = (kelvin - 273.15) * 1.8 + 32;

                    textBox2.Text = Convert.ToString($"{fahrenheit:F2} ºF");
                }
                catch (Exception ) {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em Kelvin.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    double kelvin = Convert.ToDouble(textBox1.Text);
                    double celsius = (kelvin - 273.15);

                    textBox2.Text = Convert.ToString($"{celsius:F2} ºC");
                }
                catch
                {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em Kelvin.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    double celsius = Convert.ToDouble(textBox1.Text);
                    double kelvin = celsius + 273.15;


                    textBox2.Text = Convert.ToString($"{celsius} ºC = {kelvin:F3} K ");
                }
                catch
                {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em celsius.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    double Fahrenheit = Convert.ToDouble(textBox1.Text);
                    double kelvin = (Fahrenheit - 32) * 5/9 + 273.15;

                    textBox2.Text = Convert.ToString($"{Fahrenheit} ºF = {kelvin:F3} K");
                }
                catch
                {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em Fahrenheit.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                try
                {
                    double Fahrenheit = Convert.ToDouble(textBox1.Text);
                    double celsius = (Fahrenheit - 32) * 5 / 9;

                    textBox2.Text = Convert.ToString($"{Fahrenheit} ºF = {celsius:F2} ºC");
                }
                catch
                {
                    MessageBox.Show("Digite um valor numérico válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Campo vazio! Digite um valor em Fahrenheit.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
