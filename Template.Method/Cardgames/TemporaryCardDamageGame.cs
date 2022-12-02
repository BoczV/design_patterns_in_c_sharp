using Template.Method.Cardgames.Entity;

namespace Template.Method.Cardgames;

public class TemporaryCardDamageGame : CardGame
{
    public TemporaryCardDamageGame(Creature[] creatures) : base(creatures)
    {
        Console.WriteLine("Let's play Magic: the Gathering!");
    }

    protected override void Hit(Creature attacker, Creature other)
    {
        int otherOriginalHealth = other.Health;
        int attackerOriginalHealth = attacker.Health;

        other.Health -= attacker.Attack;
        attacker.Health -= other.Attack;

        if (other.Health > 0)
        {
            other.Health = otherOriginalHealth;
        }
        else if (attacker.Health > 0)
        {
            attacker.Health = attackerOriginalHealth;
        }
    }
}
