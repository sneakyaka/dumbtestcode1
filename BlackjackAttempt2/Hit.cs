using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackAttempt2
{
	class Hit
	{
		public static void methodHit()
		{
			int hitCard;
			Random card = new Random();
			hitCard = card.Next(1, 14);
			if (hitCard >= 11)
			{
				hitCard = 10;
			}
			Hand.playerHand += hitCard;
			Console.WriteLine(	"Dealer: "
								+ Hand.dealerHand + "\n"
								+ "You: "
								+ hitCard + " ("
								+ Hand.playerHand + ")\n");
			if (Hand.playerHand > 21)
			{
				Bust.methodBust();
			}
			if (Hand.playerHand == 21)
			{
				Console.WriteLine("Blackjack! You win!\n");
				Blackjack.started = false;
			}
			if (Hand.dealerHand >=17 &&
				Hand.playerHand > Hand.dealerHand &&
				Hand.playerHand <22)
			{
				Console.WriteLine("You win!");
				Blackjack.started = false;
			}
		}
	}
}
