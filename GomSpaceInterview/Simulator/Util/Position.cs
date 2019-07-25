namespace GomSpaceInterview.Simulator.Util
{
    public struct Position
    {
        public int Col { get; private set; }
        public int Row { get; private set; }

        public Position(int col, int row)
        {
            Col = col;
            Row = row;
        }
        public static bool operator ==(Position a, Position b)
        {
            return (a.Col == b.Col && a.Row == b.Row);
        }
        public static bool operator !=(Position a, Position b)
        {
            return (a.Col != b.Col && a.Row != b.Row);
        }
        public override bool Equals(object obj)
        {
            return ((Position)obj).Col == Col && ((Position)obj).Row == Row;
        }
    }
}
