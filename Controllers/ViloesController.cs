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
    [Route("api/[controller]")]
    [ApiController]

    public class ViloesController : Controller
    {
        private readonly ViloesServices _viloesService;

        public ViloesController(ViloesServices vilaoService)
        {
            _viloesService = vilaoService;
        }

        [HttpGet]
        public ActionResult<List<Viloes>> Get() =>
            _viloesService.Get();

        [HttpGet("{id:length(24)}", Name = "GetVilao")]
        public ActionResult<Viloes> Get(string id)
        {
            var vilao = _viloesService.Get(id);

            if (vilao == null)
            {
                return NotFound();
            }

            return vilao;
        }

        [HttpPost]
        public ActionResult<Viloes> Create(Viloes vilao)
        {
            _viloesService.Create(vilao);

            return CreatedAtRoute("Getvilao", new { id = vilao.Id.ToString() }, vilao);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Viloes viloesIn)
        {
            var vilao = _viloesService.Get(id);

            if (vilao == null)
            {
                return NotFound();
            }

            _viloesService.Update(id, viloesIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var vilao = _viloesService.Get(id);

            if (vilao == null)
            {
                return NotFound();
            }

            _viloesService.Remove(vilao.Id);

            return NoContent();
        }

    }
}