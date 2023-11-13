using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BracketQuest
{
    internal class Questions
    {

        private List<String> expression = new List<String>();
        private List<double>  answers = new List<double>();
        
        public List<String> Expression
        {
            get { return expression; }
        }

        public List<double> Answers
        {
           get { return answers;}
        }

        public Questions()
        {
            initializeAnswers();
            initializeExpressions();

        }


        public void initializeExpressions()
        {
            expression.Add("8-2*3+5");
        }

        public void initializeAnswers()
        {
            answers.Add(7);
        }

    }
}
