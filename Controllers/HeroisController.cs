using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectC.Models;
using projectC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace projectC.Controllers
{
    public class HeroisController : Controller
    {
        //Get Herois
        private readonly HeroisServices _heroiService;

        public HeroisController(HeroisServices heroiService)
        {
            _heroiService = heroiService;
        }

        [HttpGet]
        public ActionResult<List<HeroisDCMarvel>> Get() =>
            _heroiService.Get();

        [HttpGet("{id:length(24)}", Name = "GetHeroi")]
        public ActionResult<HeroisDCMarvel> Get(string id)
        {
            var heroi = _heroiService.Get(id);

            if (heroi == null)
            {
                return NotFound();
            }

            return heroi;
        }

        [HttpPost]
        public ActionResult<HeroisDCMarvel> Create(HeroisDCMarvel heroi)
        {
            _heroiService.Create(heroi);

            return CreatedAtRoute("GetHeroi", new { id = heroi.Id.ToString() }, heroi);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, HeroisDCMarvel heroisIn)
        {
            var heroi = _heroiService.Get(id);

            if (heroi == null)
            {
                return NotFound();
            }

            _heroiService.Update(id, heroisIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var heroi = _heroiService.Get(id);

            if (heroi == null)
            {
                return NotFound();
            }

            _heroiService.Remove(heroi.Id);

            return NoContent();
        }
    }
}