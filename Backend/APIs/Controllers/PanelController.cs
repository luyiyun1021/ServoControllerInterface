using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIs.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Http;
using APIs.HubConfig;
using APIs.TimerFeatures;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PanelController : Controller
    {
        Panel panel = new Panel();

        // intialize PanelController with hub
        private readonly IHubContext<MyHub> _hub;
        private readonly TimerManager _timer;

        public PanelController(IHubContext<MyHub> hub, TimerManager timer)
        {
            _hub = hub;
            _timer = timer;
        }

        // GET: /<controller>/
        [HttpGet]
        //public List<ErrorMessage> Index()
        //{
        //    panel.ReadAllData();
        //    panel.TestConnection();
        //    return panel.ReportAllErrors();
        //}
        public IActionResult Index()
        {
            if (!_timer.IsTimerStarted)
            {

                //panel.ReadAllData();
                //panel.TestConnection();
                _timer.PrepareTimer(() => _hub.Clients.All.SendAsync("TransferTableData", panel.TransferDataWrapper()));
                //_timer.PrepareTimer(() => _hub.Clients.All.SendAsync("TransferTableData", DataManager.GetData()));
                //try
                //{
                //    _hubContext.Clients.All.SendAsync("TransferTableData", panel.ReportAllErrors());
                //    rstMessage = Ok(new { Message = "Request completed" });
                //}
                //catch (Exception e)
                //{
                //    rstMessage = Ok(new { Message = e.ToString() });
                //}
            }

            return Ok(new { Message = "Request completed" });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
