using TextBasedRPG.Dice;

namespace TextBasedRPG.Monsters;

public class MindFlayer : Monster
{
    public MindFlayer(string typeOfMonster = "Mind Flayer") : base("Intelligent Bad Guy")
    {
        TypeOfMonster = typeOfMonster;
    }
    protected override void RollForCharacterStats()
    {
        SixSidedDice s = new SixSidedDice();
        this.Strength = s.RollStat() + 5;
        this.Dexterity = s.RollStat();
        this.Wisdom = s.RollStat() + 10;
        this.Constitution = s.RollStat() - 1;
    }
}