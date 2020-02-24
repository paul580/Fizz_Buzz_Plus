using System;



namespace Fizz_Buzz__

{

    class Program

    {

        static void Main(string[] args)

        {

             for(int Numero = 1; Numero < 100; Numero++)

            {

                

                

                 if((Numero % 3) == 0 )

                 Console.Write("Fizz");

            

                 else

                  if((Numero % 5) == 0 )

                  Console.Write("Buzz");

                  

                  else

                   Console.WriteLine(Numero);

            }

        }

    }

}