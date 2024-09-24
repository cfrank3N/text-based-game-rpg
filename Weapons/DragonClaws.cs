using TextBasedRPG.Dice;

namespace TextBasedRPG.Weapons;



public class DragonClaws : Weapon
{
    public DragonClaws()
    {
        EightSidedDice e = new EightSidedDice();
        TypeOfWeapon = "Dragonclaws";
        DamageDice = e;
        DamageModifier = 5;
        NumberOfDamageRolls = 4;
    }
}