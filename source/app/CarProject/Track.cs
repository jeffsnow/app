namespace app.CarProject
{
    public  class Track: ITrack
    {

        public Track()
        {
            _width = 0;
            _length = 0;
        }

        private MicroCar car;


        private int _width;
        private int _length;


        public int Width
        {
            get { return _width; }
            set
            {
                _width = value;
            }
        }

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public Point FindCar()
        {
            return car.should_give_its_location();
        }
    }
}