using System.Web.Mvc;
using TP_PW3.Models;

namespace TP_PW3.Controllers
{
    public class AltaUsuarioController : Controller
    {
        // GET: AltaUsuario
        public ActionResult CrearUsuario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearUsuario(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }
            return View();
        }

    }
}