using GomSpaceInterview.Simulator.Util;
using System.Text;

namespace GomSpaceInterview.Simulator
{
    public class MatrixStructureHandler
    {
        StringBuilder Sb { get; set; }
        int[,] Matrix { get; set; }
        Machine Machine { get; set; }

        public MatrixStructureHandler(int[,] matrix, Machine machine)
        {
            Sb = new StringBuilder(matrix.Length);
            Matrix = matrix;
            Machine = machine;
        }

        public StringBuilder CreateMatrixStructure()
        {
            for (int col = 0; col < Matrix.GetLength(0); col++)
            {
                for (int row = 0; row < Matrix.GetLength(1); row++)
                {
                    //CreateBorder
                    if ((col == 0) || (col == (Matrix.GetLength(0) - 1) || row == 0 || row == (Matrix.GetLength(1) - 1)))
                    {
                        Sb.Append("X   ");
                    }
                    else
                        CreatePath(col, row);

                }
                Sb.AppendLine();
            }
            return Sb;
        }
        StringBuilder CreatePath(int col, int row)
        {

            //  'b'   represents black square
            //  'w'   represents white square
            //  '↑'    represents upwards
            //  '↓'   represents downwards
            //  '→'   represents right side
            //  '←'   represents left side
            //  '0'    untouch squares
            //  'X'   represents the borders


            if (Machine.ContainsKey(new Position(col, row)))
            {
                Sb.Append(Machine.CurrentCotainsKeyColor == true ? "b" : "w");

                switch (Machine.CurrentCotainsDirection)
                {
                    case Direction.UP:
                        Sb.Append("↑  ");
                        break;
                    case Direction.DOWN:
                        Sb.Append("↓  ");
                        break;
                    case Direction.LEFT:
                        Sb.Append("←  ");
                        break;
                    case Direction.RIGH:
                        Sb.Append("→  ");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // untouch squares
                Sb.Append("0   ");
            }

            return Sb;
        }
    }
}
