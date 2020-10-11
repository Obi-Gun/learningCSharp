using System;

namespace _5.CW_11._10._2020_TanksLib
{
    public class Tank
    {
        private const int MaxValue = 101;
        private int _ammo;
        private int _armor;
        private int _mobility;

        public string Name { get; }
        public string Ammo { get => _ammo.ToString(); }
        public string Armor { get => _armor.ToString(); }
        public string Mobility { get => _mobility.ToString(); }

        public Tank (string name, Random random)
        {
            Name = name;
            _ammo = random.Next(MaxValue);
            _armor = random.Next(MaxValue);
            _mobility = random.Next(MaxValue);
        }

        public static Tank operator * (Tank a, Tank b)
        {
            int tmp = 0;
            tmp = a._ammo > b._ammo         ? ++tmp : --tmp;
            tmp = a._armor > b._armor       ? ++tmp : --tmp;
            tmp = a._mobility > b._mobility ? ++tmp : --tmp;
            return tmp > 0                  ?     a : b;
        }

        public override string ToString()
        {
            return $"name = {Name} ammo = {Ammo} armor = {Armor} mobility = {Mobility}";
        }
    }
}
