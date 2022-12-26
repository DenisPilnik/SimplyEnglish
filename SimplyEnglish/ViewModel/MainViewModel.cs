using GalaSoft.MvvmLight;
using SimplyEnglish.Model;
using System;
using System.Windows;
using System.Windows.Input;
using RelayCommand = SimplyEnglish.Command.RelayCommand;

namespace SimplyEnglish.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Title { get => "Study English"; }
        public EnglishWord englishWord { get; set; }
        public CurrentWord currentWord { get; set; }
        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }

        public MainViewModel()
        {
            englishWord = new EnglishWord();
            currentWord = new CurrentWord();

            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));

            englishWord.SetWord();
        }       

        public void ShowMessage(object obj)
        {
            MessageBox.Show("Hello World");
        }
    }
}