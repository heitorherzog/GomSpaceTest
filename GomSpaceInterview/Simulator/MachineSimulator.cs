using GomSpaceInterview.Simulator.Util;
using System.Text;

namespace GomSpaceInterview.Simulator
{
    public class MachineSimulator
    {
        public static StringBuilder Simulate(int interations)
        {
            //matrix size
            int[,] matrix = new int[31, 31];
            //starting point, middle of the matrix
            var machine = new Machine(new Position(15, 15));

            //moving machine base on the number of interations provided
            for (int i = 0; i < interations; i++)
            {
                machine.Move();
            }

            MatrixStructureHandler structureHandler = new MatrixStructureHandler(matrix, machine);
            return structureHandler.CreateMatrixStructure();
        }
    }
}





