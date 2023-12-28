using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class TrainingProgramming : IGame
    {
        private readonly List<string> _theorySql = new List<string>
        {
            "What is an aggregate function in SQL?",
            "What is the difference between Primary key and Unique?",
            "What is ACID?",
            "What is the difference between INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL JOIN, CROSS JOIN?",
            "What is the order of execution of expression: SELECT.FROM.WHERE.GROUP BY.HAVING.ORDER BY.OFFSET.FETCH?",
            "What is an index? What is the difference between clustered and non-clustered indexes?",
            "What is a constraint in SQL?",
            "What are the relationships between the tables?",
            "What is a Foreign Key?",
            "What is the difference between DELETE, TRUNCATE, DROP?"
        };
        private readonly List<string> _theoryBackend = new List<string>
        {
            "What is SOLID?",
            "What is the difference between unit test and integration test?",
            "What are the three parts of the three-tier architecture?",
            "What is the difference between const and read only?",
            "What is extension methods?",
            "What is asynchronous programming?",
            "When we must use method Dispose()?",
            "When we must use try, catch, finally?",
            "What is OOP? What is object, class? What is the state and behavior of object/class?",
            "What is value and reference type? What is difference between value and reference type? Where are they in memory?"
        };

        public void Play()
        {
            Console.WriteLine($"Write how many tasks do you want to learn in SQL and Backend(max count is {_theoryBackend.Count}):");
            string? countElementsString = Console.ReadLine();
            int countElements = Convert.ToInt32(countElementsString);

            List<string> selectedTheorySql = SelectElements.Select(_theorySql, countElements);
            List<string> selectedTheoryBackend = SelectElements.Select(_theoryBackend, countElements);

            Console.WriteLine("Revise theory in SQL and Backend:");
            PrintElements(selectedTheorySql);
            PrintElements(selectedTheoryBackend);
        }

        private void PrintElements(List<string> elements)
        {
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
