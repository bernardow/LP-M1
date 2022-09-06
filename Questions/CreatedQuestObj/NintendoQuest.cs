namespace LP_M1.Questions.CreatedQuestObj;

public class NintendoQuest : Question
{
    public override string QuestionName() => "Em que ano a Nintendo foi criada?";

    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: 1943");
        alternatives.Add("2: 1889");
        alternatives.Add("3: 1978");
        alternatives.Add("4: 1936");
        return alternatives;
    }

    public override int CorrectAlternative() => 2;
}