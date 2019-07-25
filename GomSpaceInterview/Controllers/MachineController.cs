using Microsoft.AspNetCore.Mvc;
using System.IO;
using GomSpaceInterview.Simulator;

namespace GomSpaceInterview.Controllers
{
    /// <summary>
    /// MachineController
    /// </summary>
    [Produces("application/octet-stream")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class MachineController : ControllerBase
    {
        /// <summary> Simulates machine interactions on grid </summary>
        /// <remarks>
        /// 
        ///  The grid is initially all white and there is a machine in one cell facing right. It will move based on the following rules:
        ///  If the machine is in a white square, turn 90° clockwise and move forward 1 unit;     
        ///  If the machine is in a black square, turn 90° counter-clockwise and move forward 1 unit;
        ///  At every move flip the color of the base square.
        ///  <b>
        ///  'b'   represents black square
        ///  'w'   represents white square
        ///  '↑'    represents upwards
        ///  '↓'   represents downwards
        ///  '→'   represents right side
        ///  '←'   represents left side
        ///  '0'    untouch squares
        ///  'X'   represents the borders
        ///   </b>
        ///    
        /// </remarks>
        /// <param name="input">range between 1 and 1000</param>
        ///  <type></type>
        /// <returns>This Method will output a txt file with the representation of the process .</returns>
        /// <response code="200">Return txt file</response>
        /// <response code="400">input was below or aborve the requirements</response>
        [HttpPut("{input:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult Put(int input)
        {
            if (input <= 0 || input > 1000)
                return BadRequest();

            using (var memStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memStream))
            {
                var result = MachineSimulator.Simulate(input);
                streamWriter.Write(result);
                streamWriter.Flush();

                return File(memStream.ToArray(), "application/octet-stream", "machine.txt");
            }
        }
    }
}
