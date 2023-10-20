using Template.Method.Cardgames.Entity;

namespace Template.Method.Cardgames;

public abstract class CardGame
{
    public Creature[] Creatures { get; set; }

    protected CardGame(Creature[] creatures)
    {
        Creatures = creatures;
    }

    // returns -1 if no clear winner (both alive or both dead)
    public int Combat(int creature1, int creature2)
    {
        Creature first = Creatures[creature1];
        Creature second = Creatures[creature2];

        do
        {
            Hit(first, second);
            Hit(second, first);
        } while (first.Health <= 0 || second.Health <= 0);

        bool firstAlive = first.Health > 0;
        bool secondAlive = second.Health > 0;

        if (firstAlive == secondAlive)
        {
            return -1;
        }

        return firstAlive ? creature1 : creature2;
    }

    // attacker hits other creature
    protected abstract void Hit(Creature attacker, Creature other);
}
