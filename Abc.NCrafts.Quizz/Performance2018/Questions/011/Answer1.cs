﻿namespace Abc.NCrafts.Quizz.Performance2018.Questions._011
{
    public class Answer1
    {
        public void Run()
        {
            var o = GetInstance();

            // begin
            if (o is string s)
                UseAsString(s);
            // end
        }

        private object GetInstance() => "lol";

        private void UseAsString(string s)
        {
        }
    }
}
