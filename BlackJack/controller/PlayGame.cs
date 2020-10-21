
using System.Collections.Generic;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame : model.IObserver
    {
        private view.IView m_view;
        private model.Game m_game;

        public PlayGame(view.IView a_view, model.Game a_game)
        {
            m_view = a_view;
            m_game = a_game;
            m_game.AddSubscribers(this);
        }
        public void CardReceived()
        {

            m_view.DisplayWelcomeMessage();
            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());
            System.Threading.Thread.Sleep(1000);
        }

        public bool Play()
        {
            m_view.DisplayWelcomeMessage();
            m_view.DisplayDealerHand(m_game.GetDealerHand(), m_game.GetDealerScore());
            m_view.DisplayPlayerHand(m_game.GetPlayerHand(), m_game.GetPlayerScore());

            if (m_game.IsGameOver())
            {
                m_view.DisplayGameOver(m_game.IsDealerWinner());
            }
            Input input = m_view.GetInput();

            switch (input)
            {
                case Input.Play:
                    m_game.NewGame();
                    break;
                case Input.Hit:
                    m_game.Hit();
                    break;
                case Input.Stand:
                    m_game.Stand();
                    break;
                case Input.Quit:
                    return false;
            }

            return true;
        }
    }
}
