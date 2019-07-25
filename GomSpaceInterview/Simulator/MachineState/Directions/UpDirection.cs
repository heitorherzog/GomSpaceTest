using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator.MachineState.Directions
{
    public class UpDirection : DirectionState, IDirectionState
    {
        public override void MoveCounterClockwise(Position position)
        {
            //left [0][-1]
            var newposition = new Position(position.Col, position.Row - 1);
            UpdateStatus(newposition, Direction.LEFT, new LeftDirection());
        }

        public override void MoveClockWise(Position position)
        {
            //right [0][+1]
            var newposition = new Position(position.Col, position.Row + 1);
            UpdateStatus(newposition, Direction.RIGH, new RighDirection());
        }
    }
}
