using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator.MachineState
{
    public abstract class DirectionState : IDirectionState
    {
        public event OnChangingDirection OnchangeDirectionEvent;
        public abstract void MoveCounterClockwise(Position position);
        public abstract void MoveClockWise(Position position);
        protected void UpdateStatus(Position position, Direction direction, IDirectionState state)
        {
            OnchangeDirectionEvent?.Invoke(position, direction, state);
        }
    }
}
