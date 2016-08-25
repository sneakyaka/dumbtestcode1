using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlackjackAttempt2
{
	class Stand
	{
		public static void methodStand()
		{
			int hitCard;
			while (Hand.dealerHand < 17)
			{
				Thread.Sleep(50);
				Random card = new Random();
				hitCard = card.Next(1, 14);
				if (hitCard >= 11)
				{
					hitCard = 10;
				}
				Hand.dealerHand += hitCard;
				Console.WriteLine("Dealer hits " + hitCard
									+ " \n" + Hand.dealerHand
									+ " (You: " + Hand.playerHand + ")\n");
			}
			if (Hand.dealerHand >= 17 && Hand.dealerHand <= 21)
			{
				if (Hand.dealerHand > Hand.playerHand)
				{
					Console.WriteLine("You lose!\n");
					Blackjack.started = false;
				}
				if (Hand.dealerHand == Hand.playerHand)
				{
					Console.WriteLine("\nPushed\n");
					Blackjack.started = false;
				}
				if (Hand.playerHand > Hand.dealerHand)
				{
					Console.WriteLine("You win!\n");
					Blackjack.started = false;
				}
			}
			if (Hand.dealerHand > 21)
			{
				Console.WriteLine("Dealer busts! You win!\n");
				Blackjack.started = false;
			}
		}
	}
}
