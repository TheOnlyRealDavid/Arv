using Arv;

public class Bow : RangedWeapon
{
    public Bow()
    {
        name = "LongBow";
        Damage = 250;
        Range = 500;
        RealoadSpeed = 100;
        Ammo = 50;
    }
}
