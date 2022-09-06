using LP_M1.Questions;
using static LP_M1.GameLogic.Score;
using static LP_M1.GameLogic.ReplayLogic;

namespace LP_M1.GameLogic;

public class AnswerLogic
{
    //É responsável por ler a resposta de cada pergunta
    public void AnswerOut(List<Question> currentList,int correctQuestIndex, int currentIndex)
    {
        //Esse if é responsável caso o jogador acerte
        if (Console.ReadLine() == correctQuestIndex.ToString())
        {
            //Adicionamos o item à uma lista de questōes certas. Para depois, podermos remover essa questão no replay
            if (!RightQuestions.Contains(currentList[currentIndex]))
            {
                RightQuestions.Add(currentList[currentIndex]);
                if(WrongQuestions.Contains(currentList[currentIndex]))
                    WrongQuestions.Remove(currentList[currentIndex]);
            }
            RightSetup();
        }
        else //Caso o jogador erre...
        {
            //Adicionamos o indice à uma lista de questōes erradas. Para depois, podermos adicionar essa questão no replay
            if(!WrongQuestions.Contains(currentList[currentIndex]))
                WrongQuestions.Add(currentList[currentIndex]);
            WrongSetup();
        }
    }

    private void RightSetup()
    {
        Console.Clear();
        Console.WriteLine("Parabéns! Você acertou!" + "\n" + "Aperte Enter para ir para a próxima pergunta!" );
        //Adicionamos 1 ponto no score
        ScoreNum++;
            
        if(Console.ReadLine() == "") 
            Console.Clear();
    }

    private void WrongSetup()
    {
        Console.Clear();
        Console.WriteLine("Você Errou" + "\n" + "Aperte Enter para ir para a próxima pergunta!");
        MissesScore++;
        if(Console.ReadLine() == "") 
            Console.Clear();
    }
}