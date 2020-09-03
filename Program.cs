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
            //intialize array
            char[] posArr = {'0','1','2','3','4','5','6','7','8','9'};
            int choice;
            int win = 0;
            bool player = true; //true = player1 and false = player2

            //Lists rules for the players and also collects there names to use in the game
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

            Console.WriteLine("Press any key to begin playing Tic-Tac-Toe...");
            Console.ReadKey();

            do
            {
                Console.Clear();
                printBoard(posArr, nameP1, nameP2, player);

                //takes the players choice and converts it to an integer if possible
                choice = int.Parse(Console.ReadLine());

                //Validates the input to make sure the position isn't taken
                if (posArr[choice] != 'X' && posArr[choice] != 'O'){

                    //checks whos turn it is and assigns proper char to array, P1 = X & P2 = O
                    if (player){
                        posArr[choice] = 'X';
                        player = !player;
                    }
                    else {
                        posArr[choice] = 'O';
                        player = !player;
                    }
                }
                //notifies the player that they have chosen a spot already taken or have invalid input *NOT WORKING
                else {
                    Console.WriteLine("Either the position you have chosen has already been marked or you chose an incorrect position");
                    Console.WriteLine("Press any key to retry...");
                }
                win = checkWin(posArr);
            } while (win != 1 && win != -1);

            Console.Clear();
            winBoard(posArr, nameP1, nameP2);

            //Checks to see if a player has won or if there was a draw
            if (win == 1) {
                player = !player;
                if (player){
                    Console.WriteLine("{0} wins!",nameP1);
                }
                else {
                    Console.WriteLine("{0} wins!", nameP2);
                }
            }
            else {
                Console.WriteLine("Nobody wins, there has been a draw :(");
            }
        }

        public static void printBoard(char[] posArr, string nameP1, string nameP2, bool player){
           //Prints the board, showing whos turn it is and the available choices
            string playerTurn = null;

            if (player){
                playerTurn = nameP1;
            }
            else{
                playerTurn = nameP2;
            }
            Console.WriteLine("{0} = X  {1} = O", nameP1, nameP2);
            Console.WriteLine("");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[1], posArr[2], posArr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[4], posArr[5], posArr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[7], posArr[8], posArr[9]);
            Console.WriteLine("     |     |      ");
            Console.WriteLine("");
            Console.WriteLine("{0}'s turn", playerTurn);
        }

        public static void winBoard(char[] posArr, string nameP1, string nameP2){
            Console.WriteLine("{0} = X  {1} = O", nameP1, nameP2);
            Console.WriteLine("");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[1], posArr[2], posArr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[4], posArr[5], posArr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", posArr[7], posArr[8], posArr[9]);
            Console.WriteLine("     |     |      ");
            Console.WriteLine("");
        }

        public static int checkWin(char[] posArr){
            //Checks for horizontal win
            if (posArr[1] == posArr[2] && posArr[2] == posArr[3]){
                return 1;
            }
            else if (posArr[4] == posArr[5] && posArr[5] == posArr[6]){
                return 1;
            }
            else if (posArr[7] == posArr[8] && posArr[8] == posArr[9]){
                return 1;
            }
            //Checks for vertical win
            else if (posArr[1] == posArr[4] && posArr[4] == posArr[7]){
                return 1;
            }
            else if (posArr[2] == posArr[5] && posArr[5] == posArr[8]){
                return 1;
            }
            else if (posArr[3] == posArr[6] && posArr[6] == posArr[9]){
                return 1;
            }
            //Checks for diagonal win
            else if (posArr[1] == posArr[5] && posArr[5] == posArr[9]){
                return 1;
            }
            else if (posArr[3] == posArr[5] && posArr[5] == posArr[7]){
                return 1;
            }
            //Checks to see if all of the places have been chosen to determine if there is a draw
            else if (posArr[1] != '1' && posArr[2] != '2' && posArr[3] != '3' && posArr[4] != '4' && posArr[5] != '5' && posArr[6] != '6' && posArr[7] != '7' && posArr[8] != '8' && posArr[9] != '9'){
                return -1;
            }
            else {
                return 0;
            }
            
        }
    }
}