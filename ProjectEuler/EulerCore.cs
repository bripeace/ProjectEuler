using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    public class Question
    {
        private uint _questionNumber;
        private long _answer;

        public uint QuestionNumber { get { return _questionNumber;} set { _questionNumber = value; } }
        public long Answer {get { return _answer; } set { _answer = value; } }

        public Question(uint num, long ans)
        {
            _questionNumber = num;
            _answer = ans;
        }
    }

    public static class QuestionData
    {
        public static long One()
        {
            int sum = 0;

            for (var x = 1; x < 1000; x++)
                sum += (x % 3 == 0 || x % 5 == 0) ? x : 0;

            return sum;
        }
        
    }
}
