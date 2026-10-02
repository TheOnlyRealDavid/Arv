using System;

namespace Arv;

public class Sword : MeleeWeapon
{
    public Sword()
    {
        name = "LongSword";
        Damage = 500;
        Range = 3; 
        SwingSpeed = 50;
    }
}
