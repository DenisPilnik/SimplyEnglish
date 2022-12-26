using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SimplyEnglish.Model
{
    public class EnglishWord:INotifyPropertyChanged
    {
        private string word { get; set; }
        private ObservableCollection<string> answerVariable {get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string Word
        {
            get { return word; }
            set { 
                word = value;
                OnPropertyChanged(nameof(Word));
            }
        }
        public ObservableCollection<string> AnswerVariable
        {
            get { return answerVariable; }
            set { 
                answerVariable = value;
                OnPropertyChanged(nameof(AnswerVariable));
            }
        }
        
        public void SetWord()
        {
            Word = "Kat";
            ObservableCollection<string> answer = new ObservableCollection<string>
            {
                "Кіт",
                "Кішка",
                "Кот"
            };
            AnswerVariable = answer;
        }
    }
}
