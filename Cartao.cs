using System;
namespace Lista_de_ObjetosPOO
{
    public class Cartao
    {
        public string Titular { get; set; }

        public int Numero { get; set; }

        public string Bandeira { get; set; }

        public string Vencimento { get; set; }

        public int CVV { get; set; }

        public Cartao(){

        }

        public Cartao(string _titular, int _numero, string _bandeira, string _Vencimento ,int _cvv){

            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _Vencimento;
            this.CVV = _cvv;

        }
    }
}