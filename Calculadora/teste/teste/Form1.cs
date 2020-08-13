using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        
        private void btsub_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lblvalor1.Text) || string.IsNullOrWhiteSpace(lblvalor2.Text)) //Se o campo for nulo
                MessageBox.Show("Preencha todas as informações");
           

            else
            {
                int val1, val2, resu;
                val1 = Convert.ToInt16(lblvalor1.Text);
                val2 = Convert.ToInt16(lblvalor2.Text);
                resu = val1 - val2;
                lblresu.Text = Convert.ToString(resu);
                lblresu.ForeColor = Color.White;
            }
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblvalor1.Text) || string.IsNullOrWhiteSpace(lblvalor2.Text)) //Se o campo for nulo
                MessageBox.Show("Preencha todas as informações");
            else
            {
                int val1, val2, resu;
                val1 = Convert.ToInt16(lblvalor1.Text);
                val2 = Convert.ToInt16(lblvalor2.Text);
                resu = val1 * val2;
                lblresu.Text = Convert.ToString(resu);
                lblresu.ForeColor = Color.White;
            }
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            lblvalor1.Text = " ";
            lblvalor2.Text = " ";
            lblresu.ResetText();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblvalor1_TextChanged(object sender, EventArgs e)
        {
            lblvalor1.BackColor = Color.Black; //Muda a cor de fundo
            lblvalor1.ForeColor = Color.White; //Muda a cor da letra
        }

        private void lblvalor2_TextChanged(object sender, EventArgs e)
        {
            lblvalor2.BackColor = Color.Black;
            lblvalor2.ForeColor = Color.White;
        }

        private void btdiv_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblvalor1.Text) || string.IsNullOrWhiteSpace(lblvalor2.Text)) //Se o campo for nulo
                MessageBox.Show("Preencha todas as informações");
            else
            {
                int val1, val2, resu;
                val1 = Convert.ToInt16(lblvalor1.Text);
                val2 = Convert.ToInt16(lblvalor2.Text);
                resu = val1 / val2;
                lblresu.Text = Convert.ToString(resu);
                lblresu.ForeColor = Color.White;
            }
        }

        private void lblresu_Click(object sender, EventArgs e)
        {

        }

        private void btsoma_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblvalor1.Text) || string.IsNullOrWhiteSpace(lblvalor2.Text)) //Se o campo for nulo
                MessageBox.Show("Preencha todas as informações");
            else
            {
                int val1, val2, resu; //Criação das variáveis
                val1 = Convert.ToInt16(lblvalor1.Text); //O valor da lblvalor1 vai ser convertido para número e armazenado na variável val1
                val2 = Convert.ToInt16(lblvalor2.Text);
                resu = val1 + val2;
                lblresu.Text = Convert.ToString(resu);
                lblresu.ForeColor = Color.White;
            }
        }

        private void calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
