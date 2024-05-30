using ArenaGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class MagicWand : IWeapon, ISpecialAbilityWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public SpecialAbility SpecialAbility { get; private set; }

        public MagicWand(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 300;

            SpecialAbility = SpecialAbility.Dizziness;
        }
    }
}
