namespace TextBasedRPG.Dice;

public class Dice
{
    public int SidesOnDice { get; protected set; }
    public int DiceRoll { get; protected set; }
    
    public string TypeOfDice { get; protected set; }
    

    public int RollDice(int numberOfRolls)
    {
        DiceRoll = 0;
        Random r = new Random();
        for (int i = 0; i < numberOfRolls; i++)
        {
            DiceRoll += r.Next(1,SidesOnDice + 1);
        }

        return DiceRoll;
    }
}