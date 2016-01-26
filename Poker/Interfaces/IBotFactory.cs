namespace Poker.Interfaces
{
    public interface IBotFactory
    {
        ICharacter CreateBot(string name, int chips, int power = 0);
    }
}
