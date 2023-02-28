using Microsoft.AspNetCore.Mvc;
using Parcel.Model;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult ParcelsForm() 
    { 
      return View(); 
    }
    
    [Route ("/Shipping")]
    public ActionResult Shipping(string height, string length, string width, string weight)
    {
      Parcels newShipping = new Parcels(height, width, length, weight);
      newShipping.Height = height;
      newShipping.Width = width;
      newShipping.Length = length;
      newShipping.Weight = weight;
      return View(newShipping);
    }
  }
}