using ArenaGame.Enums;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        public Archer(string name, double armor, double strenght, IWeapon weapon, SpecialAbility specialAbility) :
          base(name, armor, strenght, weapon, specialAbility)
        {
        }

        public override double Attack()
        {
            double baseDamage = base.Attack();
            bool isCriticalHit = random.NextDouble() < 0.50;

            if (isCriticalHit)
            {
                baseDamage *= 6;

                //optional
                //Console.WriteLine($"{Name} landed a critical hit!");
            }

            return baseDamage;
        }
    }
}
