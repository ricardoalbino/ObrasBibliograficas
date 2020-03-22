using ObrasBibliográficas.Enum;
using ObrasBibliográficas.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObrasBibliográficas.Domain
{
    public class ListaDeAutores
    {
        public static string[] ListaAutoresDeLivros()
        {
            string[] autores = new string[17]
            {
                "Ricardo Albino",
                "Valquíria Vicente Albino",
                "João Cabral de Melo Neto",
                 "Paulo Coelho de Souza",
                 "Jorge Leal Amado de Faria",
                 "Joaquim Maria Machado de Assis",
                 "Clarice Lispector",
                 "João Guimarães Rosa",
                 "Mário Raul Morais de Andrade",
                 "Rachel de Queiroz",
                 "José Arnaldo Guimarães Filho",
                 "Fabio Paulo Albino",
                 "Simon Albino Sobrinho",
                 "Bryan Albnio Junior",
                 "Maria de Fatima Carvalho Albino",
                 "Julia Albino Filha",
                 "Nicole de Souza Sobrinha"

             };

            return autores;
        }

        public static List<string> NomeDeNomesDesAutoresFormatado()
        {
            string resultadoFinal = "";
            string autor = "";


            var sobreNome = "";
            var nomeComun = "";

            List<string> impressao = new List<string>();

            for (int j = 0; j < ListaDeAutores.ListaAutoresDeLivros().Length; j++)
            {

                autor = ListaDeAutores.ListaAutoresDeLivros()[j];

                var arr = autor.Split(' ');

                if (autor.Trim() == "") autor = ""; 

                string nomeCompletoRetornado = autor;

                for (int i = 0; i < arr.Length; i++)
                {
                    sobreNome = arr[i];

                    if (sobreNome == PalavrasComum.Filho.ToString() || sobreNome == PalavrasComum.Filha.ToString() ||
                        sobreNome == PalavrasComum.Neto.ToString() || sobreNome == PalavrasComum.Neta.ToString() ||
                        sobreNome == PalavrasComum.Sobrinho.ToString() || sobreNome == PalavrasComum.Sobrinha.ToString() ||
                        sobreNome == PalavrasComum.Junior.ToString()
                        )
                    {
                       
                        nomeComun = arr[i - 1];

                    }
                }
        
                if (nomeComun != "")
                {
                    resultadoFinal = nomeComun.ToUpper() + " " + sobreNome.ToUpper() + ", " + nomeCompletoRetornado.Replace(nomeComun, " ").Replace(sobreNome, " ");
                    nomeComun = "";
                }

                else if (nomeCompletoRetornado == sobreNome)
                {
                    resultadoFinal = sobreNome.ToUpper() + nomeCompletoRetornado.Replace(sobreNome, " ");

                }
                else
                {
                    resultadoFinal = sobreNome.ToUpper() + ", " + nomeCompletoRetornado.Replace(sobreNome, " ");
                }


                impressao.Add(resultadoFinal);

            }

            return impressao;
        }


        //USUARIO DIGITA UM  NOME  DE  AUTOR E O SOFTWARE IMPRIME O NOME  FORMATADO
        public static string DigiteNomeAutore(string autor)
        {

            var arr = autor.Split(' ');


            var sobreNome = "";
            var nomeComun = "";

            if (autor.Trim() == "") return "";
            string nomeCompletoRetornado = autor;

            for (int i = 0; i < arr.Length; i++)
            {
                sobreNome = arr[i];

                if (sobreNome == PalavrasComum.Filho.ToString() || sobreNome == PalavrasComum.Filha.ToString() ||
                    sobreNome == PalavrasComum.Neto.ToString() || sobreNome == PalavrasComum.Neta.ToString() ||
                    sobreNome == PalavrasComum.Sobrinho.ToString() || sobreNome == PalavrasComum.Sobrinha.ToString() ||
                    sobreNome == PalavrasComum.Junior.ToString()
                    )
                {
                    nomeComun = arr[i - 1];

                    return nomeComun.ToUpper() + " " + sobreNome.ToUpper() + "," + nomeCompletoRetornado.Replace(nomeComun, " ").Replace(sobreNome, "");
                }
            }

            if (nomeCompletoRetornado == sobreNome)
            {
                return sobreNome.ToUpper() + nomeCompletoRetornado.Replace(sobreNome, " ");
            }
            else
            {
                return sobreNome.ToUpper() + "," + nomeCompletoRetornado.Replace(sobreNome, " ");
            }

        }

    }

}

 
       
