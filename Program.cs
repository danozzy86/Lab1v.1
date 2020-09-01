using System;
/*Programming 1 Lab 1 Tic-Tac-Toe
  Due @ 9/3 start of class
  Daniel Osborne - osborndl@alfredstate.edu
  Github - danozzy86
*/
namespace Lab1v._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //intialize posistion array and player arrays
            int[] posArray = {1,2,3,4,5,6,7,8,9};
            int[] playerOne = {};
            int[] playerTwo = {};

            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("RULES:");
            Console.WriteLine("2 Players are required for Tic-Tac-Toe.");
            Console.WriteLine("You and another player will choose spaces on the board.");
            Console.WriteLine("The goal is to get 3 posistions in a row either horizontally,");
            Console.WriteLine("vertically, or diagonally. The first to do this wins.");
            Console.WriteLine("If no spaces are left and the goal is not met, the game");
            Console.WriteLine("will end in a draw.");
            Console.WriteLine();
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("What is player 1's name?");
            string nameP1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What is player 2's name?");
            string nameP2 = Console.ReadLine();
            Console.Clear();

        

        }
    }
}
