using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackAttempt2
{
	class Hand
	{
		public static int	card1,
							card2,
							card3,
							card4;
		public static int dealerHand;
		public static int playerHand;

		public static void methodHand()
		{
			Random card = new Random();
			card1 = card.Next(1, 14);
			card2 = card.Next(1, 14);
			card3 = card.Next(1, 14);
			card4 = card.Next(1, 14);

			if (card1 >= 11)
			{
				card1 = 10;
			}
			if (card2 >= 11)
			{
				card2 = 10;
			}
			if (card3 >= 11)
			{
				card3 = 10;
			}
			if (card4 >= 11)
			{
				card4 = 10;
			}
			dealerHand = card1 + card2;
			playerHand = card3 + card4;
		}
	}
}
