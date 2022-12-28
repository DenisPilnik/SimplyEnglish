using SimplyEnglish.Command;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SimplyEnglish.Model
{
    public class EnglishWord:ChangeProperty
    {
        private string word { get; set; }
        private string answerVariable {get; set; }
        public string Word
        {
            get { return word; }
            set { 
                word = value;
                OnPropertyChanged(nameof(Word));
            }
        }
        public string AnswerVariable
        {
            get { return answerVariable; }
            set { 
                answerVariable = value;
                OnPropertyChanged(nameof(AnswerVariable));
            }
        }
    }
}
