﻿using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
            Msk_CPF.Focus();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            string vConteudo;
            vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".","").Replace("-","");
            vConteudo = vConteudo.Trim();

            if(vConteudo == "")
            {
                MessageBox.Show("Você deve digitar um CPF", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Msk_CPF.Focus();
            }
            else if (vConteudo.Length != 11)
            {
                MessageBox.Show("O CPF deve ter 11 dígitos", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Msk_CPF.Focus();
            }
            else
            {
                if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool validaCPF = false;
                    validaCPF = Validacao.ValidarCPF(Msk_CPF.Text);
                    if (validaCPF == true)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
        }
    }
}
