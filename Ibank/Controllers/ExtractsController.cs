using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ibank.Data;
using Ibank.Models;

namespace Ibank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtractsController : ControllerBase
    {
        private readonly IbankContext _context;

        public ExtractsController(IbankContext context)
        {
            _context = context;
        }

        // GET: api/Extracts
        [HttpGet]
        public IEnumerable<Extract> GetExtract()
        {
            return _context.Extract;
        }

        // GET: api/Extracts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetExtract([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var extract = await _context.Extract.FindAsync(id);

            if (extract == null)
            {
                return NotFound();
            }

            return Ok(extract);
        }

        // PUT: api/Extracts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExtract([FromRoute] int id, [FromBody] Extract extract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != extract.Id)
            {
                return BadRequest();
            }

            _context.Entry(extract).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExtractExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Extracts
        [HttpPost]
        public async Task<IActionResult> PostExtract([FromBody] Extract extract)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Extract.Add(extract);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExtract", new { id = extract.Id }, extract);
        }

        // DELETE: api/Extracts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExtract([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var extract = await _context.Extract.FindAsync(id);
            if (extract == null)
            {
                return NotFound();
            }

            _context.Extract.Remove(extract);
            await _context.SaveChangesAsync();

            return Ok(extract);
        }

        private bool ExtractExists(int id)
        {
            return _context.Extract.Any(e => e.Id == id);
        }
    }
}