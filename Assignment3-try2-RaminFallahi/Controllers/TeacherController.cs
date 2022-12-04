using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Assignment3_try2_RaminFallahi.Models; //2-try this line as Comment to see where you get error //added
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Assignment3_try2_RaminFallahi.Controllers
{
    public class TeacherController : Controller
    {
        // GET: /Teacher/List?SearchKey=Simon
        public ActionResult List(string SearchKey)
        {
            // want to recieve search key and print it out

            Debug.WriteLine("The user is tring to search for "+ SearchKey);

            //I want to recieve all teachers in the system
            TeacherDataController MyController = new TeacherDataController();   
            IEnumerable<teacher> MyTeacher = MyController.ListTeachers(SearchKey);

            Debug.WriteLine("I have access " + MyTeacher.Count());
            return View(MyTeacher);
        }
        public ActionResult Show(int id)
        {
            TeacherDataController MyController = new TeacherDataController();
            teacher SelectedTeacher = MyController.FindTeacher(id);

            return View(SelectedTeacher);
        }

        // GET /teacher/new
        public ActionResult New ()
        {
            return View();
        }

        //POST: /Teacher/Create
        [HttpPost]
        public ActionResult Create(string teacehrfname, string teacehrlname, int employeenumber, DateTime hiredate, int salary)
        {
            TeacherDataController MyController = new TeacherDataController();



            teacher NewTeacher = new teacher();
            NewTeacher.teacherfname = teacehrfname;
            NewTeacher.teacherlname = teacehrlname;
            NewTeacher.employeenumber = teacehrlname;
            NewTeacher.salary = salary;

            MyController.AddTeacher(NewTeacher);


            Debug.WriteLine("Trying to add a new teacher with fname" + teacehrfname);
            return RedirectToAction("List");
        }

        //GET: // Teacher/DEleteConfirm/{id}
        public ActionResult DeletConfirm(int id)
        {
            //get info about the article
            //Navigate to / View/Teacher/deleteConfirm.cshtml
            TeacherDataController MyController = new TeacherDataController();
            teacher SelectedTeacher = MyController.FindTeacher(id);
            return View();
        }

        //POST: /Teacher/DElete/{id}
        public ActionResult Delete(int id)
        {
            TeacherDataController MyController = new TeacherDataController();
            MyController.DeleteTeacher(id);

            return RedirectToAction("List");
        }
    }
}