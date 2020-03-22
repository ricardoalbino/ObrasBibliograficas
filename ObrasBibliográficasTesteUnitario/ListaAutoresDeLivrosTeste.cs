using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ObrasBibliográficas.Domain;
using Assert = NUnit.Framework.Assert;

namespace ObrasBibliográficasTesteUnitario
{

    [TestClass]
    public class ListaAutoresDeLivrosTeste
    {

        [Test]
        public void ListaAutoresDeLivrosRetornarNaoOK()
        {
           
            var resultado = "";

            foreach (var item in ListaDeAutores.ListaAutoresDeLivros())
            {
                resultado = item;
            }

            Assert.IsEmpty(resultado, "Retornar Não OK!");

        }

        [Test]
        public void ListaAutoresDeLivrosRetornaOK()
        {

            var resultado = "";

            foreach (var item in ListaDeAutores.ListaAutoresDeLivros())
            {
                resultado = item;
            }

            Assert.IsNotEmpty(resultado, "Retornar OK!");

        }

        [Test]
        public void TamanhoDaListaRetornadaOK()
        {
            int resultado = 0;


            for (int i = 0; i < ListaDeAutores.NomeDeNomesDesAutoresFormatado().Count; i++)
            {
                resultado = i;

                
            }
            Assert.AreEqual(resultado, 16);

        }


        [Test]
        public void TamanhoDaListaRetornadaNaoOK()
        {
            int resultado = 0;


            for (int i = 0; i < ListaDeAutores.NomeDeNomesDesAutoresFormatado().Count; i++)
            {
                resultado = i;


            }
            Assert.AreEqual(resultado, 17);

        }


        [Test]
        public void retornarNomeFormatadoDaListaNaoOK()
        {
            string resultado = "";



            foreach (var item in ListaDeAutores.NomeDeNomesDesAutoresFormatado())
            {
                resultado = item.Trim().Contains("ALBINO, Ricar").ToString();
            }
            Assert.AreEqual(resultado, "False");

        }


        [Test]
        public void retornarNomeFormatadoDaListaOK()
        {
            string resultado = "";



            foreach (var item in ListaDeAutores.NomeDeNomesDesAutoresFormatado())
            {
                resultado = item.Trim().Contains("ALBINO, Valquíria Vicente").ToString();
            }
            Assert.AreEqual(resultado, "True");

        }

    }
}
/*
 

       string[] autores = new string[17]
           {
                 "ALBINO, Ricardo",
                 "ALBINO, Valquíria Vicente",
                 "MELO NETO, João Cabral de",
                 "SOUZA, Paulo Coelho de",
                 "FARIA, Jorge Leal Amado de",
                 "ASSIS, Joaquim Maria Machado de",
                 "LISPECTOR, Clarice",
                 "ROSA, João Guimarães",
                 "ANDRADE, Mário Raul Morais de",
                 "QUEIROZ, Rachel de",
                 "GUIMARÃES FILHO, José Arnaldo",
                 "ALBINO, Fabio Paulo",
                 "ALBINO SOBRINHO, Simon",
                 "ALBNIO JUNIOR, Bryan",
                 "ALBINO, Maria de Fatima Carvalho",
                 "ALBINO FILHA, Julia",
                 "SOUZA SOBRINHA, Nicole de"

            };




     "ALBINO, Ricardo",
     "ALBINO, Valquíria Vicente",
     "MELO NETO, João Cabral de",
     "SOUZA, Paulo Coelho de",
     "FARIA, Jorge Leal Amado de",
     "ASSIS, Joaquim Maria Machado de",
     "LISPECTOR, Clarice",
     "ROSA, João Guimarães",
     "ANDRADE, Mário Raul Morais de",
     "QUEIROZ, Rachel de",
     "GUIMARÃES FILHO, José Arnaldo",
     "ALBINO, Fabio Paulo",
     "ALBINO SOBRINHO, Simon",
     "ALBNIO JUNIOR, Bryan",
     "ALBINO, Maria de Fatima Carvalho",
     "ALBINO FILHA, Julia",
     "SOUZA SOBRINHA, Nicole de"
     */
