namespace LP_M1.Questions;

//Classe abstrata das questōes
//Ela é quem deixa o trabalho consideravelmente mais fácil
//Com ela, já temos um modelo padrão de classe, as classes das perguntas
//Assim, para adicionar novas questōes ao jogo, é só criar novas subclasses dessa aqui e sobreescrever as variáveis
public abstract class Question
{
    //A pergunta da questão
    public abstract string QuestionName();
    
    //As alternativas da questão
    public abstract List<string> QuestionAlternatives();
    
    //E por fim, a resposta correta
    public abstract int CorrectAlternative();
}
