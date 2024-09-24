using TextBasedRPG.Dice;

namespace TextBasedRPG.Weapons;

public class LongSword : Weapon
{
    public LongSword()
    {
        EightSidedDice e = new EightSidedDice();
        TypeOfWeapon = "Longsword";
        DamageDice = e;
        DamageModifier = 2;
        NumberOfDamageRolls = 2;
    }
}