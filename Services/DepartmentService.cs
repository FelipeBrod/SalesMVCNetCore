using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() //declara-se o metodo como assincrono, desta forma nao sera bloqueada a aplicacao
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); //await informa o compilador que vai ser uma chamada assincrona
        }
    }
}
