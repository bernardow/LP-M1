using LP_M1.GameLogic;

namespace LP_M1.Questions.CreatedQuestObj;

public class ZeldaQuest : Question
{
    public override string QuestionName() => "O primeiro jogo da franquia Legend of Zeld foi lançado em:";

    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: 1981");
        alternatives.Add("2: 1992");
        alternatives.Add("3: 1986");
        alternatives.Add("4: 1983");
        return alternatives;
    }

    public override int CorrectAlternative() => 3;
}