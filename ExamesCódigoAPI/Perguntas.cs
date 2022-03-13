using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace ExamesCódigoAPI
{
    public class Perguntas
    {
        public string textopergunta { get; set; }
        public string primeiraopcao { get; set; }
        public string segundaopcao { get; set; }
        public string terceiraopcao { get; set; }
        
        public string respostacerta { get; set; }
        public Image imagempergunta { get; set; }

        public Perguntas(string frase, string resp1, string resp2, string resp3, string respostacer, Image imagem)
        {
            this.textopergunta = frase;
            this.primeiraopcao = resp1;
            this.segundaopcao = resp2;
            this.terceiraopcao = resp3;
            this.respostacerta = respostacer;
            this.imagempergunta = imagem;

        }




       
        




    }
    public class CriarLista
    {
         public List<Perguntas> listaperguntas;

    public CriarLista()
    {
            listaperguntas = new List<Perguntas>();
    }
    public void adicionarperguntasalista()
    {
        StreamReader ft = File.OpenText(@"perguntas\perguntasimagem.txt");
        while (!ft.EndOfStream)
        {
            string pergunta = ft.ReadLine();
            string resposta1 = ft.ReadLine();
            string resposta2 = ft.ReadLine();
            string resposta3 = ft.ReadLine();
            string respostacer = ft.ReadLine();
            string nomefoto = ft.ReadLine();


             Image IMAGEM = (Image.FromFile($@"perguntas\imagens\{nomefoto}.jpg"));
             
             listaperguntas.Add(new Perguntas(pergunta,resposta1,resposta2,resposta3,respostacer, IMAGEM));

        }
       



    }
        public List<Perguntas> returnlista()
        {
            Random random = new Random();
            List<Perguntas> listacomapenas30perguntas = new List<Perguntas>();  

            List<int> valores= new List<int>();
            for (int i = 0; i < 30; i++)
            {
                int num = random.Next(0, listaperguntas.Count);
               
                if (valores.Count==0)
                {
                    listacomapenas30perguntas.Add(this.listaperguntas[num]);
                    valores.Add(num);   
                }
                else
                {
                    while (valores.Contains(num)==true)
                    {
                        num = random.Next(0, listaperguntas.Count);
                    }
                    listacomapenas30perguntas.Add(this.listaperguntas[num]);
                    valores.Add(num);
                }
            }
            return listacomapenas30perguntas;
        }
        public List<int>  adicionarvaloresnulosalista ()
        {
            List<int> lista = new List<int>();  
            for (int i = 0; i < 30; i++)
            {
                lista.Add(0);
            }
            return lista;
        }
        public List<string> adicionarstringsvaziasalista()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i < 30; i++)
            {
                lista.Add(" ");
            }
            return lista;
        }
        public int corrigirperguntas (List<Perguntas> respostacerta, List<string> respostaescolhida)
        {
            int contador = 0;
            for (int i = 0; i < 30; i++)
            {
                if (respostacerta[i].respostacerta== respostaescolhida[i])
                {
                    contador++;
                }
            }
            return (contador);
        }
}




}
