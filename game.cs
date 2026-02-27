using System;

class GameSuite
{
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
		string[] arr = {"1","2","3",
						  "4","5","6",
							"7","8","9"};
			Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
		
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
			Console.WriteLine("Press 1 for Rock, 2 for Paper, 3 for scissors and 4 to return");
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
				Console.WriteLine("You lose!");

			} else if (computerInput == 1 && userInput == 3) 
			{
				Console.WriteLine("You win!");

			} else if (computerInput == 2 && userInput == 3) 
			{
				Console.WriteLine("You lose!");

			} else if (computerInput == 3 && userInput == 2) 
			{	
				Console.WriteLine("You win!");
			} else if (userInput == 4)
			{
				
			}
			else {
				Console.WriteLine("Invalid input, try again.");
			}
		}
	}
	
	static int randomNumberGenerator() {
		int randomValue = rand.Next(1, 4);
		return randomValue;
	}
}
			
				
			
		}
