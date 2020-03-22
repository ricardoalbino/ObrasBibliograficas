using ObrasBibliográficas.Domain;
using System;

namespace ObrasBibliográficas
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("| ---------------------------------------|");
            Console.WriteLine("|    AUTORES DE  LIVROS  BRASILEIROS     |");
            
            foreach (var item in ListaDeAutores.NomeDeNomesDesAutoresFormatado())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("| ---------------------------------------|");
                Console.WriteLine("|Autor: " +item+  "                     ");
                
            }
            Console.WriteLine("| ---------------------------------------|");

            Console.ReadKey();
        }
    }
}
