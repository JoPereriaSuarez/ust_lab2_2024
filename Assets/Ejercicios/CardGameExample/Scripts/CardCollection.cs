using System;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Example.CardGame
{
	[SerializeField]
	public class CardCollection
	{
		[SerializeField] private int maxAmount;
		public int MaxAmount => maxAmount;
		[SerializeField] private List<Card> cards = new();

		public void SetMaxAmount(int value)
		{
			if (value < 0)
				return;

			maxAmount = value;
		}
		public Card[] GetCards()
		{
			// Since the cards should not be modified by other classes, is better to create a Copy for reading
			Card[] result = new Card[cards.Count];
			cards.CopyTo(result);
			return result;
		}

		public void Shuffle()
		{
			// Performs Fisher-Yates shuffle. https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
			int amount = cards.Count;
			Card[] shuffledList = new Card[amount];
			int amountShuffled = 0;
			// System.Random works better when using on a loop
			Random random = new();
            
			while (amountShuffled < amount)
			{
				int index = random.Next(0, cards.Count);
				shuffledList[amountShuffled] = cards[index];
				cards.RemoveAt(index);
				// Adjust the capacity and count to the actual cards count
				// Sometimes this value doesn't update on loops so is better being explicit here
				cards.TrimExcess();
				amountShuffled++;
			}

			// This may cause performance issues, but it works for now
			cards = new (shuffledList);
		}

		public Card[] RemoveCards(int amount)
		{
			if (amount < 0 || amount >= cards.Count)
			{
				Debug.Log($"Cannot get {amount} is less than 0 or greater than this collection ({cards.Count})");
				return Array.Empty<Card>();
			}

			Card[] result = cards.GetRange(0, amount).ToArray();
			cards.RemoveRange(0, amount);
			cards.TrimExcess();
			return result;
		}

		/// <summary>
		/// Returns the amount of cards not added due to passing the collection's limit
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public int AddCards(Card[] cards)
		{
			for (int i = 0; i < cards.Length; i++)
			{
				if (cards[i] == null)
					continue;

				if (this.cards.Count >= maxAmount)
					return cards.Length - i;
                
				this.cards.Add(cards[i]);
			}

			return 0;
		}
        
	}
}