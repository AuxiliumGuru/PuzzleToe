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
            expression.Add("8-2*3+5");
            expression.Add("10-4*(2+3)");
            expression.Add("(15-5)+2*1");
            expression.Add("(7+2)*3-2");
            expression.Add("12-3*2+4");
        }

        public void initializeAnswers()
        {
            answers.Add(7);
            answers.Add(-8);
            answers.Add(15);
            answers.Add(8);
            answers.Add(9);
            answers.Add(-6);

        }

    }
}
