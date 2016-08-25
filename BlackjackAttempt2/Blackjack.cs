using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackjackAttempt2
{
	class Blackjack
	{
		public static bool started = false;
		static void Main(string[] args)
		{
			var start = "start";
			var hit = "hit";
			var stand = "stand";
			var help = "help";
			var quit = "quit";
			var command = "";
			var notStarted = "You haven't started a hand yet!\n";

			Console.WriteLine("Welcome to the Casino!\n"
							  + "Commands are currently:\n"
							  + "Start -- Hit -- Stand -- Quit -- Help\n");
			while (true)
			{
				Console.Write("Enter command: ");
				command = Console.ReadLine().ToLower();

				if (command == start)
				{
					Hand.methodHand();
					Console.WriteLine(	"Dealer: "
										+ Hand.card1 + " "
										+ Hand.card2 + " ("
										+ Hand.dealerHand + ")\n"
										+ "You: "
										+ Hand.card3 + " "
										+ Hand.card4 + " ("
										+ Hand.playerHand + ")\n");
					started = true;
					if (Hand.dealerHand >= 17
						&& Hand.playerHand > Hand.dealerHand)
					{
						Console.WriteLine("You win!\n");
						started = false;
					}
				}

				if (command == hit)
				{
					if (started == true)
					{
						Hit.methodHit();
					}
					else
					{
						Console.WriteLine(notStarted);
						continue;
					}
				}

				if (command == stand)
				{
					if (started == true)
					{
						Stand.methodStand();
					}
					else
					{
						Console.WriteLine(notStarted);
						continue;
					}
				}

				if (command == help)
				{
					Console.WriteLine(	"\nCommands are currently:\n"
										+ "Start -- Hit -- Stand -- Quit -- Help\n");
				}

				if (command == quit)
				{
					Console.WriteLine("\nBye!");
					Thread.Sleep(1000);
					Console.Write("Idiot.");
					break;
				}

				if (command != start &&
					command != hit &&
					command != stand &&
					command != help &&
					command != quit)
				{
					Console.WriteLine("Invalid command, idiot.\n");
				}
			}
		}
	}
}
