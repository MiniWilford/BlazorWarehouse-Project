using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseClassLibraryMVC.Data;
using WarehouseClassLibraryMVC.Entities;
using WarehouseModels;

namespace WarehouseWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly WarehouseContext _context;

        public CompaniesController(WarehouseContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompaniesViewModel>>> GetCompanys()
        {
          if (_context.Companys == null)
          {
              return NotFound();
          }

          List<CompaniesViewModel> companyViewModels = new List<CompaniesViewModel>();

          var companies = await _context.Companys.ToListAsync();

            foreach (var company in companies)
            {
                var companyView = new CompaniesViewModel
                {
                    CompanyId = company.CompanyId,
                    CompanyName = company.CompanyName,
                    Address = company.Address,
                    City = company.City,
                    State = company.State,
                    PostalCode = company.PostalCode,
                };

                companyViewModels.Add(companyView);
            }


            return companyViewModels;
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
          if (_context.Companys == null)
          {
              return NotFound();
          }
            var company = await _context.Companys.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            return company;
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if (id != company.CompanyId)
            {
                return BadRequest();
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
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

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
          if (_context.Companys == null)
          {
              return Problem("Entity set 'WarehouseContext.Companys'  is null.");
          }
            _context.Companys.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompany", new { id = company.CompanyId }, company);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            if (_context.Companys == null)
            {
                return NotFound();
            }
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companys.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompanyExists(int id)
        {
            return (_context.Companys?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
