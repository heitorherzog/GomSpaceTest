using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator.MachineState.Directions
{
    public class RighDirection : DirectionState, IDirectionState
    {
        public override void MoveCounterClockwise(Position position)
        {
            //up [-1][0]
            var newposition = new Position(position.Col - 1, position.Row);
            UpdateStatus(newposition, Direction.UP, new UpDirection());
        }

        public override void MoveClockWise(Position position)
        {
            //down [+1][0]
            var newposition = new Position(position.Col + 1, position.Row);
            UpdateStatus(newposition, Direction.DOWN, new DownDirection());
        }
    }
}
