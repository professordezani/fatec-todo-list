using Microsoft.AspNetCore.Mvc;


public class TodoController : Controller
{
    // atributo:
    private List<string> tasks = new List<string>();
    
    // http://localhost:1234/todo/index
    public ActionResult Index()
    {
        tasks.Add("Estudar");
        tasks.Add("Trabalhar");
        tasks.Add("Dormir");

        // /Views/Todo/Index.cshtml
        return View(tasks);
    }
}