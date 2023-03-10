using SimplyEnglish.Command;
using SimplyEnglish.Enum;
using System.ComponentModel;

namespace SimplyEnglish.Model
{
    public class CurrentWord:ChangeProperty
    {
        private string englishWord { get; set; }
        private string answer { get; set; }
        private Answer answerStatus { get; set; }

        public string EnglishWord {
            get { return englishWord; }
            set { 
                englishWord = value;
                OnPropertyChanged(nameof(EnglishWord));
            }
        }
        public string Answer
        {
            get { return answer; }
            set { 
                answer = value;
                OnPropertyChanged(nameof(Answer));
            }
        }

        public Answer AnswerStatus
        {
            get { return answerStatus; }
            set { 
                answerStatus = value; 
                OnPropertyChanged(nameof(AnswerStatus));
            }
        }

        public CurrentWord()
        {
            englishWord = string.Empty;
            answer = string.Empty;
            answerStatus = Enum.Answer.None;
        }
    }
}
