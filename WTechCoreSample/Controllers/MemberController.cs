using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTechCoreSample.Models;
using WTechCoreSample.Service;



namespace WTechCoreSample.Controllers
{
    public class MemberController : Controller
    {
     
        public IActionResult Index()
        {

            List<GroupMember> members = MusicGroupManager.GetAllMembers();


            return View(members);
        }

        public IActionResult MemberDetail(int id)
        {
            //listeden o id ye ait member ı yakala ve view e FIRLAT!

            List<GroupMember> members = MusicGroupManager.GetAllMembers();

            GroupMember groupMember = members.FirstOrDefault(x => x.Id == id);

            if(groupMember != null)
            {
                return View(groupMember);
            }
            else
            {
                return NotFound();
            }
           
        }

    }
}


// select ProductName as  from Products where UnitPrice > 20

// select * from Products where ProductId = 2 and CategoryId = 3

