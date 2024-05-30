using ArenaGame.Enums;

namespace ArenaGame.Heroes
{
    public class Witch : Hero
    {
        private int wandLife;
        public Witch(string name, double armor, double strenght, IWeapon weapon, SpecialAbility specialAbility, int wandLife) : base(name, armor, strenght, weapon, specialAbility)
        {
            this.wandLife = wandLife;
        }

        public override double Attack()
        {
            double baseDamage = base.Attack();
            bool isCriticalHit = random.NextDouble() < 0.05;

            if (isCriticalHit)
            {
                baseDamage *= 9;

                //optional
                //Console.WriteLine($"{Name} landed a critical hit!");
            }

            return baseDamage;
        }

        public override double Defend(double damage)
        {
            if (this.wandLife > 1)
            {
                this.wandLife-= 2;
                return 0;
            }

            return base.Defend(damage);
        }
    }
}
