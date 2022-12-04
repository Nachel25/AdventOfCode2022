namespace Day1
{
    public class Day1
    {
        private readonly string[] lines;
        private int elfWithMostCalories;
        private int elfWithSecondMostCalories;
        private int elfWithThirdMostCalories;
        private int totalCaloriesTopOne;
        private int totalCaloriesTopThree;
        private readonly int numberOfElves;
        private readonly int[] elfCalories;

        public int TotalCaloriesTopOne
        {
            get
            {
                elfWithMostCalories = (from elves in elfCalories
                                       orderby elves descending
                                       select elves).First();
                totalCaloriesTopOne = elfWithMostCalories;
                return totalCaloriesTopOne;
            }
        }

        public int TotalCaloriesTopThree
        {
            get
            {
                elfWithMostCalories = (from elves in elfCalories
                                       orderby elves descending
                                       select elves).First();

                elfWithSecondMostCalories = (from elves in elfCalories
                                             orderby elves descending
                                             select elves).Skip(1).First();

                elfWithThirdMostCalories = (from elves in elfCalories
                                            orderby elves descending
                                            select elves).Skip(2).First();

                totalCaloriesTopThree = elfWithMostCalories + elfWithSecondMostCalories + elfWithThirdMostCalories;
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



//old constructor
//public Day1(string filepath)
//{
//    lines = File.ReadAllLines(filepath);
//    foreach (var line in lines)
//    {
//        if (string.IsNullOrEmpty(line))
//        {
//            numberOfElves++;
//        }
//    }
//    elfCalories = new int[numberOfElves + 1];
//}



//old version part 1
//var elfIndex = 0;
//foreach (var line in lines)
//{
//    if (!string.IsNullOrEmpty(line))
//    {
//        elfCalories[elfIndex] += int.Parse(line);
//    }
//    else
//    {
//        elfIndex++;
//    }
//}
//totalCaloriesTopOne = elfCalories.Max();
//return totalCaloriesTopOne;



//old version part 2
//elfCalories = new int[numberOfElves + 1];
//var elfIndex = 0;
//foreach (var line in lines)
//{
//    if (!string.IsNullOrEmpty(line))
//    {
//        elfCalories[elfIndex] += int.Parse(line);
//    }
//    else
//    {
//        elfIndex++;
//    }
//    elfWithMostCalories = elfCalories.Max();
//}

//elfWithMostCalories = (from elves in elfCalories
//                       orderby elves descending
//                       select elves).First();

//elfWithSecondMostCalories = (from elves in elfCalories
//                             orderby elves descending
//                             select elves).Skip(1).First();

//elfWithThirdMostCalories = (from elves in elfCalories
//                            orderby elves descending
//                            select elves).Skip(2).First();

//totalCaloriesTopThree = elfWithMostCalories + elfWithSecondMostCalories + elfWithThirdMostCalories;
//return totalCaloriesTopThree;