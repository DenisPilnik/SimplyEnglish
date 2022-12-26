using SimplyEnglish.Enum;
using System.Linq;
namespace SimplyEnglish.Model
{
    public static class VerifyAnswer
    {
        public static Answer Verificate(CurrentWord currentWord, EnglishWord englishWord)
        {
            return englishWord.AnswerVariable.Any(word => word.ToLower().Replace(" ", "") == currentWord.Answer.ToLower().Replace(" ", "")) ? Answer.CorrectAnswer : Answer.WrongAnswer;
        }
    }
}
