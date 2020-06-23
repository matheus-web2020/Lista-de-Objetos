using System;
using System.Collections.Generic;

namespace Lista_de_ObjetosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista produto criada
            List<Produto> produtos = new List<Produto>();

            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTv LG";
            produto1.Preco = 2099.99f; 

            produtos.Add(produto1);  

            produtos.Add( new Produto(2, "Geladeira Eletrolux", 3099.99f));          
            produtos.Add( new Produto(3, "Micro ondas", 2100.00f));          
            produtos.Add( new Produto(4, "Fogão Eletrolux", 1500.00f));          
            produtos.Add( new Produto(5, "Máquina de Lavar", 3000.00f));          
            produtos.Add( new Produto(6, "Xbox series X", 13099.99f));          
            produtos.Add( new Produto(7, "PS5", 13099.99f));

            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{item.Preco} - {item.Nome}");
                Console.ResetColor();
            }

              produtos.Remove(produto1); 

              produtos.RemoveAt(4);

              produtos.RemoveAll(y => y.Nome == "Microondas");

            // Varremos nossa lista depois que foi alterada
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine( $"R$ {item.Preco} - {item.Nome} " );
                Console.ResetColor();
            }


            List<Cartao> cartoes = new List<Cartao>();

            Cartao card = new Cartao();
            card.Titular = "Matheus";
            card.Bandeira = "MasterCard";
            card.CVV = 321;
            card.Numero = 0987654321;
            card.Vencimento = "09/25";

            cartoes.Add(card);

            cartoes.Add(new Cartao("Matheus", 123456789, "Mastercard", "07/22", 123));
            cartoes.Add(new Cartao("Carlos", 987654321, "Visa", "07/20", 456));
            cartoes.Add(new Cartao("Paulo", 246813579, "Elo", "07/22", 789));
            cartoes.Add(new Cartao("Maria", 135792468, "HiperCard", "07/22", 012));
            cartoes.Add(new Cartao("Amanda", 123789456, "Cielo", "07/22", 345));
            cartoes.Add(new Cartao("Carla", 456123789, "Hiper", "07/22", 678));


            foreach(Cartao objeto in cartoes){
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"O nome do titular é {objeto.Titular}; O número de seu cartão é {objeto.Numero}; A bandeira de seu cartão é {objeto.Bandeira}; A data de vencimento do Cartão do {objeto.Titular} é {objeto.Vencimento}; O número do CVV é {objeto.CVV}");
                Console.ResetColor();
            }

            cartoes.Remove(card);

            cartoes.RemoveAll(y => y.Bandeira == "Elo");

            foreach(Cartao objeto in cartoes){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O nome do titular é {objeto.Titular}; O número de seu cartão é {objeto.Numero}; A bandeira de seu cartão é {objeto.Bandeira}; A data de vencimento do Cartão do {objeto.Titular} é {objeto.Vencimento}; O número do CVV é {objeto.CVV}");
                Console.ResetColor();
            }

        }
    }
}
