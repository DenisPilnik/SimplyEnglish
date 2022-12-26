using GalaSoft.MvvmLight;
using SimplyEnglish.Model;
using System;
using System.Windows.Input;
using RelayCommand = SimplyEnglish.Command.RelayCommand;

namespace SimplyEnglish.ViewModel
{
    public class MainViewModel : ViewModelBase
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

        public MainViewModel()
        {
            englishWord = new EnglishWord();
            currentWord = new CurrentWord();

            SubmitAnswerBtn = new RelayCommand(new Action<object>(SubmitAnswer));
            OkBtn = new RelayCommand(new Action<object>(ChechWrongInfoOk));

            currentWord.Answer = "Answer : ";

            englishWord.SetWord();
        }       

        public void SubmitAnswer(object obj)
        {
            currentWord.AnswerStatus = VerifyAnswer.Verificate(currentWord, englishWord);
            currentWord.Answer = "";
        }

        public void ChechWrongInfoOk(object obj)
        {
            currentWord.AnswerStatus = Enum.Answer.None;
        }
    }
}