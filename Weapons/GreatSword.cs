using TextBasedRPG.Dice;

namespace TextBasedRPG.Weapons;

public class GreatSword : Weapon
{
    public GreatSword()
    {
        TenSidedDice t = new TenSidedDice();
        TypeOfWeapon = "Great Sword";
        DamageDice = t;
        DamageModifier = 5;
        NumberOfDamageRolls = 2;
    }
}