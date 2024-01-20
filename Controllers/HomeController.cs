using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public ViewResult RsvpForm(){
        return View();
    }
    //Se llama al objeto GuestResponce que seria el modelo GuestResponse
    [HttpPost]
     public ViewResult RsvpForm(GuestResponse oGuestResponse){
        if (ModelState.IsValid)
        {
            Repository.AddResponse(oGuestResponse);
            //llamada a la vista Gracias mandandole como parametro GuestResponse
            return View("Gracias", oGuestResponse);
        }
        else
        {
            return View();
        }
        
    }
    public ViewResult ListaDeRespuestas() {
        //Mostrar en la lista los que dijeron que si (true)
        return View(Repository.Responses.Where(r => r.WillAttend == true)); 
    }
}






