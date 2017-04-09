using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class DeckOfCards : Card
    {
        const int NUM_OF_CARDS = 52;
        Card[] deck;

        private Card[] playerHand; 
        Card[] computerHand = new Card[5];



        public DeckOfCards()
        {
            deck = new Card[NUM_OF_CARDS];
            playerHand = new Card[5];

            DrawCard.Player();
            DrawCard.Computer();

            Deck();
            DealCards();
            DisplayCards();

            HandRank rank = new HandRank();
            rank.FourOfAKind();
            Console.ReadKey();
        }

        public Card[] PlayerHand
        {
            get { return playerHand; }
        }

        private void Deck()
        {
            int i = 0;
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    deck[i] = new Card { MySuit = suit, MyValue = value };
                    i++;
                }
            }

        }

        private void ShuffleCards()
        {
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < NUM_OF_CARDS; j++)
                {
                    int secondCardIndex = random.Next(0, NUM_OF_CARDS);
                    Card temp = deck[j];
                    deck[j] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }

        private void DealCards()
        {
            ShuffleCards();

            int playerHandIndex = 0;
            int computerHandIndex = 0;

            for (int i = 0; i < deck.Length; i++)
            {
                playerHand[playerHandIndex] = deck[i];
                if (i == 4)
                    break;
                playerHandIndex++;
            }
            for (int i = 5; i < deck.Length; i++)
            {
                computerHand[computerHandIndex] = deck[i];
                if (i == 9)
                    break;
                computerHandIndex++;
            }
        }

        private void DisplayCards()
        {
            char suit = ' ';
            for (int i = 0; i < playerHand.Length; i++)
            {
                switch(playerHand[i].MySuit.ToString())
                {
                    case "Heart":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 5);
                        break;
                    case "Diamond":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 5);
                        break;
                    case "Spades":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 5);
                        break;
                    case "Club":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 5);
                        break;
                }
                DrawCard.WriteAt(playerHand[i].MyValue.ToString(), 20 * i + 5, 6);
            }

            for (int i = 0; i < computerHand.Length; i++)
            {
                switch (computerHand[i].MySuit.ToString())
                {
                    case "Heart":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 3 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 17);
                        break;
                    case "Diamond":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 4 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 17);
                        break;
                    case "Spades":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 5 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 17);
                        break;
                    case "Club":
                        suit = Encoding.GetEncoding(437).GetChars(new byte[] { 6 })[0];
                        DrawCard.WriteAt(suit, 20 * i + 6, 17);
                        break;
                }
                DrawCard.WriteAt(computerHand[i].MyValue.ToString(), 20 * i + 5, 18);
            }
        }
    }
}
