using System;


namespace Ms_Udemy_Course.Section5
{
    public class ConsoleInputLoop
    {

        public ConsoleInputLoop() { }

        public int userInputCounter()
        {
            int acum = 0;
            int flag = 0;



            while (flag == 0)
            {

                Console.WriteLine("Ingrese 1 para continuar , 2 para salir:");
                var userInput = Convert.ToInt32(Console.ReadLine());



                switch (userInput)
                {

                    case 1:
                        Console.WriteLine("Ingrese un valor numerico");
                        var numInput = Convert.ToInt32(Console.ReadLine());
                        acum += numInput;
                        Console.WriteLine("Valor ingresado -> " + numInput + " Total acumulado -> " + acum);
                        break;

                    case 2:
                        Console.WriteLine("Valor total acumulado -> " + acum);
                        flag++;
                        break;

                    default:
                        Console.WriteLine("Valor ingresado invalido ");
                        break;
                }




            }

            return acum;

        }
    }
}
