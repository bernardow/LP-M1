namespace LP_M1.Questions.CreatedQuestObj;

public class FlamengoQuest : Question
{
    public override string QuestionName() => "O Flamengo é?";

    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: Maior da história");
        alternatives.Add("2: Maior do Mundo");
        alternatives.Add("3: Maior Do Brasil");
        alternatives.Add("4: Maior do RJ");
        return alternatives;
    }

    public override int CorrectAlternative() => 4;
}