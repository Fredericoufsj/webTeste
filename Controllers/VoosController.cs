#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webTeste.Models;

namespace webTeste.Controllers
{
    public class VoosController : Controller
    {
        private readonly Context _context;

        public VoosController(Context context)
        {
            _context = context;
        }

        // GET: Voos
        public async Task<IActionResult> Index()
        {
            return View(await _context.voos.ToListAsync());
        }

        // GET: Voos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.voos
                .FirstOrDefaultAsync(m => m.Id_Voo == id);
            if (voo == null)
            {
                return NotFound();
            }

            return View(voo);
        }

        // GET: Voos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Voo,Data_Partida,Data_Retorno,Destino,Id_cliente")] Voo voo)
        {
            
                _context.Add(voo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            
            
        }

        // GET: Voos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.voos.FindAsync(id);
            if (voo == null)
            {
                return NotFound();
            }
            return View(voo);
        }

        // POST: Voos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Voo,Data_Partida,Data_Retorno,Destino,Id_cliente")] Voo voo)
        {
            if (id != voo.Id_Voo)
            {
                return NotFound();
            }

            
                try
                {
                    _context.Update(voo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VooExists(voo.Id_Voo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
      

        // GET: Voos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.voos
                .FirstOrDefaultAsync(m => m.Id_Voo == id);
            if (voo == null)
            {
                return NotFound();
            }

            return View(voo);
        }

        // POST: Voos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voo = await _context.voos.FindAsync(id);
            _context.voos.Remove(voo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VooExists(int id)
        {
            return _context.voos.Any(e => e.Id_Voo == id);
        }
    }
}
