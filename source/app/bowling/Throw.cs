namespace app.bowling
{
    public class Throw:IThrow
    {

        public int TotalPinsLeft(int pinsStart, int fallenPins)
        {
            return pinsStart - fallenPins;
        }
    }

}