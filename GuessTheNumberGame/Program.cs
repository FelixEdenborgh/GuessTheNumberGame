using System;
using System.Security.Cryptography;


// this program are going to be about an guessing game, there you guess 1-10 and if you are right then you win.
// you will also have 5 chanses to guess right

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this game!");
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int choice;
            string val;
            int counter = 10;
            bool playagain = true;
            string player = null;
            char ch;

            while (playagain == true)
            {

            

                Console.WriteLine("Guess the number 1-100: ");
                val = Console.ReadLine();
                while (true)
                {
                    
                    choice = Convert.ToInt32(val);

                    counter --;


                    if (counter == 10)
                    {
                        Console.WriteLine("You lose!, The number was: " + randomNumber);
                        Console.WriteLine("Do you wonna play again?: y/n");
                        ch = Console.ReadLine()[0];
                        player = ch.ToString();

                        if (player == "y")
                        {
                            Console.Clear();
                            playagain = true;
                            break;

                        }
                        else if (player == "n")
                        {
                            playagain = false;
                            break;
                        }


                    }
                    else if (counter < 10)
                    {
                        Console.WriteLine("You have " + counter + " Chanses left");
                    }


                    if (choice == randomNumber)
                    {
                        Console.WriteLine("WINNER!");
                        Console.WriteLine("Do you wonna play again?: y/n");
                        ch = Console.ReadLine()[0];
                        player = ch.ToString();

                        if (player == "y")
                        {
                            Console.Clear();
                            playagain = true;
                            break;

                        }
                        else if (player == "n")
                        {
                            playagain = false;
                            break;
                        }
                    }
                    else if (choice < randomNumber)
                    {
                        Console.WriteLine("to Cold!");
                        Console.WriteLine("Try again!");
                        Console.WriteLine("Number: ");
                        val = Console.ReadLine();
                    }
                    else if (choice > randomNumber)
                    {
                        Console.WriteLine("To Warm!");
                        Console.WriteLine("Try again!");
                        Console.WriteLine("Number: ");
                        val = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Something is wrong.");
                    }

                    

                }
            }


        }

        
    }
}
