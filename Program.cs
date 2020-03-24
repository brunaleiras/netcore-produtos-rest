using System;
using netcore.produtos.model;
using Newtonsoft.Json;

namespace netcore.produtos.rest
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();

            produto.Nome = "livro de Ingles Vol 1";
            produto.Quantidade = 2;
            produto.Valor = 29.65F;

            string json = JsonConvert.SerializeObject(produto);

            Console.WriteLine(json);
        }
    }


}
