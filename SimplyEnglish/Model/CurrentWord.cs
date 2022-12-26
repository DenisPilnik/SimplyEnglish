using SimplyEnglish.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyEnglish.Model
{
    public class CurrentWord:INotifyPropertyChanged
    {
        private string englishWord { get; set; }
        private string answer { get; set; }
        private Answer answerStatus { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

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
