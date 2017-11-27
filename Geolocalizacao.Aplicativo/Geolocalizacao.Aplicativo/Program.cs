using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geolocalizacao.Amigo;
using Geolocalizacao.Core;

namespace Geolocalizacao.Aplicativo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Iniciando a aplicação.");

                //Obtém insumos de dados a ser processado
                var amigos = InsumoDados();

                //Efetua o cálculo de distância entre os amigos
                Core.Geolocalizacao calc = new Core.Geolocalizacao();
                var ret = calc.CalcularDistancia(amigos);

                //Efetua o print dos resultados
                foreach (var item in ret)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nAmigos próximos à {item.Key.nome}:");

                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var subitem in item.Value.OrderBy(x => x.Value).Take(3))
                    {
                        Console.WriteLine($"Nome: {subitem.Key.nome} - distância: {string.Format("{0:0.00}", subitem.Value)} Metros");
                    }
                }                
            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Ocorreu um erro: {ex.Message}");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nFinal da aplicação.");
            Console.Read();
        }

        /// <summary>
        /// Obtém insumo de dados a ser processado
        /// </summary>
        /// <returns></returns>
        private static List<Pessoa> InsumoDados()
        {
            return new List<Pessoa>
            {
                new Pessoa { id = 1, nome = "João da Silva", endereco = "Rua Bell Aliance, 225 - Jardim São Caetano, São Caetano do Sul", latitude = -23.6377431, longitude = -46.5810721 },
                new Pessoa { id = 2, nome = "José de Andrade", endereco = "Rua Bell Aliance, 149 - Jardim Sao Caetano, São Caetano do Sul", latitude = -23.6374845, longitude = -46.5800625 },
                new Pessoa { id = 3, nome = "Maria de Jesus", endereco = "Av. do Taboão, 3550 - Taboão, São Bernardo do Campo", latitude = -23.6608575, longitude = -46.6075766 },
                new Pessoa { id = 4, nome = "Mario da Costa", endereco = "R. Alm. Protógenes, 290 - Jardim, Santo André", latitude = -23.6506483, longitude = -46.5376771 },
                new Pessoa { id = 5, nome = "Eduardo Campos", endereco = "Av. Pereira Barreto, 400 - Baeta Neves, São Bernardo do Campo ", latitude = -23.6953344, longitude = -46.5515043 },
                new Pessoa { id = 6, nome = "Juliana Pereira", endereco = "R. Guatemala, 19 - Jardim Canhema, Diadema", latitude = -23.6792416, longitude = -46.6126649 },
                new Pessoa { id = 7, nome = "Jaqueline Montenegro", endereco = "Av. Paulista, 1009 - Bela Vista, São Paulo", latitude = -23.5653348, longitude = -46.7224448 },
                new Pessoa { id = 8, nome = "Maria da Penha", endereco = "R. João Meneghel, 233 - Rudge Ramos, São Bernardo do Campo", latitude = -23.6615519, longitude = -46.5749726 },
            };       
        }
    }
}
