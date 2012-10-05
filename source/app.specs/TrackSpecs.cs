using Machine.Specifications;
using app.CarProject;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
    [Subject(typeof(Track))]
    public class TrackSpecs
    {
        public abstract class track : Observes<ITrack, Track>
        {
            public class The_track_should_know_its_size : track
            {
                private Establish c = () =>
                {

                };

                private Because b = () =>
                    {
                        sut.Width = 5;
                        sut.Length = 5;
                    };

                private It Width = () =>

                    trackWidth.ShouldEqual(5);


                private It Length = () =>
                    trackLength.ShouldEqual(5);

                private static int trackWidth;
                private static int trackLength;
            }

            public class should_track_location_of_car : track
            {
                private Establish c = () =>
                {
                    car = new MicroCar();
                    location = new Point();
                    location.x = 0;
                    location.y = 0;
                };

                private Because b = () =>
                    {
                        
                    };

                private It FindCar = () =>
                    {
                        result.ShouldEqual(location);
                    };

                private static MicroCar car;
                private static Point result;
                private static Point location;
            }
        }

        



        //public class test_to_perform : car
        //{
        //    private Establish c = () =>
        //    {

        //    };

        //    private Because b = () =>
        //    {

        //    };

        //    private It Observed_test = () =>
        //    {

        //    };


        //}
    }
}