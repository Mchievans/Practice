using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace EntityFrameWorkDataAccessApproach
{
    class BoxService
    {
        private readonly BoxContext context;

        public BoxService(BoxContext Bcontext)
        {
            context = Bcontext;
        }

        public void AddLunchBox(LunchBox lunchBox)
        {
            var addedLunchBoxEntry = context.Lunchboxes.Add(lunchBox);            
            context.SaveChanges();
        }

        public void AddMatchBox(MatchBox matchBox)
        {
            var addedMatchBoxEntry = context.Matchboxes.Add(matchBox);
            context.SaveChanges();
        }
    }
}
