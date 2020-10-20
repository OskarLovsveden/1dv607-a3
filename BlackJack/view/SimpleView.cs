using System;
using System.Collections.Generic;

namespace BlackJack.view
{
    class SimpleView : IView
    {
        private const char _playChar = 'p';
        private const char _hitChar = 'h';
        private const char _standChar = 's';
        private const char _quitChar = 'q';

        public void DisplayWelcomeMessage()
        {
            System.Console.Clear();
            System.Console.WriteLine("Hello Black Jack World");
            System.Console.WriteLine("Type '{0}' to Play, '{1}' to Hit, '{2}' to Stand or '{3}' to Quit\n", _playChar, _hitChar, _standChar, _quitChar);
        }

        public Input GetInput()
        {
            char c = System.Console.ReadKey(true).KeyChar;

            switch (c)
            {
                case _playChar:
                    return Input.Play;
                case _hitChar:
                    return Input.Hit;
                case _standChar:
                    return Input.Stand;
                case _quitChar:
                    return Input.Quit;
                default:
                    return Input.Default;
            }
        }

        public void DisplayCard(model.Card a_card)
        {
            System.Console.WriteLine("{0} of {1}", a_card.GetValue(), a_card.GetColor());
        }

        public void DisplayPlayerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Player", a_hand, a_score);
        }

        public void DisplayDealerHand(IEnumerable<model.Card> a_hand, int a_score)
        {
            DisplayHand("Dealer", a_hand, a_score);
        }

        private void DisplayHand(String a_name, IEnumerable<model.Card> a_hand, int a_score)
        {
            System.Console.WriteLine("{0} Has: ", a_name);
            foreach (model.Card c in a_hand)
            {
                DisplayCard(c);
            }
            System.Console.WriteLine("Score: {0}", a_score);
            System.Console.WriteLine("");
        }

        public void DisplayGameOver(bool a_dealerIsWinner)
        {
            System.Console.Write("GameOver: ");
            if (a_dealerIsWinner)
            {
                System.Console.WriteLine("Dealer Won!");
            }
            else
            {
                System.Console.WriteLine("You Won!");
            }

        }
    }
}
