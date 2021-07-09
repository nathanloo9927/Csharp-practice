using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using followalong3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace followalong3.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();
        Random rand = new Random();
        const int GRID_SIZE = 25;
        public IActionResult Index()
        {
            if (buttons.Count < GRID_SIZE)
            {
                for (int i = 0; i < GRID_SIZE; i++)
                {
                    buttons.Add(new ButtonModel { Id = i, ButtonState = rand.Next(5) });
                }
            }
            return View("Index", buttons);
        }

        public IActionResult HandleButtonClick(string buttonNumber)
        {
            int btn = int.Parse(buttonNumber);
            buttons.ElementAt(btn).ButtonState = (buttons.ElementAt(btn).ButtonState + 1) % 5;
            return View("Index", buttons);
        }

        public IActionResult ShowOneButton(int buttonNumber)
        {
            // add one to the button state. if it's > 5, set it to 0
            buttons.ElementAt(buttonNumber).ButtonState = (buttons.ElementAt(buttonNumber).ButtonState + 1) % 5;

            // Render a button and save it to a string
            string buttonstr = RenderRazorViewToString(this, "ShowOneButton", buttons.ElementAt(buttonNumber));

            // Generate a win or loss string based on the state of the buttons array
            bool flag = true;
            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons.ElementAt(i).ButtonState != buttons.ElementAt(0).ButtonState)
                {
                    flag = false;
                }
            }

            string nyeh;
            if (flag)
            {
                nyeh = "<p>All of the buttons are the same color</p>";
            } else
            {
                nyeh = "<p>Try and get all the buttons to be the same color</p>";
            }

            // Assemble a JSON string that has 2 parts (button string html and win loss message)
            var package = new { part1 = buttonstr, part2 = nyeh };

            // Send the JSON result
            return Json(package);

            // In site.js, the data will have to be interpreted as 2 pieces of data instead of one

        }

        public static string RenderRazorViewToString(Controller controller, string viewName, object model = null)
        {
            controller.ViewData.Model = model;
            using (var sw = new StringWriter())
            {
                IViewEngine viewEngine =
                    controller.HttpContext.RequestServices.GetService(typeof(ICompositeViewEngine)) as
                        ICompositeViewEngine;
                ViewEngineResult viewResult = viewEngine.FindView(controller.ControllerContext, viewName, false);

                ViewContext viewContext = new ViewContext(
                    controller.ControllerContext,
                    viewResult.View,
                    controller.ViewData,
                    controller.TempData,
                    sw,
                    new HtmlHelperOptions()
                );
                viewResult.View.RenderAsync(viewContext);
                return sw.GetStringBuilder().ToString();
            }
        }
    }
}
