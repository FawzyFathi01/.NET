using Shared;
namespace Apply_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Range();
            Repeat();
        }

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



    }
}
