namespace LP_M1.Questions.CreatedQuestObj;

public class SantosQuest : Question
{
    public override string QuestionName() => "O Santos é?";
    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: O Maior do Mundo");
        alternatives.Add("2: O Maior do Basquete");
        alternatives.Add("3: O Maior do Golfe");
        alternatives.Add("4: O Maior do Brasil");
        return alternatives;
    }

    public override int CorrectAlternative() => 4;
}