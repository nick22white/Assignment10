using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment10.Components
{
    //View component that gets the team info
    public class BowlingTeamViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        public BowlingTeamViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        //Gets the teams
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamtype"];
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
