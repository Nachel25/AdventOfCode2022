namespace Day1
{
    public class Day1
    {
        private readonly string[] lines;
        private readonly int numberOfElves;
        private readonly int[] elfCalories;

        public int TotalCaloriesTopOne
        {
            get
            {
                var elfWithMostCalories = (from elves in elfCalories
                                           orderby elves descending
                                           select elves).First();
                var totalCaloriesTopOne = elfWithMostCalories;
                return totalCaloriesTopOne;
            }
        }

        public int TotalCaloriesTopThree
        {
            get
            {
                var elfWithMostCalories = (from elves in elfCalories
                                       orderby elves descending
                                       select elves).First();

                var elfWithSecondMostCalories = (from elves in elfCalories
                                             orderby elves descending
                                             select elves).Skip(1).First();

                var elfWithThirdMostCalories = (from elves in elfCalories
                                            orderby elves descending
                                            select elves).Skip(2).First();

                var totalCaloriesTopThree = elfWithMostCalories + elfWithSecondMostCalories + elfWithThirdMostCalories;
                return totalCaloriesTopThree;
            }
        }

        public Day1(string filepath)
        {
            lines = File.ReadAllLines(filepath);
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    numberOfElves++;
                }
            }
            elfCalories = new int[numberOfElves + 1];

            var elfIndex = 0;
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    elfCalories[elfIndex] += int.Parse(line);
                }
                else
                {
                    elfIndex++;
                }
            }
        }
    }
}