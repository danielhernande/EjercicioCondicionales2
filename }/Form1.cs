﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _
{
    public partial class calcular : Form
    {
        public calcular()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxrespuesta.SelectedIndex = 0;
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horasTrabajadas, valorHora,salarioBase, salud,incremento,salarioAPagar;

            horasTrabajadas = double.Parse(txthorastrabajadas.Text);

            valorHora= double.Parse(txtvalorhora.Text);

            salarioBase = horasTrabajadas * valorHora;

            switch (cbxrespuesta.SelectedItem)
            { 
                case "NO":

                    if (salarioBase > 1000000)
                    {

                        salud = salarioBase * 0.04;
                        incremento = 0;

                    }
                    else
                    {
                        salud = 0;
                        incremento = salarioBase * 0.02;

                    }
                    salarioAPagar = salarioBase - salud + incremento;
                    break;
                    

                case "SI":

                    if (salarioBase > 1000000)
                    {

                        salud = salarioBase * 0.04;
                        incremento = 0;

                    }
                    else
                    {
                        salud = 0;
                        incremento = salarioBase * 0.01;

                    }
                    salarioAPagar = salarioBase - salud + incremento;
                    lblsalariobase.Text = Convert.ToString("$" + salarioBase);
                    lblpagosalud.Text = Convert.ToString(salud);
                    lblincremento.Text = Convert.ToString(incremento);
                    lblsalalrioapagar.Text = Convert.ToString(salarioAPagar);

                    gbxresumenpago.Visible = true;

                    break;

                    
            }



           

            



        }

        private void btnlimpiarcampo_Click(object sender, EventArgs e)
        {
            txthorastrabajadas.Text = string.Empty;
            txtvalorhora.Text = string.Empty;
            gbxresumenpago.Visible = false;
            txthorastrabajadas.Focus = true;
        }
    }
}
