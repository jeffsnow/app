using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using app.core.containers;

namespace app.bowling
{
    public class Bowling
    {
    }


    public interface IThrow
    {
        int TotalPinsLeft(int pinsStart, int fallenPins);
    }

    public interface IGame
    {
        bool The_Game_Is_Finished();
        void AddFrame(Frame newFrame);
        int The_Game_Should_Know_The_Score();
    }

    public interface IFrame
    {
        void ScoreThrow(int pins_knocked_down);
        int Return_Score();
        bool Is_A_Strike();
        bool Is_A_Spare();
        bool ThrowsComplete();
        bool Go_To_Next_Frame();
        int Frame { get; }
    }


}
