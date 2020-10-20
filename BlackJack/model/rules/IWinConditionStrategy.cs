namespace BlackJack.model.rules
{
    interface IWinConditionStrategy
    {
        bool HasWon(model.Player a_dealer, model.Player a_player, int g_maxScore);
    }
}