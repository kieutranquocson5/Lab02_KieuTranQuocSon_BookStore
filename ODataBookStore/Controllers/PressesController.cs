using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using ODataBookStore.EDM;
using System;

namespace ODataBookStore.Controllers
{
	public class PressesController : ODataController
	{
		private readonly ApplicationDbContext _context;

		public PressesController(ApplicationDbContext context)
		{
			_context = context;
		}

		[EnableQuery]
		public async Task<IActionResult> Get()
		{
			var presses = await _context.Presses.ToListAsync();
			return Ok(presses);
		}
	}
}
