using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models.ORM;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTechCoreSample.Controllers
{
    public class RoleController : Controller
    {

        public IActionResult Index()
        {
            WTechContext wTechContext = new WTechContext();

            List<Role> roles = wTechContext.Roles.ToList();


            return View(roles);
        }


        public IActionResult WebUsersByRoleId(int id)
        {
            WTechContext wTechContext = new WTechContext();


            List<WebUser> webUsers = wTechContext.WebUsers.Where(q => q.RoleId == id).ToList();

            return View(webUsers);
        }
    }
}

//select * from WebUsers where RoleId = 3
