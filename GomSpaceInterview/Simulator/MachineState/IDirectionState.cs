using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator.MachineState
{
    
    public interface IDirectionState
    {
        void MoveClockWise(Position position);
        void MoveCounterClockwise(Position position);
        event OnChangingDirection OnchangeDirectionEvent;
    }
}
