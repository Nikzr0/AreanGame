using ArenaGame.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface IHero
    {
        public SpecialAbility SpecialAbility { get; } 
        double Attack();
        double Defend(double damage);
    }
}
