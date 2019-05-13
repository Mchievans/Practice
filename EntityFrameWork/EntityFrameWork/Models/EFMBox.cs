using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class EFMBox : IMbox
    {
        private BoxContext context;

        public EFMBox(BoxContext Btex)
        {
            context = Btex;
        }

        public IQueryable<Matchbox> Matchboxes => context.Matchboxes
            .OrderByDescending(mb => mb.CarId);

        public Matchbox DeleteMatchbox(int CarId)
        {
            Matchbox dbEntry = context.Matchboxes
               .FirstOrDefault(mb => mb.CarId == mb.CarId);
            if (dbEntry != null)
            {
                context.Matchboxes.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveMatchbox(Matchbox matchbox)
        {
            //context.Matchboxes.Add(matchbox);
            Matchbox dbEntry = context.Matchboxes
                .FirstOrDefault(mb => mb.CarId == mb.CarId);
            if (dbEntry != null)
            {
                dbEntry.CarId = matchbox.CarId;
                dbEntry.Make = matchbox.Model;
                dbEntry.Model = matchbox.Model;
            }
            context.SaveChanges();
        }
    }
}
