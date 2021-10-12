using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HundoMVC.Controllers
{
    public class HundoController : Controller
    {
        public IActionResult Index()
        {
            HundoNumbers nums = new HundoNumbers();

            nums.StartValue = 1;
            nums.EndValue = 100;

            return View(nums);
        }

        [HttpPost]
        public IActionResult Index(HundoNumbers nums)
        {
            List<string> numItems = new List<string>();
            for (int i = nums.StartValue; i <= nums.EndValue; i++)
            {
                numItems.Add(i.ToString());
            }
            nums.Results = numItems;
            return View(nums);
        }
    }
}