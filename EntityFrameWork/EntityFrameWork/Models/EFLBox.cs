using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class EFLBox : ILbox
    {
        private BoxContext context;

        public EFLBox(BoxContext Btex)
        {
            context = Btex;
        }

        public IQueryable<Lunchbox> Lunchboxes => context.Lunchboxes
            .OrderByDescending(lb => lb.LunchId);

        public Lunchbox DeleteLunchbox(int LunchID)
        {
            Lunchbox dbEntry = context.Lunchboxes
                        .FirstOrDefault(lb => lb.LunchId == lb.LunchId);
            if (dbEntry != null)
            {
                context.Lunchboxes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveLunchbox(Lunchbox lunchbox)
        {
            //context.Lunchboxes.Add(lunchbox);
            Lunchbox dbEntry = context.Lunchboxes
                  .FirstOrDefault(lb => lb.LunchId == lb.LunchId);
            if (dbEntry != null)
            {
                dbEntry.LunchId = lunchbox.LunchId;
                dbEntry.Food = lunchbox.Food;
                dbEntry.Drinks = lunchbox.Drinks;
            }
            context.SaveChanges();
        }
                                    
    }
}
