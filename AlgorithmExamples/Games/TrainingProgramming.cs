using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class TrainingProgramming : IGame
    {
        private readonly int _countElements = 3;
        private readonly ISelectElements _selectElements;
        private readonly List<string> _theorySql = new List<string>
        {
            "What is an aggregate function in SQL?",
            "What is the difference between Primary key and Unique?",
            "What is ACID?",
            "What is the difference between INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL JOIN, CROSS JOIN?",
            "What is the order of execution of expression: SELECT.FROM.WHERE.GROUP BY.HAVING.ORDER BY.OFFSET.FETCH?"
        };
        private readonly List<string> _theoryBackend = new List<string>
        {
            "What is SOLID?",
            "What is the difference between unit test and integration test?",
            "What levels of architecture do you know?",
            "What is the difference between const and read only?",
            "What is extension methods?"
        };

        public TrainingProgramming(ISelectElements selectElements)
        {
            _selectElements = selectElements;
        }

        public void Play()
        {
            List<string> selectedTheorySql = _selectElements.Select(_theorySql, _countElements);
            List<string> selectedTheoryBackend = _selectElements.Select(_theoryBackend, _countElements);

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
