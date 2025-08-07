using UnityEngine;
using System.Collections.Generic;

namespace TruthOrTruth.TextSource
{
    public class QuestionTextSource : ITextSource
    {
        private List<string> _questions;
        private System.Random _random = new System.Random();

        private void FillQuestions()
        {
            TextAsset jsonFile = Resources.Load<TextAsset>("questions");
            _questions = new List<string>(JsonUtility.FromJson<QuestionList>(jsonFile.text).questions);
        }

        public QuestionTextSource() 
        {
            FillQuestions();
        }

        public string GetText()
        {
            if (_questions.Count == 0)
                FillQuestions();

            int index = _random.Next(0, _questions.Count);
            string question = _questions[index];
            _questions.RemoveAt(index);
            return question;
        }
    }
}