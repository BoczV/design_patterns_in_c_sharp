using Template.Method.Cardgames.Entity;

namespace Template.Method.Cardgames;

public class PermanentCardDamage : CardGame
{
    public PermanentCardDamage(Creature[] creatures) : base(creatures)
    {
        Console.WriteLine("Let's play Hearthstone!");
    }

    protected override void Hit(Creature attacker, Creature other)
    {
        other.Health -= attacker.Attack;
        attacker.Health -= other.Attack;
    }
}
