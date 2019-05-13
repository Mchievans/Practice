using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    interface ILbox
    {
        IQueryable<Lunchbox> Lunchboxes { get; }

        void SaveLunchbox(Lunchbox lunchbox);

        Lunchbox DeleteLunchbox(int LunchID);
    }
}
