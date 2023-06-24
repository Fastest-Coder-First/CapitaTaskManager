
using Microsoft.AspNetCore.Mvc;
using TaskManagement.Service;
using TaskManagement.Models;

namespace TaskManagement.Controllers
{
    public class TaskController : Controller
    {


        // GET: TaskController
        public ActionResult Index()
        {
           
            //call task service to get the list of tasks
            var tasks = TaskService.GetTasks();
            
            return View(tasks);
        }

        // GET: TaskController/Details/5
        public ActionResult Details(int id)
        {
            //get the task by id
            var task = TaskService.GetTasks().Find(t => t.Id == id);

            return View(task);
        }

        // GET: TaskController/Create
        public ActionResult Create()
        {
            //create a new task
            CapTask task = new CapTask();

            return View(task);
        }


        // POST: TaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CapTask task)
        {
            //add task to task service
            TaskService.AddTask(task);

            
           return RedirectToAction(nameof(Index));
            
        }

        // GET: TaskController/Edit/5
        public ActionResult Edit(int id)
        {
            //get the task by id
            var task = TaskService.GetTasks().Find(t => t.Id == id);


            return View(task);
        }

        // POST: TaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CapTask capTask)
        {
            //update the task
            TaskService.UpdateTask(capTask);

           return RedirectToAction(nameof(Index));
        }

        // GET: TaskController/Delete/5
        public ActionResult Delete(int id)
        {
           //call remove task from task service
            TaskService.RemoveTask(TaskService.GetTasks().Find(t => t.Id == id));

            return RedirectToAction(nameof(Index));
        }

       
    }
}
