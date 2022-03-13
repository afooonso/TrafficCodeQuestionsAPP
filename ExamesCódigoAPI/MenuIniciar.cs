using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ExamesCódigoAPI
{
    public partial class MenuIniciar : Form
    {
        
        WMPLib.WindowsMediaPlayer player = new  WMPLib.WindowsMediaPlayer ();
        public bool fechou=false;
        public MenuIniciar()
        {
            
           
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            this.Hide();
            fechou = false;

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
                
                
           
            
        }

        private void MenuIniciar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( fechou==true)
            {
                if ((MessageBox.Show("Deseja sair?", "Sair?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    e.Cancel = false;
                    timer1.Enabled = false;
                }
                else
                {
                    e.Cancel = true;
                    
                }
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MenuIniciar_Load(object sender, EventArgs e)
        {
            trackBar1.Value = trackBar1.Maximum;
            pictureBox5.Visible = false;

            timer1.Enabled = true;
            fechou = true;

            player.URL = @"perguntas\musicadefundo.wav";
            player.controls.play();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabalho realizado por: Carlos Novais e Afonso Pedreira");
        }

        private void informaçõesLegaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todas as perguntas foram retiradas do site www.bomcondutor.pt e criadas pelo IMT(Instituto de Mobilidade e Transportes).© 2022 — Bom Condutor");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fechou = true;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Minute<10)
            {
                label2.Text = $"{DateTime.Now.Hour}:0{DateTime.Now.Minute}";
            }
            else
            {
                label2.Text = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("afonsopedreira14@gmail.com || Carlosnovais10@hotmail.com");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            player.settings.volume = 100;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            player.settings.volume = 0;
        }

        private void trackBar1_LocationChanged(object sender, EventArgs e)
        {
            

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var localizacao = trackBar1.Value;
            player.settings.volume = localizacao;
            if (player.settings.volume==0)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            else
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            player.settings.volume = 100;
            pictureBox5.Visible = false;
            pictureBox6.Visible = true;
            trackBar1.Value = trackBar1.Maximum;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            player.settings.volume = 0;
            pictureBox6.Visible = false;
            pictureBox5.Visible = true;
            trackBar1.Value = trackBar1.Minimum;
        }
    }
}
