using System.Linq;

namespace BlackJack.model
{
    class Dealer : Player
    {
        private Deck m_deck = null;
        private const int g_maxScore = 21;

        private rules.INewGameStrategy m_newGameRule;
        private rules.IHitStrategy m_hitRule;
        private rules.IWinConditionStrategy m_winConditionRule;

        public Dealer(rules.RulesFactory a_rulesFactory)
        {
            m_newGameRule = a_rulesFactory.GetNewGameRule();
            m_hitRule = a_rulesFactory.GetHitRule();
            m_winConditionRule = a_rulesFactory.GetWinConditionRule();
        }

        public bool NewGame(Player a_player)
        {
            if (m_deck == null || IsGameOver(a_player))
            {
                m_deck = new Deck();
                ClearHand();
                a_player.ClearHand();
                return m_newGameRule.NewGame(this, a_player);
            }
            return false;
        }

        public bool Hit(Player a_player)
        {
            if (m_deck != null && a_player.CalcScore() < g_maxScore && !IsGameOver(a_player))
            {
                DealCard(a_player, true);
                return true;
            }
            return false;
        }

        public void DealCard(Player a_player, bool shouldShow)
        {
            Card c;
            c = m_deck.GetCard();
            c.Show(shouldShow);
            a_player.ReceiveCard(c);
        }

        public bool Stand()
        {
            if (m_deck != null)
            {
                ShowHand();

                while (m_hitRule.DoHit(this))
                {
                    DealCard(this, true);
                }
            }

            return true;
        }

        public bool IsDealerWinner(Player a_player)
        {
            return m_winConditionRule.HasWon(this, a_player, g_maxScore);
        }

        public bool IsGameOver(Player a_player)
        {
            if (m_deck != null &&
            (IsPlayerDone(a_player) || m_hitRule.DoHit(this) != true))
            {
                return true;
            }
            return false;
        }

        private bool IsPlayerDone(Player a_player)
        {
            return IsPlayerFat(a_player) || HasPlayerBlackjack(a_player);
        }
        private bool IsPlayerFat(Player a_player)
        {
            return a_player.CalcScore() > g_maxScore;
        }

        private bool HasPlayerBlackjack(Player a_player)
        {
            return a_player.CalcScore() == g_maxScore && a_player.GetHand().Count() == 2;
        }
    }
}
