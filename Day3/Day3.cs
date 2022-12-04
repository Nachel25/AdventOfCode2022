namespace Day3
{
    public class Day3
    {
        private readonly List<string> _inputAsList;

        private int _prioritySumPart1;
        public int PrioritySumPart1
        {
            get
            {
                foreach (var rucksack in _inputAsList)
                {
                    var compartment1 = rucksack.Substring(0, (rucksack.Length / 2));
                    var compartment2 = rucksack.Substring((rucksack.Length / 2), (rucksack.Length / 2));

                    var commonLetter = compartment1.Intersect(compartment2).ToArray();
                    _prioritySumPart1 += PriorityCalculator(commonLetter[0]);
                }
                return _prioritySumPart1;
            }
        }

        private int _prioritySumPart2;
        public int PrioritySumPart2
        {
            get
            {
                for (int i = 0; i < _inputAsList.Count; i++)
                {
                    if (i % 3 == 0)
                    {
                        var row1 = _inputAsList[i];
                        var row2 = _inputAsList[i + 1];
                        var row3 = _inputAsList[i + 2];

                        var commonLetter = row1.Intersect(row2).Intersect(row3).ToArray();
                        _prioritySumPart2 += PriorityCalculator(commonLetter[0]);
                    }
                }
                return _prioritySumPart2;
            }
        }

        private static int PriorityCalculator(char commonLetter)
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            return Array.IndexOf(alpha, commonLetter) + 1;
        }

        public Day3(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
        }
    }
}