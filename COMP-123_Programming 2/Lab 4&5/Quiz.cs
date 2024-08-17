using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XuanN_301388576_lib
{
    class Quiz : Evaluation
    {
        public uint NumberOfQuestions 
        { 
            get { return NumberOfQuestions; }
            set { NumberOfQuestions = value; } 
        }
        public Quiz(Course course, byte weight, uint numberOfQuestions = 1) : base(course, EvaluationType.Quiz, weight)
        {
            this.Course = course;
            this.Weight = weight;
            this.NumberOfQuestions = numberOfQuestions;
        }
        public override string ToString()
        {
            return $"{Course}:{Weight}:{NumberOfQuestions}";
        }
    }
}
