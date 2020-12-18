using System;
using System.Collections;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = { "Notebook", "Carregador Portátil", "Pendrive", "TV Box" };
            string p;
            string taxa = "8.50";
            double valorProduto;
            double totalPagar;

            Console.WriteLine("Loja RS");
            Console.WriteLine("Produtos:");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("| Código       | Produtos:            ");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < produtos.Length; i++)
            {
                Console.WriteLine("| " + (i + 1) + "            | " + produtos[i]);
            }
            Console.WriteLine("--------------------------------------");
            Console.Write("Digite o código do produto desejado: ");
            int codigo = int.Parse(Console.ReadLine());
            switch (codigo)
            {
                case 1:
                    p = produtos[0];
                    Console.Write("O valor do " + p + " é: ");
                    valorProduto = 2500.00;
                    totalPagar = valorProduto + Convert.ToDouble(taxa);
                    Console.WriteLine("R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor com a taxa de entrega é de: R$" + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    confirmar();
                    break;
                case 2:
                    p = produtos[1];
                    Console.Write("O valor do " + p + " é: ");
                    valorProduto = 120.00;
                    totalPagar = valorProduto + Convert.ToDouble(taxa);
                    Console.WriteLine("R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor com a taxa de entrega é de: R$" + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    confirmar();
                    break;
                case 3:
                    p = produtos[2];
                    Console.Write("O valor do " + p + " é: ");
                    valorProduto = 70.00;
                    totalPagar = valorProduto + Convert.ToDouble(taxa);
                    Console.WriteLine("R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor com a taxa de entrega é de: R$" + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    confirmar();
                    break;
                case 4:
                    p = produtos[3];
                    Console.Write("O valor do " + p + " é: ");
                    valorProduto = 260.00;
                    totalPagar = valorProduto + Convert.ToDouble(taxa);
                    Console.WriteLine("R$" + valorProduto.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor com a taxa de entrega é de: R$" + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
                    confirmar();
                    break;
                default:
                    Console.WriteLine("Código inexistente!");
                    break;
            }

            void confirmar()
            {
                Console.Write("Efetuar compra? (s/n): ");
                string resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    Console.WriteLine("Compra de um " + p + " no valor de " + totalPagar + " mais taxa de entrega, foi efetuada com sucesso!");
                    Console.WriteLine("Agradecemos a preferêcia!! Volte sempre!!");
                }
                else
                {
                    Console.WriteLine("Uma pena!! Agradecemos a visita e até a próxima!");
                }
            }
        }
    }
}
