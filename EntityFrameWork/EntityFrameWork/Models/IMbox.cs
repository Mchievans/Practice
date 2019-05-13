using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    interface IMbox
    {
        IQueryable<Matchbox> Matchboxes { get; }

        void SaveMatchbox(Matchbox matchbox);

        Matchbox DeleteMatchbox(int CarId);
    }
}
