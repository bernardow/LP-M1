using System.Reflection;
using LP_M1.Questions;
using static LP_M1.GameLogic.ReplayLogic;

namespace LP_M1.GameLogic;

public class QuestionLogic
{
    //Referências
    private List<Question> _questionList = new List<Question>();
    private readonly AnswerLogic _answerLogic = new AnswerLogic();

    //É o principal loop para apresentar e ler as respostas das questōes
    public void QuestionIteration()
    {
        //Adiciona todas as questōes a uma lista
        _questionList = GetQuestionsList();

        //Faz o loop de montagem de cada questão
        for (int i = 0; i < _questionList.Count; i++)
        {
            //Escreve a string da pergunta
            Console.WriteLine(_questionList[i].QuestionName() + "\n");
            //Escreve todas as alternativas
            foreach (var alt in _questionList[i].QuestionAlternatives())
                Console.WriteLine(alt);

            //Lê a resposta
            _answerLogic.AnswerOut(_questionList,_questionList[i].CorrectAlternative(), i);
        }
    }

    //Esse glorioso método é responsável por adicionar todos os itens do projeto do tipo Question à uma ùnica lista. #melhormétodo
    public List<Question> GetQuestionsList()
    {
        //Inicialmente ele cria uma lista vazia
        List<Question> questions = new List<Question>();

        //Aqui é verificado se existem itens do tipo Question no projeto
        if (Assembly.GetAssembly(typeof(Question)) != null)
        {
            //Aqui nos fazemos algumas verificaçōes e pegamos todos os itens do tipo question, que não, a classe abstrata
            var questionTypes = Assembly.GetAssembly(typeof(Question)).GetTypes()
                .Where(quesType => quesType.IsClass && !quesType.IsAbstract && quesType.IsSubclassOf(typeof(Question)));

            //Aqui nós criamos uma instancia de cada tipo como uma Question, assim podemos adicionar elas à uma lista
            foreach (var quest in questionTypes)
            {
                var tempEffect = Activator.CreateInstance(quest) as Question;
                if (tempEffect != null)
                    questions.Add(tempEffect);
            }
        }

        //Por fim essa lista é retornada
        return questions;
    }
}
