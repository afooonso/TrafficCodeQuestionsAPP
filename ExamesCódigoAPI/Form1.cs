using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamesCódigoAPI
{
    public partial class Form1 : Form
    {
        bool fechar = false;
        int tempo = 30;
        int tempsegundos=60;
        int i = 0;
        List<int> opcaoescolhida = new List<int>(30);
        List<string> respostaescolhida= new List<string>(30);
        bool reverexame = false;
       
        CriarLista A = new CriarLista();

        List<Perguntas> listaperguntas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MenuIniciar form = new MenuIniciar();

            form.ShowDialog();
            if (form.fechou==true)
            {
                    
                this.Close();
            }
            else
            {
                groupBox3.Visible = false;
                opcaoescolhida = A.adicionarvaloresnulosalista();
                respostaescolhida = A.adicionarstringsvaziasalista();
                timer1.Enabled = true;
                label4.Text= tempo.ToString();  
                
                A.adicionarperguntasalista();
                listaperguntas = A.returnlista();
                label5.Text = listaperguntas[i].textopergunta;
                label1.Text = listaperguntas[i].primeiraopcao;
                label2.Text = listaperguntas[i].segundaopcao;
                label3.Text = listaperguntas[i].terceiraopcao;
                pictureBox1.Image = listaperguntas[i].imagempergunta;
                button2.Enabled = false;
                fechar = true;
              
           
                
               
            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
               
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

      
            
            
          
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            i++;

            if (reverexame==false)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                if (opcaoescolhida[i] == 0)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                }
                else
                {
                    if (opcaoescolhida[i] == 1)
                    {
                        radioButton1.Checked = true;

                    }
                    else if (opcaoescolhida[i] == 2)
                    {
                        radioButton2.Checked = true;
                    }
                    else
                    {
                        radioButton3.Checked = true;
                    }
                }

                if (i + 1 < listaperguntas.Count)
                {



                    label1.Text = listaperguntas[i].primeiraopcao;
                    label2.Text = listaperguntas[i].segundaopcao;
                    label3.Text = listaperguntas[i].terceiraopcao;
                    pictureBox1.Image = listaperguntas[i].imagempergunta;
                    label5.Text = listaperguntas[i].textopergunta;

                }
                else
                {


                    label1.Text = listaperguntas[i].primeiraopcao;
                    label2.Text = listaperguntas[i].segundaopcao;
                    label3.Text = listaperguntas[i].terceiraopcao;
                    pictureBox1.Image = listaperguntas[i].imagempergunta;
                    label5.Text = listaperguntas[i].textopergunta;


                    button1.Enabled = false;
                }
            
           
               
               
               


            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                if (opcaoescolhida[i] == 0)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    if (listaperguntas[i].primeiraopcao== listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Green;
                    }
                    else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Green;
                    }
                    else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                    {
                        label3.ForeColor = Color.Green;
                    }
                }
                else
                {
                    if (opcaoescolhida[i] == 1)
                    {
                        radioButton1.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;
                            label1.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Red;
                            label3.ForeColor = Color.Green;
                        }

                    }
                    else if (opcaoescolhida[i] == 2)
                    {
                        radioButton2.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                            label2.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;
                            
                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Red;
                            label3.ForeColor = Color.Green;
                        }

                    }
                    else
                    {
                        radioButton3.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                            label3.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;
                            label3.ForeColor = Color.Red;

                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {
                            
                            label3.ForeColor = Color.Green;
                        }
                    }
                }

                if (i + 1 < listaperguntas.Count)
                {



                    label1.Text = listaperguntas[i].primeiraopcao;
                    label2.Text = listaperguntas[i].segundaopcao;
                    label3.Text = listaperguntas[i].terceiraopcao;
                    pictureBox1.Image = listaperguntas[i].imagempergunta;
                    label5.Text = listaperguntas[i].textopergunta;

                }
                else
                {


                    label1.Text = listaperguntas[i].primeiraopcao;
                    label2.Text = listaperguntas[i].segundaopcao;
                    label3.Text = listaperguntas[i].terceiraopcao;
                    pictureBox1.Image = listaperguntas[i].imagempergunta;
                    label5.Text = listaperguntas[i].textopergunta;


                    button1.Enabled = false;
                }
            }
            
        }

      

        
        
            
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo-1>1 )
            {
                tempo--;
                label4.Text=tempo.ToString();
            }
            else
            {
                

                if (tempsegundos==0)
                {

                    timer1.Enabled = false;
                    MessageBox.Show("Terminou o tempo!");
                    label4.Text = "0";
                    tempo = 30;
                     tempsegundos = 60;
                    groupBox2.Visible = false;
                    int respostascertas = A.corrigirperguntas(listaperguntas, respostaescolhida);
                    groupBox3.Visible = true;
                    if (respostascertas < 27)
                    {

                        groupBox3.BackColor = Color.Red;
                        pictureBox2.Image = Image.FromFile(@"perguntas\imagens\reprovou.png");
                        label6.Text = "REPROVADO";
                        label7.Text = $"Com {30 - respostascertas} perguntas erradas!";

                    }
                    else
                    {
                        groupBox3.BackColor = Color.Green;
                        pictureBox2.Image = Image.FromFile(@"perguntas\imagens\passou.png");
                        label6.Text = "APROVADO";
                        label7.Text = $"Com {30 - respostascertas} perguntas erradas!";
                    }


                }
                else
                {
                    timer1.Interval = 1000;
                    tempsegundos--;
                    label4.Text = tempsegundos.ToString();
                    label4.ForeColor = Color.Red;

                }
               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            



            i--;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            if (reverexame==false)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                if (i == 0)
                {
                    button2.Enabled = false;

                }
                if (opcaoescolhida[i] == 0)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    
                }
                else
                {
                    if (opcaoescolhida[i] == 1)
                    {
                        radioButton1.Checked = true;
                       
                       

                    }
                    else if (opcaoescolhida[i] == 2)
                    {
                        radioButton2.Checked = true;

                    }
                    else
                    {
                        radioButton3.Checked = true;
                    }
                }
                label1.Text = listaperguntas[i].primeiraopcao;
                label2.Text = listaperguntas[i].segundaopcao;
                label3.Text = listaperguntas[i].terceiraopcao;
                pictureBox1.Image = listaperguntas[i].imagempergunta;
                label5.Text = listaperguntas[i].textopergunta;
            }
            else
            {
                if (i == 0)
                {
                    button2.Enabled = false;

                }
                if (opcaoescolhida[i] == 0)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Green;
                        label2.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                    }
                    else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Green;
                        label1.ForeColor = Color.Black;
                        label3.ForeColor = Color.Black;
                    }
                    else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                    {
                        label3.ForeColor = Color.Green;
                        label1.ForeColor = Color.Black;
                        label2.ForeColor = Color.Black;
                    }
                }
                else
                {
                    if (opcaoescolhida[i] == 1)
                    {
                        radioButton1.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;
                            label1.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Red;
                            label3.ForeColor = Color.Green;
                        }

                    }
                    else if (opcaoescolhida[i] == 2)
                    {
                        radioButton2.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                            label2.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;

                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Red;
                            label3.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        radioButton3.Checked = true;
                        if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                        {
                            label1.ForeColor = Color.Green;
                            label3.ForeColor = Color.Red;
                        }
                        else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                        {
                            label2.ForeColor = Color.Green;
                            label3.ForeColor = Color.Red;

                        }
                        else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                        {

                            label3.ForeColor = Color.Green;
                        }
                    }
                }
                label1.Text = listaperguntas[i].primeiraopcao;
                label2.Text = listaperguntas[i].segundaopcao;
                label3.Text = listaperguntas[i].terceiraopcao;
                pictureBox1.Image = listaperguntas[i].imagempergunta;
                label5.Text = listaperguntas[i].textopergunta;

            }
          

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                opcaoescolhida[i ] = 1;
                respostaescolhida[i ] = listaperguntas[i].primeiraopcao;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                opcaoescolhida[i] = 2;
                respostaescolhida[i] = listaperguntas[i].segundaopcao;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                opcaoescolhida[i] = 3;
                respostaescolhida[i] = listaperguntas[i].terceiraopcao;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text=="Terminar Teste")
            {
                if (MessageBox.Show("Deseja Terminar?", "Terminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    groupBox2.Visible = false;
                    int respostascertas = A.corrigirperguntas(listaperguntas, respostaescolhida);
                    groupBox3.Visible = true;
                    if (respostascertas < 27)
                    {

                        groupBox3.BackColor = Color.Red;
                        pictureBox2.Image = Image.FromFile(@"perguntas\imagens\reprovou.png");
                        label6.Text = "REPROVADO";
                        label7.Text = $"Com {30 - respostascertas} perguntas erradas!";

                    }
                    else
                    {
                        groupBox3.BackColor = Color.Green;
                        pictureBox2.Image = Image.FromFile(@"perguntas\imagens\passou.png");
                        label6.Text = "APROVADO";
                        label7.Text = $"Com {30 - respostascertas} perguntas erradas!";
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }

           
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Text = "Terminar Teste";
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            reverexame = false;
            radioButton1.Enabled= true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            label4.Visible = true;
            label4.ForeColor = Color.Black;
            tempo = 30;
             tempsegundos = 60;
             i = 0;
             opcaoescolhida = new List<int>(30);
            respostaescolhida = new List<string>(30);
            listaperguntas.Clear();
            listaperguntas = A.returnlista();
            respostaescolhida = A.adicionarstringsvaziasalista();
            opcaoescolhida = A.adicionarvaloresnulosalista();
            groupBox3.Visible = false;
            this.BackColor = Color.White;
            timer1.Enabled = true;
            timer1.Interval = 60000;
            label4.Text = tempo.ToString();
            label4.ForeColor = Color.Black;
            label5.Text = listaperguntas[i].textopergunta;
            label1.Text = listaperguntas[i].primeiraopcao;
            label2.Text = listaperguntas[i].segundaopcao;
            label3.Text = listaperguntas[i].terceiraopcao;
            pictureBox1.Image = listaperguntas[i].imagempergunta;
            button2.Enabled = false;
            groupBox2.Visible = true;
            button1.Enabled = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fechar = true;
            this.Close();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fechar==false )
            {
                e.Cancel = false;
            }
            else
            {
                if ((MessageBox.Show("Deseja Sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes && fechar==true)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel=true;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label4.Visible = false;
            button3.Text = "Voltar";
            reverexame = true;
            this.BackColor = Color.White;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            i = 0;
            label5.Text = listaperguntas[i].textopergunta;
            label1.Text = listaperguntas[i].primeiraopcao;
            label2.Text = listaperguntas[i].segundaopcao;
            label3.Text = listaperguntas[i].terceiraopcao;
            pictureBox1.Image = listaperguntas[i].imagempergunta;
            button2.Enabled = false;
            button1.Enabled = true;
            fechar = true;
            if (opcaoescolhida[i] == 0)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                {
                    label1.ForeColor = Color.Green;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                }
                else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                {
                    label2.ForeColor = Color.Green;
                    label1.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                }
                else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                {
                    label3.ForeColor = Color.Green;
                    label2.ForeColor = Color.Black;
                    label1.ForeColor = Color.Black;
                }
            }
            else
            {
                if (opcaoescolhida[i] == 1)
                {
                    radioButton1.Checked = true;
                    if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Green;
                    }
                    else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Green;
                        label1.ForeColor = Color.Red;
                    }
                    else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Red;
                        label3.ForeColor = Color.Green;
                    }

                }
                else if (opcaoescolhida[i] == 2)
                {
                    radioButton2.Checked = true;
                    if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Green;
                        label2.ForeColor = Color.Red;
                    }
                    else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Green;

                    }
                    else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Black;
                        label3.ForeColor = Color.Green;
                    }

                }
                else
                {
                    radioButton3.Checked = true;
                    if (listaperguntas[i].primeiraopcao == listaperguntas[i].respostacerta)
                    {
                        label1.ForeColor = Color.Green;
                        label3.ForeColor = Color.Red;
                    }
                    else if (listaperguntas[i].segundaopcao == listaperguntas[i].respostacerta)
                    {
                        label2.ForeColor = Color.Green;
                        label3.ForeColor = Color.Red;

                    }
                    else if (listaperguntas[i].terceiraopcao == listaperguntas[i].respostacerta)
                    {

                        label3.ForeColor = Color.Green;
                    }
                }
            }

            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }

}

