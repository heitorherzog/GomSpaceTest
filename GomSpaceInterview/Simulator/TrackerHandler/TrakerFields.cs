using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator.TrackerHandler
{
    public class TrakerFields
    {
        public TrakerFields(bool isblack, Direction direction)
        {
            Isblack = isblack;
            Direction = direction;
        }
        public bool Isblack { get; private set; }
        public Direction Direction { get; private set; }
    }
}
