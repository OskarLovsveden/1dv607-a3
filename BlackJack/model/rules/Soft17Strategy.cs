
namespace BlackJack.model.rules
{
    class Soft17Strategy : IHitStrategy
    {
        private const int g_hitLimit = 17;

        public bool DoHit(model.Player a_dealer)
        {
            bool hitLimitNotReached = a_dealer.CalcScore() < g_hitLimit;

            bool hasAce = false;
            foreach (Card card in a_dealer.GetHand())
            {
                hasAce = card.GetValue() == model.Card.Value.Ace;
            }

            return hitLimitNotReached || hasAce;
        }
    }
}
