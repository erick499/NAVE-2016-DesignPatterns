using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    class Blacksmith
    {
        public Weapon buildWeapon(string weaponType) {
            if (weaponType == "dagger") {
                Dagger newDagger = new Dagger();
                return newDagger;
            }
            else if (weaponType == "sword") {
                Sword newSword = new Sword();
                return newSword;
            }
            else if (weaponType == "lance") {
                Lance newLance = new Lance();
                return newLance;
            }

            return null;
        }
    }
}
