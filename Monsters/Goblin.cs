using TextBasedRPG.Dice;

namespace TextBasedRPG.Monsters;

public class Goblin : Monster
{
    public Goblin(string typeOfMonster = "Goblin") : base("Small Bad")
    {
        TypeOfMonster = typeOfMonster;
    }
    
    protected override void RollForCharacterStats()
    {
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat() - 5;
        this.Dexterity = s.RollStat() - 5;
        this.Wisdom = s.RollStat() - 6;
        this.Constitution = s.RollStat() - 5;
    }
}