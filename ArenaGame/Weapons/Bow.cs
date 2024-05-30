using ArenaGame.Enums;

namespace ArenaGame.Weapons
{
    public class Bow : IWeapon, ISpecialAbilityWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialAbility SpecialAbility { get; private set; }

        public Bow(string name)
        {
            Name = name;
            AttackDamage = 80;
            BlockingPower = 0;
            SpecialAbility = SpecialAbility.Poison;
        }
    }
}
