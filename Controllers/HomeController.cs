using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GradeCalc")]
        public IActionResult GradeCalc ()
        {
            return View();
        }

        [HttpPost("GradeCalc")]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            //assign numbers in input fields to variables and calculate grade weight
            double assignmentsPercent = model.assignments * 0.5;
            double groupProjectPercent = model.groupProject * 0.1;
            double quizzesPercent = model.quizzes * 0.1;
            double examsPercent = model.exams * 0.2;
            double intexPercent = model.intex * 0.1;

            //calculate final grade percent 
            double percentCalculated = assignmentsPercent + groupProjectPercent + quizzesPercent + examsPercent + intexPercent;

            //determine letter grade using if function for each range of grades
            string letterCalculated = "";
            if (percentCalculated < 60.0)
            {
                letterCalculated = "E";
            }
            else if (percentCalculated >= 60.0 && percentCalculated < 64.0)
            {
                letterCalculated = "D-";
            }
            else if (percentCalculated >= 64.0 && percentCalculated < 67.0)
            {
                letterCalculated = "D";
            }
            else if (percentCalculated >= 67.0 && percentCalculated < 70.0)
            {
                letterCalculated = "D+";
            }
            else if (percentCalculated >= 70.0 && percentCalculated < 74.0)
            {
                letterCalculated = "C-";
            }
            else if (percentCalculated >= 74.0 && percentCalculated < 77.0)
            {
                letterCalculated = "C";
            }
            else if (percentCalculated >= 77.0 && percentCalculated < 80.0)
            {
                letterCalculated = "C+";
            }
            else if (percentCalculated >= 80.0 && percentCalculated < 84.0)
            {
                letterCalculated = "B-";
            }
            else if (percentCalculated >= 84.0 && percentCalculated < 87.0)
            {
                letterCalculated = "B";
            }
            else if (percentCalculated >= 87.0 && percentCalculated < 90.0)
            {
                letterCalculated = "B+";
            }
            else if (percentCalculated >= 90.0 && percentCalculated < 94.0)
            {
                letterCalculated = "A-";
            }
            else
            {
                letterCalculated = "A";
            }

            //round percent to two decimals and add % sign
            percentCalculated = Math.Round(percentCalculated, 2);
            @ViewBag.PercentGrade = ("Percent Grade: " + percentCalculated + "%");
            @ViewBag.LetterGrade = ("Letter Grade: " + letterCalculated);

            return View("GradeCalc");
        }
    }
}
