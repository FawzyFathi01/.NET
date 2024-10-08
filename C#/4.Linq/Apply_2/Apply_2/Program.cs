﻿using Shared;
using System.Linq;
namespace Apply_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Range();
            //Repeat();

            //ElementAt();
            //First();
            //Last();
            //Single();
           // TenEvenNumbers();
            //TestEmptyList();
            first_question();

        }


        #region  Generation Operations
        static void Empty()
        {
           //  To Create Object (Empty)
            var question = Enumerable.Empty<Question>();
        }

        static void DefaultIfEmpty()
        {
            
             var question = Enumerable.Empty<Question>();

            // (DefaultIfEmpty)
            var res = question.DefaultIfEmpty(Question.Default);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        static void Range()
        {
            var range = Enumerable.Range(0, 10);
            var questions = QuestionBank.GetQuestionRange(range);

            foreach (var item in questions)
            {
                Console.WriteLine(item);
            }

        }

        static void Repeat()
        {
            var question = QuestionBank.PickOne();
            var questionsPickOne = Enumerable.Repeat(question, 10);
            int cnt = 1;
            foreach (var item in questionsPickOne)
            {
                Console.WriteLine($"Q : #{cnt++}");
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Element Operations
        static void ElementAt()
        {
            var questions = QuestionBank.All;
            var question30 = questions.ElementAt(30);
            var question300 = questions.ElementAtOrDefault(300);
            Console.WriteLine(question300 is null?Question.Default : question300);
        }

        static void First()
        {
            var question = QuestionBank.All.First();
            var question01 = QuestionBank.All.FirstOrDefault(Question.Default);

            Console.WriteLine();

        }
        static void Last()
        {
            var question = QuestionBank.All.Last();
            
            var question01 = QuestionBank.All.LastOrDefault(Question.Default);

            Console.WriteLine(question);

        }

        static void Single()
        {
            var questions = QuestionBank.All;
            var question = questions.Single( q => q.Title.Contains("#10"));
            Console.WriteLine(question);

        }

        #endregion

        #region Equality Operations

        static void SequenceEqual()
        {

        }

        #endregion

        #region Concatenation

        static void Concat()
        {

        }

        #endregion


        #region Task

        static void TenEvenNumbers ()
        {
            var res = Enumerable.Range(1, 21).Where( x => x%2==0);

            var res01 = Enumerable.Repeat(res, 3);

            foreach (var item in res01)
            {
                //Console.Write($"{item}, ");
                foreach (var item1 in item)
                {
                    Console.Write($"{item1}, ");
                }
                Console.WriteLine();
            }
        }

        static void TestEmptyList()
        {
            var list = Enumerable.Empty<int>();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



        static void first_question()
        {
            var res = QuestionBank.All.First(q => q.Choices.Count() <= 2);
            Console.WriteLine(res.Title);
        }

        #endregion

    }
}
