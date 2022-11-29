using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_velha
{
    public partial class Form1 : Form
    {
        Jogo jogo = new Jogo();
        int qcomeca = 0;
        int jx = 0, jo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jogador X pretende começar o jogo?", "Quem começa?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                qcomeca = 1;
            else
                qcomeca = 0;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            jx = jo = 0;
            lblJogou.Text = "";
            jogo = new Jogo();
            lblJogadorO.Text = "0";
            lblJogadorX.Text = "0";
            foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
            {
                if (item != btnResetar)
                {
                    item.Text = "";
                }

            }
        }

        private void btnL0C1_Click(object sender, EventArgs e)
        {
            if (qcomeca == 0)
            {
                if ((sender as Guna.UI2.WinForms.Guna2Button).Text == "")
                {
                    (sender as Guna.UI2.WinForms.Guna2Button).Text = "O";

                    if (jogo.Jogar(int.Parse((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString()[0].ToString()), int.Parse((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString()[2].ToString()), qcomeca))
                    {
                        if (jogo.QuemGanhou() != 'N')
                        {
                            MessageBox.Show($"O jogo acabou jogador '{jogo.QuemGanhou()}' Venceu o jogo", "Parábens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            jo++;
                            lblJogadorO.Text = jo.ToString();
                            foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                            {
                                if (item != btnResetar)
                                {
                                    item.Text = "";
                                }
                               
                            }
                            jogo = new Jogo();
                            return;
                        }
                    }
                    else if (jogo.Empate())
                    {
                        MessageBox.Show("Houve um empate!", "Empate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                        {
                            if (item != btnResetar)
                            {
                                item.Text = "";
                            }
                        }
                        jogo = new Jogo();
                        lblJogou.Text = "";
                        return;
                    }
                    lblJogou.Text = $"{(sender as Guna.UI2.WinForms.Guna2Button).Text} Jogou!";
                    qcomeca = 1;
                }
            }
            else if (qcomeca == 1)
            {
                if ((sender as Guna.UI2.WinForms.Guna2Button).Text == "")
                {
                    (sender as Guna.UI2.WinForms.Guna2Button).Text = "X";
                    if(jogo.Jogar(int.Parse((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString()[0].ToString()), int.Parse((sender as Guna.UI2.WinForms.Guna2Button).Tag.ToString()[2].ToString()), qcomeca))
                    {
                        if (jogo.QuemGanhou() != 'N')
                        {
                            MessageBox.Show($"O jogo acabou jogador '{jogo.QuemGanhou()}' Venceu o jogo", "Parábens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            jx++;
                            lblJogadorX.Text = jx.ToString();
                            foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                            {
                                if (item != btnResetar)
                                {
                                    item.Text = "";
                                }
                            }
                            jogo = new Jogo();
                            lblJogou.Text = "";
                            return;
                        }
                    }
                    else if (jogo.Empate())
                    {
                        MessageBox.Show("Houve um empate!", "Empate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foreach (var item in Controls.OfType<Guna.UI2.WinForms.Guna2Button>())
                        {
                            if (item != btnResetar)
                            {
                                item.Text = "";
                            }
                        }
                        jogo = new Jogo();
                        return;
                    }
                    lblJogou.Text = $"{(sender as Guna.UI2.WinForms.Guna2Button).Text} Jogou!";
                    qcomeca = 0;
                }
            }
        }
    }
}
