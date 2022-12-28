using GalaSoft.MvvmLight;
using SimplyEnglish.Json;
using SimplyEnglish.Model;
using System;
using System.ComponentModel;
using System.Windows.Input;
using RelayCommand = SimplyEnglish.Command.RelayCommand;

namespace SimplyEnglish.ViewModel
{
    public class MainViewModel : ViewModelBase,INotifyPropertyChanged
    {
        public string Title { get => "Study English"; }
        public EnglishWord englishWord { get; set; }
        public CurrentWord currentWord { get; set; }
        private ICommand submitAnswerBtn;
        public ICommand SubmitAnswerBtn
        {
            get
            {
                return submitAnswerBtn;
            }
            set
            {
                submitAnswerBtn = value;
            }
        }

        private ICommand okBtn;
        public ICommand OkBtn
        {
            get
            {
                return okBtn;
            }
            set
            {
                okBtn = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

       

        public MainViewModel()
        {
            englishWord = new EnglishWord();
            currentWord = new CurrentWord();

            SubmitAnswerBtn = new RelayCommand(new Action<object>(SubmitAnswer));
            OkBtn = new RelayCommand(new Action<object>(ChechWrongInfoOk));

            GetNewWord();

            currentWord.Answer = "Answer : ";
        }       

        public void SubmitAnswer(object obj)
        {
            currentWord.AnswerStatus = VerifyAnswer.Verificate(currentWord, englishWord);
            currentWord.Answer = "";
            if (currentWord.AnswerStatus == Enum.Answer.CorrectAnswer)
                GetNewWord();
            
        }

        public void ChechWrongInfoOk(object obj)
        {
            GetNewWord();
            currentWord.AnswerStatus = Enum.Answer.None;           
        }

        private void GetNewWord()
        {
            Random random = new Random();
            englishWord = JsonMapper.GetEnglishWordById(random.Next(400));
            OnPropertyChanged(nameof(englishWord));
        }
    }
}