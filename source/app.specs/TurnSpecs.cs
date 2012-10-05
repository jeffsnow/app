using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using app.CarProject;

namespace app.specs
{


    [Subject(typeof(CarProject.Turn))]
    public class TurnSpecs
    {
        public abstract class turnIt : Observes<ITurn, Turn>
        {
            public class change_the_direction : Turn
            {
                private Establish c = () =>
                    {
                        car = new MicroCar();//Pointing N by default
                        expectedResult = 'E';
                    };

                private Because b = () =>
                    {
                        sut.TurnLeft;
                    };

                private It New_Direction = () =>
                    {
                        result.ShouldBe(expectedResult);
                    };

                private static MicroCar car;
                private static Char expectedResult;
                private static Char result;
            }
        }


        //}
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

