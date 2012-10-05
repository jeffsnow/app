namespace app.CarProject
{
    public interface IMicroCar
    {
        void Move(int p1, int p2, char[] movements);
        string should_give_its_location();
    }

    public interface ITrack
    {
        int Width { get; set; }
        int Length { get; set; }
        Point FindCar(MicroCar car);
    }

    public interface ITurn
    {
        string MakeATurn(char T);
    }
}
