using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Context;
using App.Models;
using App.Filters; 
using X.PagedList;
using System.Xml;
using System.Text;

namespace Grafico.Controllers
{
    [Area("Admin")]
    [AdminAuthorize]
    public class PaisController : Controller
    {
        private readonly AppDbContext _context;

        public PaisController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Pais
        public IActionResult Index (string botao, string? txtFiltro, string? selOrdenacao, int pagina = 1)
        {

            int pageSize = 5; // Número de intens por página

            IQueryable<Pais> lista = _context.Paises.Include(p => p.Continente);

              if (botao == "Relatorio")
              {
                pageSize = lista.Count();
              }

              if (txtFiltro != null && txtFiltro != "")

              {
                ViewData["txtFiltro"] = txtFiltro;
                  lista = lista.Where(item => item.Nome.ToLower().Contains(txtFiltro.ToLower()));
              }

              if (selOrdenacao == "Nome" || selOrdenacao == null)
              {
                lista = lista.OrderBy(item => item.Nome);
              }
              else if (selOrdenacao == "Capital")
              {
                lista = lista.OrderBy(item => item.Capital.ToLower());
              }
              else if (selOrdenacao == "Menor_Populacao")
              {
                lista = lista.OrderBy(item => item.Populacao);
              }
              else if (selOrdenacao == "Maior_Populacao")
              {
                lista = lista.OrderByDescending(item => item.Populacao);
              }
              else if (selOrdenacao == "Continente")
              {
                lista = lista.OrderBy(item => item.Continente.Nome.ToLower());
              }

              ViewData["Ordem"] = selOrdenacao;
              
             //verificando se o botao clicando foi Xml
             if (botao == "XML")
             {
                return ExportarXML(lista.ToList());
             }
             
              return View(lista.ToPagedList(pagina, pageSize));   

            
        }

        // GET: Pais/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // GET: Pais/Create
        public IActionResult Create()
        {
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome");
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pais pais)
        {
            _context.Add(pais);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        // GET: Pais/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises.Find(id);
            if (pais == null)
            {
                return NotFound();
            }
            ViewData["continenteID"] = new SelectList(_context.Continentes, "continenteID", "Nome", pais.continenteID);
            return View(pais);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Pais pais)
        {
            if (id != pais.IdPaises)
            {
                return NotFound();
            }

            try
            {
                _context.Update(pais);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaisExists(pais.IdPaises))
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

        // GET: Pais/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null || _context.Paises == null)
            {
                return NotFound();
            }

            var pais = _context.Paises
                .Include(p => p.Continente)
                .FirstOrDefault(m => m.IdPaises == id);
            if (pais == null)
            {
                return NotFound();
            }

            return View(pais);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_context.Paises == null)
            {
                return Problem("Entity set 'AppDbContext.Paises'  is null.");
            }
            var pais = _context.Paises.Find(id);
            if (pais != null)
            {
                _context.Paises.Remove(pais);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool PaisExists(int id)
        {
            return (_context.Paises?.Any(e => e.IdPaises == id)).GetValueOrDefault();
        }

        public  IActionResult Grafico()
        {
            return View();
        }

         public IActionResult ObterDadosParaGrafico()
        {
            var dados = _context.Paises.ToList();
            return Json(dados);
        }

        private IActionResult ExportarXML(List<Usuario> lista)
{
var stream = new StringWriter();
var xml = new XmlTextWriter(stream);
xml.Formatting = System.Xml.Formatting.Indented;
xml.WriteStartDocument();
xml.WriteStartElement("Dados");
xml.WriteStartElement("Usuários");
foreach (var item in lista)
{
xml.WriteStartElement("Usuário");
xml.WriteElementString("Id", item.UsuarioId.ToString());
xml.WriteElementString("Nome", item.Nome);
xml.WriteElementString("Login", item.Login);
xml.WriteEndElement(); // </Usuario>
}
xml.WriteEndElement(); // </Usuarios>
xml.WriteEndElement(); // </Dados>
return File(Encoding.UTF8.GetBytes(stream.ToString()), "application/xml", "dados_usuarios.xml");
}

private IActionResult ExportarJson(List<Usuario> lista)
{
var json = new StringBuilder();
json.AppendLine("{");
json.AppendLine(" \"Usuarios\": [");
int total = 0;
foreach (var item in lista)
{
json.AppendLine(" {");
json.AppendLine($" \"Id\": {item.UsuarioId},");
json.AppendLine($" \"Nome\": \"{item.Nome}\",");
json.AppendLine($" \"Login\": \"{item.Login}\"");
json.AppendLine(" }");
total++;
if (total < lista.Count())


{
json.AppendLine(" ,");
}
}
json.AppendLine(" ]");
json.AppendLine("}");
return File(Encoding.UTF8.GetBytes(json.ToString()), "application/json", "dados_usuarios.json");

    }
}
}
