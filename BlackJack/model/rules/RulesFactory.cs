
namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IWinConditionStrategy GetWinConditionRule()
        {
            return new BasicWinConditionStrategy();
        }

        public IHitStrategy GetHitRule()
        {
            return new BasicHitStrategy(); // return new Soft17Strategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
    }
}
