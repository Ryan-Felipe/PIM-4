using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Controllers;

public class Pagina_TesteController : Controller
{

    public IActionResult Pagina_Teste2()
    {
        return View();
    }

    //método para tratamento de erros (mantido do templeate)
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}