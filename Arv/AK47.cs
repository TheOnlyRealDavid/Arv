using System;

namespace Arv;

public class AK47 : RangedWeapon
{
   public AK47()
    {
        name = "AK47";
        Damage = 10;
        Range = 100;
        RealoadSpeed = 5;
        Ammo = 20;

    }
}
