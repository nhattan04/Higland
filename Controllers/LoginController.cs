using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSDL.Models;

namespace CSDL.Controllers
{
    public class LoginController : Controller
    {
        DBQLBanHangEntities database = new DBQLBanHangEntities();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AuthenLogin(tblUser _user)
        {
            try
            {
                var check_ID = database.tblUsers.Where(s => s.userID == _user.userID).FirstOrDefault();
                var check_Name = database.tblUsers.Where(s => s.userName == _user.userName).FirstOrDefault();
                var check_Pass = database.tblUsers.Where(s => s.userPass == _user.userPass).FirstOrDefault();
                if (check_ID == null || check_Name == null || check_Pass == null)
                {
                    if (check_ID == null)
                        ViewBag.ErrorID = "ID not match";
                    if (check_Name == null)
                        ViewBag.ErrorName = "Name not match";
                    if (check_Pass == null)
                        ViewBag.ErrorPass = "Pass not match";
                    return View("Login");
                }
                else
                {
                    Session["userName"] = _user.userName;
                    return RedirectToAction("Index", "ProductClient");
                }
            }
            catch
            {
                return View("Login");
            }
        }
        public ActionResult Resgister()
        {
            return View();
        }
        public ActionResult AuthenResgister(tblUser _user)
        {
            try
            {
                database.tblUsers.Add(_user);
                database.SaveChanges();
                return RedirectToAction("Login");
            }
            catch
            {
                return View("Register");
            }
            
        }

    }
}