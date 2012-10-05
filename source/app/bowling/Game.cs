namespace app.bowling
{
    public class Game:IGame
    {
        public Game()
        {
            _isFinished = false;
        }

        private bool _isFinished;
        private Frame[] _frames = new Frame[10];
        private int frames_count = 0;
        

        public bool The_Game_Is_Finished()
        {
            return _isFinished;
        }

        public void AddFrame(Frame newFrame)
        {
            throw new System.NotImplementedException();
        }

        public int The_Game_Should_Know_The_Score()
        {
            throw new System.NotImplementedException();
        }
    }
}