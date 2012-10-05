using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using app.bowling;
using developwithpassion.specifications.rhinomocks;
using Machine.Specifications;

namespace app.specs.utility
{
    class BowlingSpecs
    {
        public class ThrowSpecs
        {
            public abstract class ThrowRequirements : Observes<IThrow, Throw>
            {
            }

            public class when_a_player_throws_a_ball : ThrowRequirements
            {
                Establish c = () =>
                {
                    original_pins = 10;
                    fallen_pins = 5;
                };

                Because b = () =>
                    result = sut.TotalPinsLeft(original_pins, fallen_pins);

                It should_return_number_of_pins_knocked_down = () =>
                    result.ShouldEqual(5);

                private static int original_pins;
                private static int pins_left_standing;
                private static int fallen_pins;
                private static int result;

            }
        }



        public abstract class FrameRequirements : Observes<IFrame, Frame>
        {
            public class when_a_player_throws_a_strike : FrameRequirements
            {
                private Establish c = () =>
                    {


                    };
                private Because b = () =>
                        sut.ScoreThrow(10);

                private It Is_A_Strike = () =>
                    result.ShouldBeTrue();


                private static bool result;
            }

            public class when_a_player_throws_a_spare : FrameRequirements
            {
                private Establish c = () =>
                    {
                        SpareFrame = new Frame(1);
                        SpareFrame.ScoreThrow(5);
                        result = false;
                    };

                private Because b = () =>
                        SpareFrame.ScoreThrow( 5);

                private It Is_A_Spare = () =>
                        result.ShouldBeTrue();


                private static Frame SpareFrame;
                private static bool result;
            }

            public class when_a_player_completes_a_frame : FrameRequirements
            {
                private Establish c = () =>
                    {
                        CompleteFrame = new Frame(1);
                        CompleteFrame.ScoreThrow(5);

                    };

                private Because b = () =>
                                     CompleteFrame.ScoreThrow(2);

                private It Is_Complete = () =>
                                         result.ShouldBeTrue();
                private static Frame CompleteFrame;
                private static bool result;
            }

            public class when_bowling_10th_frame_with_strike_spare_frame_does_not_end_until_3_throw : FrameRequirements
            {
                private Establish c = () =>
                    {
                        CompleteFrame = new Frame(10);
                        CompleteFrame.ScoreThrow(10);
                        CompleteFrame.ScoreThrow(10);

                    };

                private It Go_To_Next_Frame = () =>
                                              result.ShouldBeFalse();

                private static Frame CompleteFrame;
                private static bool result;
            }
        }

        public abstract class GameRequirements: Observes<IGame,Game>
        {
            public class the_game_consist_of_10_frames : GameRequirements
            {

                private Establish c = () =>
                    { };

                private It All_Frames = () =>
                                        result.ShouldEqual(10);

                private static int result;
            }

            public class the_game_ends_after_the_10_frame :GameRequirements
            {
                private Establish c = () =>
                    {
                        tenthFrame = new Frame(10);
                        tenthFrame.ScoreThrow(1); //1st throw
                        tenthFrame.ScoreThrow(1); //2nd throw
                        
                    };

                private It The_Game_Is_Finished = () =>
                                                  result.ShouldBeTrue();

                private static bool result;
                private static Frame tenthFrame;
            }

            public class the_game_should_count_frames:GameRequirements
            {
                private Establish c = () =>
                    {
                        sut.AddFrame(new Frame(1));
                        sut.AddFrame(new Frame(2));
                        sut.AddFrame(new Frame(3));
                    };

                     private Because b = () =>
                                     {};

                private It The_game_knows_the_current_number_of_frames = () =>
                                                                         sut.ShouldEqual(3);

                
            }

            public class the_game_should_track_the_score: GameRequirements
            {
                private Establish c = () =>
                    {oneFrame= new Frame(1);
                        twoFrame = new Frame(2);
                        threeFrame = new Frame(3);
                        
                        oneFrame.ScoreThrow(10);
                        oneFrame.ScoreThrow(10);
                        oneFrame.ScoreThrow(2);
                        oneFrame.ScoreThrow(4);
                        twoFrame.ScoreThrow(10);
                        twoFrame.ScoreThrow(2);
                        twoFrame.ScoreThrow(4);
                        threeFrame.ScoreThrow(2);
                        threeFrame.ScoreThrow(4);
                        
                        sut.AddFrame(oneFrame);
                        sut.AddFrame(twoFrame);
                        sut.AddFrame(threeFrame);
                        

                    };

                private Because b = () =>
                    { };

                private It The_Game_Should_Know_The_Score = () =>
                                                            result.ShouldEqual(44);

                     private static Frame oneFrame;
                private static Frame twoFrame;
                private static Frame threeFrame;
                private static int result;

            }
        }

    }
}
