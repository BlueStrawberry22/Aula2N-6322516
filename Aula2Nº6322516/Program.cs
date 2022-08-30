using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2Nº6322516
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração e instanciação dos objetos
            Filme fi = new Filme();
            Entrada en=new Entrada();
           

            Console.Write("Título do filme: ");
            fi.SetTitulo(Console.ReadLine());
            Console.Write("Sinopse: ");
            fi.SetSinopse(Console.ReadLine());
            Console.Write("Gênero: ");
            fi.SetGenero(Console.ReadLine());
            Console.Write("Classificação indicativa: ");
            fi.SetClassificacao(Convert.ToInt32(Console.ReadLine()));

            Console.Write("\nValor: ");
            en.SetValor(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Poltrona: ");
            en.SetPoltrona(Console.ReadLine());
            Console.Write("Ano: ");
            en.SetAno(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Mês: ");
            en.SetMes(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Dia: ");
            en.SetDia(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Hora: ");
            en.SetHora(Console.ReadLine());

            Console.WriteLine("\nDados do filme");
            Console.WriteLine("Título: " + fi.GetTitulo() + "\nSinopse: " + fi.GetSinopse() + "\nGênero: " + fi.GetGenero() + 
            "\nClassificação indicativa: " + fi.GetClassificacao());
            Console.WriteLine("Valor: " + en.GetValor().ToString("C") + "\nPoltrona: " + en.GetPoltrona() + "\nData: " +
            en.GetDia() + "/" + en.GetMes() + "/" + en.GetAno() + "\nHora: " + en.GetHora());
            
            Console.ReadKey();
        }
    }
}
