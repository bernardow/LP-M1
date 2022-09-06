using LP_M1.Questions;

namespace LP_M1.GameLogic;

public static class ReplayLogic
{
    //Valores
    public static readonly List<Question> WrongQuestions = new List<Question>();
    public static readonly List<Question> RightQuestions = new List<Question>();

    //Referências
    private static readonly AnswerLogic AnswerLogic = new AnswerLogic();

    //É responsável pelo loop de questōes nos replays
    public static void ReplayQuestIterator()
    {
        //Inicialmente a gente faz uma verificação para ver se o jogador errou alguma questão
        if (WrongQuestions.Count > 0)
        {
            //Aqui é feito a montagem das questōes
            for (int i = 0; i < WrongQuestions.Count; i++)
            {
                //Escreve a string da pergunta
                Console.WriteLine(WrongQuestions[i].QuestionName() + "\n");
                //Escreve todas as alternativas
                foreach (var alt in WrongQuestions[i].QuestionAlternatives())
                    Console.WriteLine(alt);
                
                //Lê a resposta
                AnswerLogic.AnswerOut(WrongQuestions, WrongQuestions[i].CorrectAlternative(), i);
            }
        }
    }
}