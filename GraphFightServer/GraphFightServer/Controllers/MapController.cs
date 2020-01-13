using GraphFightCommon;
using GraphFightCommon.Serializers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> GetMap()
        {
            if (MasterGameController.TheGame.Map == null)
            {
                return NotFound();
            }
            return await Task.Run(() => MapSerializer.Serialize(MasterGameController.TheGame.Map));
        }

        [HttpPost]
        public async Task<ActionResult> SetMap()
        {
            using (StreamReader streamReader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                string json = await streamReader.ReadToEndAsync();
                await Task.Run(() => MasterGameController.TheGame.Map = MapSerializer.Deserialize(json, MasterGameController.TheGame.Tiles));
            }
            return Ok();
        }
    }
}