using System;

class GameSuite
{
	    static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choice;
        static int flag = 0;
	static void Main(string[] args)
	{
		bool running = true;
		while (running)
		{
			Console.Clear();
			Console.WriteLine("--- MULTI-GAME CONSOLE SUITE ---");
			Console.WriteLine("1. Naughts and Crosses (PvP)");
			Console.WriteLine("2. Rock, Paper, Scissors (PvC)");
			Console.WriteLine("3. Exit");
			Console.Write("\nSelect an option: ");
			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					PlayNC();
					break;
				case "2":
					PlayRPS();
					break;
				case "3":
					running = false;
					break;
				default:
					Console.WriteLine("Invalid selection. Press any key to try again.");
					Console.ReadKey();
					break;
			}
		}
	}
	
	

	static void PlayNC()
	{	

		bool runningNC = true;
		while (runningNC) {
		Console.WriteLine("---Naughts and Crosses---");	
		Console.WriteLine("Player 1 - X, Player 2 - O");

			Console.WriteLine("	     |     |      ");
            Console.WriteLine("	  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("	_____|_____|_____ ");
            Console.WriteLine("	     |     |      ");
            Console.WriteLine("	  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("	_____|_____|_____ ");
            Console.WriteLine("	     |     |      ");
            Console.WriteLine("	  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("	     |     |      ");
		
				}
		
		
	}
	static Random rand = new Random();
	static void PlayRPS()
	{	Console.Clear();
		bool runningNC = true;
		while (runningNC) {
		Console.WriteLine("---Rock Paper Scissors---");	
			
					


	
		while (true) {
			int userInput;
			Console.WriteLine("Press 1 for Rock, 2 for Paper, and 3 for scissors");
			int.TryParse(Console.ReadLine(), out userInput);

			Console.WriteLine($"The player chose {userInput}");
			int computerInput = randomNumberGenerator();
			Console.WriteLine($"The computer chose {computerInput}");

			if (computerInput == userInput) 
			{
				Console.WriteLine("It's a draw!");

			}
			else if (computerInput == 1 && userInput == 2) 
			{
				Console.WriteLine("You win!");
			} else if (computerInput == 2 && userInput == 1) 
			{
				Console.WriteLine("You lose!");	
			} else if (computerInput == 3 && userInput == 1) 
			{
				Console.WriteLine("You win!");

			} else if (computerInput == 1 && userInput == 3) 
			{
				Console.WriteLine("You lose!");

			} else if (computerInput == 2 && userInput == 3) 
			{
				Console.WriteLine("You win!");

			} else if (computerInput == 3 && userInput == 2) 
			{	
				Console.WriteLine("You lose!");
			} else {
				Console.WriteLine("Invalid input, try again.");
			}
		}
		}
	}
	private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (board[1] == board[2] && board[2] == board[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (board[4] == board[5] && board[5] == board[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (board[6] == board[7] && board[7] == board[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (board[1] == board[4] && board[4] == board[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (board[2] == board[5] && board[5] == board[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (board[3] == board[6] && board[6] == board[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (board[1] == board[5] && board[5] == board[9])
            {
                return 1;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4' && board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
	 
	static int randomNumberGenerator() {
		int randomValue = rand.Next(1, 4);
		return randomValue;
		}
	}


