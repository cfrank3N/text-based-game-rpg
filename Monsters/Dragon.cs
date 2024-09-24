using TextBasedRPG.Dice;
using TextBasedRPG.Weapons;

namespace TextBasedRPG.Monsters;

public class Dragon : Monster
{
    public Dragon(string typeOfMonster = "Dragon") : base("Big Big Bad")
    {
        TypeOfMonster = typeOfMonster; 
        EquipWeapon(new DragonClaws());
    }
    
    protected override void RollForCharacterStats()
    {
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat() + 10;
        this.Dexterity = s.RollStat();
        this.Wisdom = s.RollStat();
        this.Constitution = s.RollStat() + 10;
    }
    
    
}