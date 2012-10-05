namespace app.bowling
{
    public class Frame : IFrame
    {
        public Frame(int frame)
        {
            _score = 0;
            _isStrike = false;
            _isSpare = false;
            _isComplete = false;
            _throwNumber = 0;
            _frame = frame;
            _allowedThrows = 2;
        }

        private int _allowedThrows;
        private int _throwNumber;
        private int _score;
        private bool _isStrike;
        private bool _isComplete;
        private bool _startNextFrame;
        private bool _isSpare;
        private int _frame;

        public void ScoreThrow(int pins_knocked_down)
        {
            _throwNumber++;
            if (!_isComplete) //Scoring is locked...Done!  Complete
            {
                _score += pins_knocked_down;
                if ((_score == 10) && (_throwNumber == 1))
                {
                    _isStrike = true;
                    _allowedThrows++; //3
                    SpecialCase10Frame();


                }
                else if (_throwNumber == 2 && _score == 10 && !_isSpare)
                {
                    _isSpare = true;
                    _allowedThrows++; //3
                    SpecialCase10Frame();
                }
                if (_throwNumber == _allowedThrows)
                {
                    _isComplete = true;
                }

            }
        }

        private void SpecialCase10Frame()
        {
            if (_frame != 10)
            {
                _startNextFrame = true;
            }
        }

        public int Return_Score()
        {
            return _score;
        }

        public bool Is_A_Strike()
        {
            return _isStrike;
        }

        public bool Is_A_Spare()
        {
            return _isSpare;
        }

        public bool ThrowsComplete()
        {
            throw new System.NotImplementedException();
        }

        public bool Is_Complete()
        {
            throw new System.NotImplementedException();
        }

        public bool Go_To_Next_Frame()
        {
            return _startNextFrame;
        }

        int IFrame.Frame
        {
            get
            {
                return _frame;
            }

        }
    }
}