using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PhimController:Controller
    {
        private readonly AppDbContext _db;
        public PhimController(AppDbContext db){
            _db=db;
        }
        [HttpGet("[action]")]
    public IActionResult GetAll(){
        return Ok(_db.Phims.ToList());
        }
        [HttpPost("[action]")]
        //[Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> AddPhim([FromBody] PhimModel formdata) 
        {
            var newphim = new PhimModel
            {
                
                TenPhim = formdata.TenPhim,
                SoTap = formdata.SoTap,
                Nam = formdata.Nam,
                Anh = formdata.Anh,
                NoiDung = formdata.NoiDung,
                LuotXem = formdata.LuotXem
            };

            await _db.Phims.AddAsync(newphim);

            await _db.SaveChangesAsync();

            return Ok(new JsonResult("Thêm thành công"));

         }

        
        [HttpPut("[action]/{id}")]
        //[Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> UpdatePhim([FromRoute] int id, [FromBody] PhimModel formdata) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            var findPhim = _db.Phims.FirstOrDefault(p => p.MaPhim == id);

            if (findPhim == null)
            {
                return NotFound();
            }

            // If the product was found
            findPhim.TenPhim = formdata.TenPhim;
                findPhim.SoTap = formdata.SoTap;
                findPhim.Nam = formdata.Nam;
                findPhim.Anh = formdata.Anh;
                findPhim.NoiDung = formdata.NoiDung;
                findPhim.LuotXem = formdata.LuotXem;

            _db.Entry(findPhim).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return Ok(new JsonResult("Update thành công phim có mã " + id + ""));

        }


        [HttpDelete("[action]/{id}")]
        //[Authorize(Policy = "RequireAdministratorRole")]
        public async Task<IActionResult> DeletePhim([FromRoute] string id) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // find the product

            var findPhim = await _db.Phims.FindAsync(id);

            if (findPhim == null)
            {
                return NotFound();
            }

            _db.Phims.Remove(findPhim);

            await _db.SaveChangesAsync();

            // Finally return the result to client
            return Ok(new JsonResult("Xóa thành công phim có mã " + id + ""));

        }
    }
}