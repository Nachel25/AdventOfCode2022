namespace Day4
{
    public class Day4
    {
        private readonly List<string> _inputAsList;

        private int _day4Part1;
        public int Day4Part1
        {
            get
            {
                foreach (var ranges in _inputAsList)
                {
                    var rangeLimits = ranges.Split(',');
                    var range1String = rangeLimits[0].Split('-');
                    var range2String = rangeLimits[1].Split('-');

                    var range1Start = int.Parse(range1String[0]);
                    var range1End = int.Parse(range1String[1]);
                    var range2Start = int.Parse(range2String[0]);
                    var range2End = int.Parse(range2String[1]);

                    if (CheckContain(range1Start, range1End, range2Start, range2End))
                    {
                        _day4Part1 += 1;
                    }
                }
                return _day4Part1;
            }
        }

        private int _day4Part2;
        public int Day4Part2
        {
            get
            {
                foreach (var ranges in _inputAsList)
                {
                    var rangeLimits = ranges.Split(',');
                    var range1String = rangeLimits[0].Split('-');
                    var range2String = rangeLimits[1].Split('-');

                    var range1Start = int.Parse(range1String[0]);
                    var range1End = int.Parse(range1String[1]);
                    var range2Start = int.Parse(range2String[0]);
                    var range2End = int.Parse(range2String[1]);

                    if (CheckOverlap(range1Start, range1End, range2Start, range2End))
                    {
                        _day4Part2 += 1;
                    }
                }
                return _day4Part2;
            }
        }

        private static bool CheckContain(int startA, int endA, int startB, int endB)
        {
            return startA <= startB && endB <= endA || startB <= startA && endA <= endB;
        }

        private static bool CheckOverlap(int startA, int endA, int startB, int endB)
        {
            return startA <= startB && startB <= endA || startA <= endB && endB <= endA || startA <= startB && endB <= endA || startB <= startA && endA <= endB;
        }

        public Day4(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
        }
    }
}