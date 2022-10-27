using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Borracha
    {
        private string marca;
        private int peso;
        private string cor;
        private int percentualdaborracha;

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        
        public int Percentualdaborracha
        {
            get { return percentualdaborracha; }
            set { percentualdaborracha = value; }
        }

        public Borracha(string _marca, string _peso, string _cor,int _percentualdaborracha)
        {
            marca = _marca;
            peso = 30;
            cor = _cor;
            percentualdaborracha = 100;
        }

        private void Apagar()
        {
            Console.WriteLine("mensagem apagada");
        }

        private void Gastar()
        {
         percentualdaborracha -=10;
        }

    }
}
        
          
        


