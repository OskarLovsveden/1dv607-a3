
namespace BlackJack.model.rules
{
    class BasicWinConditionStrategy : IWinConditionStrategy
    {
        public bool HasWon(model.Player a_dealer, model.Player a_player, int g_maxScore)
        {
            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (a_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            return a_dealer.CalcScore() >= a_player.CalcScore();
        }
    }
}