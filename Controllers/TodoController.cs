using Microsoft.AspNetCore.Mvc;


public class TodoController : Controller
{
    // atributo:
    private static List<Todo> tasks = new List<Todo>();
    
    // http://localhost:1234/todo/index
    public ActionResult Index()
    {
        // /Views/Todo/Index.cshtml
        return View(tasks);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Todo t) // Data Binding
    {
        t.Id = Guid.NewGuid().ToString();
        tasks.Add(t);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(string id)
    {
        var task = tasks.Single(t => t.Id == id); // LinQ
        tasks.Remove(task);

        return RedirectToAction("Index");
    }

    public ActionResult Update(string id)
    {
        var task = tasks.Single(t => t.Id == id); // LinQ
        return View(task);
    }
}