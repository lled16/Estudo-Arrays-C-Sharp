using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // var meuArray = new int[5];
            // meuArray[0] = 1; // posso inserir dados no array dessa forma

            // var meuArray2 = new int[5] { 1, 2, 3, 4, 5 }; // posso inserir dados no array dessa forma também

            // Console.WriteLine(meuArray[2]);

            // Console.WriteLine(meuArray2[0]);
            // Console.WriteLine(meuArray2[1]);
            // Console.WriteLine(meuArray2[2]);
            // Console.WriteLine(meuArray2[4]);


            // ------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Como percorrer um array

            // for (var index = 0; index < meuArray2.Length; index++) // vai me retornar a quantidade de espaços no meu array
            // {
            //     Console.WriteLine(meuArray2[index]);        // aqui exibo
            // }





            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //  Como percorrer um array com FOREACH

            // PRIMEIRA FORMA
            // foreach (var item in meuArray2)
            // {
            //     Console.WriteLine(item);
            // }



            // SE O ARRAY FOSSE UMA STRUCT :

            //         var funcionarios = new Funcionario[5];
            //         funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" }; // inicializando o array


            //         foreach (var funcionario in funcionarios)
            //         {
            //             Console.WriteLine(funcionario.Id);
            //             Console.WriteLine(funcionario.Nome);
            //         }

            //     }
            // }

            // public struct Funcionario
            // {
            //     public int Id { get; set; }

            //     public string Nome { get; set; }
            // }



            // COMO ALTERAR VALORES OU COPIAR

            var primeiro = new int[4];
            var segundo = new int[4];

            segundo[0] = primeiro[0];

            primeiro[0] = 23;

            Console.WriteLine(segundo[0]);

        }
    }
}

