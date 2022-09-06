namespace LP_M1.Questions.CreatedQuestObj;

public class PokemonQuest : Question
{
    public override string QuestionName() => "Qual o Pokémon de fogo mais conhecido no mundo?";

    public override List<string> QuestionAlternatives()
    {
        List<string> alternatives = new List<string>();
        alternatives.Add("1: Arcanine");
        alternatives.Add("2: Pikachu");
        alternatives.Add("3: Charmander");
        alternatives.Add("4: Dragonite");
        return alternatives;
    }

    public override int CorrectAlternative() => 3;
}