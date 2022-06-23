using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int textBoxA = Convert.ToInt32(textBox1.Text);
           // MessageBox.Show("CEDULA"+textBoxA);

            String textBoxB = textBox2.Text;
          //  MessageBox.Show("p nombre"+textBoxB);

            String textBoxC = textBox3.Text;
           // MessageBox.Show("s nombre" + textBoxC);

            String textBoxD = textBox4.Text;
           // MessageBox.Show("p  apellido" + textBoxD);

            String textBoxE = textBox5.Text;
          //  MessageBox.Show("s apellido" + textBoxE);

            //FALTA
            String textBoxF = textBox6.Text;
          //  MessageBox.Show("F NAC" + textBoxF);

            String textBoxG = textBox7.Text;
           // MessageBox.Show("CALLE" + textBoxG);

            int textBoxH = Convert.ToInt32(textBox10.Text);
           // MessageBox.Show("NUMERO" + textBoxH);

            String textBoxI = textBox11.Text;
          //  MessageBox.Show("INTERSECCION" + textBoxI);

            int textBoxY = Convert.ToInt32(textBox8.Text);
           // MessageBox.Show("TELEFONO" + textBoxY);

            String textBoxZ = textBox9.Text;
            MessageBox.Show("Cédula :"+textBoxA+ " \n" + "Primer nombre :" + textBoxB + "\n" + "Segundo nombre :" + textBoxC + "\n" + "Primer apellido :" + textBoxD + "\n" + "Segundo apellido :" + textBoxE + "\n"+ "Fecha de Nacimiento :" + textBoxF + "\n" + "Calle :" + textBoxG + "\n" + "Número :" + textBoxH + "\n" + "Interseccion :" + textBoxI + "\n" + "Teléfono :" + textBoxY  + "\n" + "Email :" + textBoxZ);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;

            }
            else
            {
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                

            }
        }
    }
}
