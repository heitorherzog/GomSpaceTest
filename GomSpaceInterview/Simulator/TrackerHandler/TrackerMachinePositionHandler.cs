using GomSpaceInterview.Simulator.Util;
using System.Collections.Generic;

namespace GomSpaceInterview.Simulator.TrackerHandler
{
    public class TrackerMachinePositionHandler
    {
        Dictionary<Position, TrakerFields> ValuePairs { get; set; }
        public bool CurrentCotainsKeyColor { get; private set; }
        public Direction CurrentCotainsDirection { get; private set; }
        public TrackerMachinePositionHandler(Position p, Direction direction)
        {
            ValuePairs = new Dictionary<Position, TrakerFields>();
         
            //save init position and first square is white
            ValuePairs.Add(p, new TrakerFields(isblack: false, direction));
        }
        void Add(Position p, bool isBlack, Direction direction)
        {
            ValuePairs.Add(p, new TrakerFields(isBlack, direction));
        }
        public bool FlipColor(Position p, Direction newdirection)
        {
            bool IsBlack = true;

            if (ValuePairs.ContainsKey(p))
            {
                //FlipColor
                var direction = ValuePairs[p].Direction;
                var Isblack = !ValuePairs[p].Isblack;

                ValuePairs[p] = new TrakerFields(Isblack, direction);
                IsBlack = ValuePairs[p].Isblack;
            }
            else
            {
                Add(p, isBlack: IsBlack, newdirection);
            }

            return IsBlack;
        }
        public bool ContainsKey(Position p)
        {
            if (ValuePairs.ContainsKey(p))
            {
                CurrentCotainsKeyColor = ValuePairs[p].Isblack;
                CurrentCotainsDirection = ValuePairs[p].Direction;
                return true;
            }
            return false;
        }

    }
}
