namespace LP_M1.Questions.CreatedQuestObj;

public class ResidentEvilQuest : Question
{
    public override string QuestionName() => "Na franquia Resident Evil, Chris Redfield e Claire Redfield são:";

    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: Irmãos");
        alternatives.Add("2: Respectivamente, pai e filha");
        alternatives.Add("3: Respectivamente, filho e mãe");
        alternatives.Add("4: Apenas bons amigos");
        return alternatives;
    }

    public override int CorrectAlternative() => 1;
}