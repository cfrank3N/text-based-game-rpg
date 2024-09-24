namespace TextBasedRPG.Dice;

public class SixSidedDice : Dice
{
    public SixSidedDice()
    {
        SidesOnDice = 6;
        TypeOfDice = "D6";
    }
    
    //Method
    public int RollStat()
    {
        SixSidedDice s = new SixSidedDice();
        DiceRoll = s.RollDice(4);
        return DiceRoll;
    }
}