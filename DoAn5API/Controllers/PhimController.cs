using System.Collections.Generic;
using System.Linq;
using DoAn5API.Data;
using DoAn5API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoAn5API.Controllers
{
    [Route("api/[controller]")]
    // domen/api/phim/
    public class PhimController : ControllerBase
    {
        private readonly DataContext _db;
        public PhimController(DataContext db)
        {
            _db = db;

        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Phim>> Get()
        {
            var ListPhim=_db.Phims.ToList();
            return Ok(ListPhim);
        }
        [HttpGet]
        public ActionResult<IEnumerable<Phim>> GetbyCate(string ma)
        {

            var ListPhim=_db.Phims.Where(s=>s.MaPhim==ma).ToList();
            return Ok(ListPhim);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Phim> Get(string id)
        {
            var phim=_db.Phims.FirstOrDefault(a=> a.MaPhim==id);
            return Ok(phim);
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