namespace Day1
{
    public class Day1
    {
        private readonly string[] _linesArray;
        private readonly int[] _elfCaloriesArray;

        private int _totalCaloriesTopOne;
        public int TotalCaloriesTopOne
        {
            get
            {
                _totalCaloriesTopOne = (from elves in _elfCaloriesArray
                                        orderby elves descending
                                        select elves).First();
                return _totalCaloriesTopOne;
            }
        }

        private int _totalCaloriesTopThree;
        public int TotalCaloriesTopThree
        {
            get
            {
                _totalCaloriesTopThree = (from elves in _elfCaloriesArray
                                         orderby elves descending
                                         select elves).Take(3).Sum();
                return _totalCaloriesTopThree;
            }
        }

        public Day1(string filepath)
        {
            _linesArray = File.ReadAllLines(filepath);

            var numberOfElves = 0;
            foreach (var line in _linesArray)
            {
                if (string.IsNullOrEmpty(line))
                {
                    numberOfElves++;
                }
            }
            _elfCaloriesArray = new int[numberOfElves + 1];

            var elfIndex = 0;
            foreach (var line in _linesArray)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    _elfCaloriesArray[elfIndex] += int.Parse(line);
                }
                else
                {
                    elfIndex++;
                }
            }
        }
    }
}