using Microsoft.AspNetCore.Mvc;

public class TodoController : Controller
{
    private DatabaseContext db;
    public TodoController(DatabaseContext db)
    {
        this.db = db;
    }

    // http://localhost:1234/todo/index
    public ActionResult Index()
    {
        // /Views/Todo/Index.cshtml
        return View(db.Todo.ToList()); // ~ SELECT * FROM Todo
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

        db.Todo.Add(t); // ~ INSERT INTO Todo VALUES (t...)
        db.SaveChanges(); // commit

        return RedirectToAction("Index");
    }

    public ActionResult Delete(string id)
    {
        var task = db.Todo.Single(t => t.Id == id); // LinQ
        db.Todo.Remove(task); // ~ DELETE FROM Todo WHERE Id = id
        db.SaveChanges();

        return RedirectToAction("Index");
    }

    public ActionResult Update(string id)
    {
        // SELECT * FROM Todo WHERE Id = id
        var task = db.Todo.Single(t => t.Id == id); // LinQ
        return View(task);
    }
}