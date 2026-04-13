using Microsoft.AspNetCore.Mvc;


public class TodoController : Controller
{
    // atributo:
    private List<Todo> tasks = new List<Todo>();
    
    // http://localhost:1234/todo/index
    public ActionResult Index()
    {
        tasks.Add(new Todo("1", "Estudar"));
        tasks.Add(new Todo("2", "Trabalhar"));

        // /Views/Todo/Index.cshtml
        return View(tasks);
    }

    public ActionResult Create()
    {
        return View();
    }
}