using LP_M1.GameLogic;
using static LP_M1.GameLogic.Score;
using static LP_M1.GameLogic.ReplayLogic;
namespace LP_M1.Managers;

//O GameManager é responsável pelo gerenciamento dos ESTADOS DE JOGO.
//O que quer dizer, que ele que decide, o que e quando esses estados devem aparecer
public static class GameManager
{
    public static void Intro()
    {
        Console.Clear();
        ScoreNum = 0;
        Console.WriteLine("Olá! Seja bem-vindo ao, GRANDIOSO, ULTIMATE simple QUESTION GAME" + "\n");
        Console.WriteLine("Esse INCRÍVEL software(que não é nada soft >:) ) irá fazer perguntas à  você!");
        Console.WriteLine("Pense com cuidado na hora de dar suas respostas!");
        Console.WriteLine("Ou não. Já que você sempre tem a opção de tentar de novo" + "\n");
        Console.WriteLine("Aperte Enter para começar sua GRANDIOSA jornada");
        
        if(Console.ReadLine() == "")
            StartGame();
        else
        {
            Console.Clear();
            Console.WriteLine("Eu não acredito que você conseguiu errar o único comando do jogo até agora");
            Console.WriteLine("Vamos tentar de novo! Aperte Enter! SÓ O ENTER para começar");
            if (Console.ReadLine() == "")
                StartGame();
        }
    }
    private static void StartGame()
    {
        Console.Clear();
        QuestionLogic questionLogic = new QuestionLogic();
        questionLogic.QuestionIteration();
        ScoreScreen();
    }

    private static void ScoreScreen()
    {
        Console.WriteLine("Você acertou: " + ScoreNum + "\n");
        Console.WriteLine("Se quiser jogar novamente aperte(adivinha, o ENTER)!");
        Console.WriteLine("Caso não me aguente mais e seu único desejo é se ver livre de mim, escreva tchau");
        if (Console.ReadLine() == "" )
            Replay();
        else if(Console.ReadLine() == "tchau")
            Console.Clear();
    }

    private  static void Replay()
    {
        ScoreNum = 0;
        Console.Clear();
        if(WrongQuestions.Count > 0)
        {
            ReplayQuestIterator();
            ScoreScreen();
        }else FinalScreen();
    }

    private static void FinalScreen()
    {
        Console.WriteLine("Parabéns! Você, incrivelmente, acertou todas as perguntas que selecionamos e o jogo, enfim, acabou");
        Console.WriteLine("Muito obrigado por ter jogado!");
    }
}