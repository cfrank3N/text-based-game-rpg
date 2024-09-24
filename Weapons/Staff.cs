using TextBasedRPG.Dice;

namespace TextBasedRPG.Weapons;

public class Staff : Weapon
{
    public Staff()
    {
        SixSidedDice s = new SixSidedDice();
        TypeOfWeapon = "Staff";
        DamageDice = s;
        DamageModifier = 0;
        NumberOfDamageRolls = 3;
    }
}