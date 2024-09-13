namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Question[] myQuestions = new Question[]
            {
                new Question("What is the capital of germany ?",
                new string[] {"Paris","Berlin","Madrid","London"},
                1
                ),
                new Question("What is the 2 + 2 ?",
                new string[] {"3","4","5","6"},
                1
                ),
                new Question("Who wrote Hamlet ?",
                new string[] {"Bethoven","Ivan Vazov","Shakespeare","Kalata"},
                2
                ),
                new Question("What is the capital of germany",
                new string[] {"Paris","Berlin","Madrid","London"},
                1
                )
            };

            Quiz myQuiz = new Quiz(myQuestions);

            myQuiz.StartQuiz();

            Console.ReadLine();
        }
    }
}
