using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Initial greeting and game ready dialogue
            string greeting = "Hello Survivor! Are you ready? ";
            string gameReady = "Welcome to the Graveyard";
            string gameNotReady = "Goodbye";

            bool gameStart = false;
            Console.WriteLine(greeting + gameStart);
            Console.WriteLine("Press 1. for Ready");
            Console.WriteLine("Press 2. to Leave");
            char input = Console.ReadKey().KeyChar;

            if (input == '1') ;
            {
                Console.WriteLine("\n" + gameReady);


            }

            
            else if (input == '2') ;
            {
                Console.WriteLine("\n" + gameNotReady);



            }

            



        }
    }
}
