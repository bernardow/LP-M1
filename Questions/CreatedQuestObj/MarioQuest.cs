namespace LP_M1.Questions.CreatedQuestObj;

public class MarioQuest : Question
{
    public override string QuestionName() => "A profissão do, icônico, persoagem Mario, da franquia Super Mario é:";

    public override List<string> QuestionAlternatives()
    {
        List<string> alteratives = new List<string>();
        alteratives.Add("1: Um artesão");
        alteratives.Add("2: Um encanador");
        alteratives.Add("3: Um fugitivo do hospício");
        alteratives.Add("4: Um eletricista");
        return alteratives;
    }

    public override int CorrectAlternative() => 2;
}