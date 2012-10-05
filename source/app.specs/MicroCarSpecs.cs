using Machine.Specifications;
using System.ComponentModel;
using app.CarProject;
using developwithpassion.specifications.rhinomocks;


namespace app.specs
{

    [Subject(typeof(CarProject.MicroCar))]
    public class MicroCarSpecs
    {
        public abstract class car : Observes<IMicroCar, CarProject.MicroCar>
        {
            public class when_a_car_stops : car
            {
                private Establish c = () =>
                    {
                        movements = "R2R3L1".ToCharArray();
                    };

                private Because b = () =>

                { sut.Move(0, 0, movements); };

                It should_give_its_location = () =>
                  result.ShouldEqual("E 3,3");

                public static char[] movements;
                public static Point result;
                public static Point setPoint;
            }

            public class When_a_car_runs_off_track : car
            {
                private Establish c = () =>
                    {
                        movements = "L2".ToCharArray();
                    };

                private Because b = () =>

                    {
                        sut.Move(2, 1, movements);
                    };

                private It Observed_test = () =>
                    {
                        results.ShouldEqual("Fell off track");
                    };

                public static char[] movements;
                public static string results;
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
}
