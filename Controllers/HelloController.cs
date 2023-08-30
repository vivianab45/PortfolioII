//import
using Microsoft.AspNetCore.Mvc;
//namespace
namespace PortfolioI.Controllers;

public class HelloController : Controller
{
    //route to Index front page
    [HttpGet("")]
    //render-view
    public ViewResult AboutMe()
    {
        return View("AboutMeView");
    }

    //route to Projects
    [HttpGet("projects")]
    //render-projects view
    public ViewResult Projects()
    {
        return View("ProjectsView");
    }

    //route to Contact
    [HttpGet("contact")]
    //render-contact view
    public ViewResult Contact()
    {
        return View("ContactView");
    }
}   