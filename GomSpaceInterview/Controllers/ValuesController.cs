using Microsoft.AspNetCore.Mvc;
using System.IO;

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
        ///  '^'    represents upwards
        ///  '-'   represents downwards
        ///  '→'   represents right side
        ///  '←'   represents left side
        ///  '0'    untouch squares
        ///  'x'   represents the borders
        ///   </b>
        ///    
        /// </remarks>
        /// <param name="interations"> insert a range between 1 and 1000</param>
        ///  <type></type>
        /// <returns>This Method will output a txt file with the representation of the process .</returns>
        /// <response code="200">Return txt file</response>
        [HttpPut("{interations:int}")]
        [ProducesResponseType(200)]
        public ActionResult Put(int interations)
        {

            using (var memStream = new MemoryStream())
            using (var streamWriter = new StreamWriter(memStream))
            {
                for (int i = 0; i < 6; i++)
                    streamWriter.WriteLine("TEST");

                streamWriter.Flush();
                return File(memStream.ToArray(), "application/octet-stream", "machine.txt");
            }

            //return "value";
        }


        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
