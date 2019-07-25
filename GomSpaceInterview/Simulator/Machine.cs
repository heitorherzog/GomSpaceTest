using GomSpaceInterview.Simulator.MachineState;
using GomSpaceInterview.Simulator.MachineState.Directions;
using GomSpaceInterview.Simulator.TrackerHandler;
using GomSpaceInterview.Simulator.Util;

namespace GomSpaceInterview.Simulator
{
    public class Machine
    {
        public Position Position { get; private set; }
        public int Col => Position.Col;
        public int Row => Position.Row;
        public bool CurrentCotainsKeyColor => TrackerMachinePositionHandler.CurrentCotainsKeyColor;
        public Direction CurrentCotainsDirection => TrackerMachinePositionHandler.CurrentCotainsDirection;

        IDirectionState MachineState { get; set; }
        Direction Direction { get; set; }
        TrackerMachinePositionHandler TrackerMachinePositionHandler { get; set; }
        public bool ContainsKey(Position position)
        {
            return TrackerMachinePositionHandler.ContainsKey(position);
        }
        public void Move()
        {
            if (TrackerMachinePositionHandler.FlipColor(Position, Direction))
            {
                MoveCounterClockwise();
            }
            else
            {
                MoveClockWise();
            }
        }
        void MoveClockWise()
        {
            MachineState.MoveClockWise(Position);
        }

        void MoveCounterClockwise()
        {
            MachineState.MoveCounterClockwise(Position);
        }

        public Machine(Position p)
        {
            Position = p; //init position
            Direction = Direction.RIGH;   //init direction
            MachineState = new RighDirection();
            MachineState.OnchangeDirectionEvent += UpdateStatus;
            TrackerMachinePositionHandler = new TrackerMachinePositionHandler(Position,Direction);
        }
        void UpdateStatus(Position position, Direction direction, IDirectionState state)
        {
            Position = position;
            Direction = direction;
            UpdateEvents(state);
        }

        void UpdateEvents(IDirectionState newstate)
        {
            MachineState.OnchangeDirectionEvent -= UpdateStatus;
            MachineState = newstate;
            MachineState.OnchangeDirectionEvent += UpdateStatus;
        }
    }
}

