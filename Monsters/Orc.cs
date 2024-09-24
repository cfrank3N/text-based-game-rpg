using TextBasedRPG.Dice;

namespace TextBasedRPG.Monsters;

public class Orc : Monster
{
    public Orc(string typeOfMonster = "Orc") : base("Green Bad Guy")
    {
        TypeOfMonster = typeOfMonster;
    }
    
    protected override void RollForCharacterStats()
    {
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat() + 5;
        this.Dexterity = s.RollStat() -6;
        this.Wisdom = s.RollStat() - 6;
        this.Constitution = s.RollStat() + 5;
    }
}