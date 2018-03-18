using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDL.Models;

namespace TDL.Controllers
{
    public class HomeController : Controller
    {
        Entities db = new Entities();
        public ActionResult Index()
        {
            List<Departement> DeptList = db.Departements.ToList();
            ViewBag.ListOfDepartment = new SelectList(DeptList, "id", "dname");
            return View();
        }

        public JsonResult GettdlList()
        {
            //Pass The All Student Record From Controller To View For Show The All Data For User
            List<TDLViewModel> StList = db.todolists.Where(x => x.IsDeleted == false).Select(x => new TDLViewModel
            {
                tid = x.tid,
                title = x.title,
                description = x.description,
                dname = x.Departement.dname
            }).ToList();

            return Json(StList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GettdlListById(int tid)
        {
            todolist model = db.todolists.Where(x => x.tid == tid).SingleOrDefault();
            string value = string.Empty;
            value = JsonConvert.SerializeObject(model, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SaveDataInDatabase(TDLViewModel model)
        {
            var result = false;
            try
            {
                if (model.tid > 0)
                {
                    todolist tdl = db.todolists.SingleOrDefault(x => x.IsDeleted == false && x.tid == model.tid);
                    tdl.title = model.title;
                    tdl.description = model.description;
                    tdl.id = model.id;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    todolist tdl = new todolist();
                    tdl.title = model.title;
                    tdl.description = model.description;
                    tdl.id = model.id;
                    tdl.IsDeleted = false;
                    db.todolists.Add(tdl);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}