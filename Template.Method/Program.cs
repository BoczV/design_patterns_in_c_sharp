using Template.Method.Cardgames;
using Template.Method.Cardgames.Entity;

namespace Template.Method;

public static class Program
{
    static void Main()
    {
        var creaters = new Creature[2];
        creaters[0] = new Creature(10, 10);
        creaters[1] = new Creature(5, 12);
        CardGame cardGame = new TemporaryCardDamageGame(creaters);
        int winnerIndex = cardGame.Combat(0, 1);
        Console.WriteLine(winnerIndex == -1 ? "Nobody won." : $"{winnerIndex + 1}. creature won!");
    }
}