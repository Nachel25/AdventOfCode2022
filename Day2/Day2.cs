namespace Day2
{
    public class Day2
    {
        private readonly List<string> _inputAsList;
        private List<string> _roundChoices;
        private bool _rock;
        private bool _paper;
        private bool _scissors;
        private bool _rockOpponent;
        private bool _paperOpponent;
        private bool _scissorsOpponent;

        private int _score;
        public int Score
        {
            get
            {
                foreach (var round in _inputAsList)
                {
                    _roundChoices = round.Split(' ').ToList();
                    _rock = _paper = _scissors = _rockOpponent = _paperOpponent = _scissorsOpponent = false;

                    if (_roundChoices[1] == "X") _rock = true;
                    if (_roundChoices[1] == "Y") _paper = true;
                    if (_roundChoices[1] == "Z") _scissors = true;

                    if (_roundChoices[0] == "A") _rockOpponent = true;
                    if (_roundChoices[0] == "B") _paperOpponent = true;
                    if (_roundChoices[0] == "C") _scissorsOpponent = true;

                    if (_rock && _rockOpponent) _score += 3;
                    if (_rock && _paperOpponent) _score += 0;
                    if (_rock && _scissorsOpponent) _score += 6;

                    if (_paper && _rockOpponent) _score += 6;
                    if (_paper && _paperOpponent) _score += 3;
                    if (_paper && _scissorsOpponent) _score += 0;

                    if (_scissors && _rockOpponent) _score += 0;
                    if (_scissors && _paperOpponent) _score += 6;
                    if (_scissors && _scissorsOpponent) _score += 3;

                    if (_rock) _score += 1;
                    if (_paper) _score += 2;
                    if (_scissors) _score += 3;
                }
                return _score;
            }
        }

        private int _scoreAdjusted;
        public int ScoreAdjusted
        {
            get
            {
                foreach (var round in _inputAsList)
                {
                    _roundChoices = round.Split(' ').ToList();
                    _rock = _paper = _scissors = _rockOpponent = _paperOpponent = _scissorsOpponent = false;

                    if (_roundChoices[0] == "A") _rockOpponent = true;
                    if (_roundChoices[0] == "B") _paperOpponent = true;
                    if (_roundChoices[0] == "C") _scissorsOpponent = true;

                    if (_roundChoices[1] == "X")
                    {
                        _scoreAdjusted += 0;
                        if (_rockOpponent) _scissors = true;
                        if (_paperOpponent) _rock = true;
                        if (_scissorsOpponent) _paper = true;
                    }
                    if (_roundChoices[1] == "Y")
                    {
                        _scoreAdjusted += 3;
                        if (_rockOpponent) _rock = true;
                        if (_paperOpponent) _paper = true;
                        if (_scissorsOpponent) _scissors = true;
                    }
                    if (_roundChoices[1] == "Z")
                    {
                        _scoreAdjusted += 6;
                        if (_rockOpponent) _paper = true;
                        if (_paperOpponent) _scissors = true;
                        if (_scissorsOpponent) _rock = true;
                    }

                    if (_rock) _scoreAdjusted += 1;
                    if (_paper) _scoreAdjusted += 2;
                    if (_scissors) _scoreAdjusted += 3;
                }
                return _scoreAdjusted;
            }
        }

        public Day2(string filepath)
        {
            _inputAsList = File.ReadAllLines(filepath).ToList();
            _roundChoices = new List<string>();
        }
    }
}