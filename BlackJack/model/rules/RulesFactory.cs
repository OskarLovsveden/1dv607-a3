
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
            // return new Soft17Strategy();
            return new BasicHitStrategy();
        }

        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
    }
}
