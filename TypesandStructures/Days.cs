using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesandStructures
{

    /* older version when just trying out enums
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    */
    // new version to learn about flags enumerations
    //values have to be powers of 2 so we know hte individual contributions once they've been combined
    [Flags]
    public enum Days
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 4,
        Wednesday = 8,
        Thursday = 16,
        Friday = 32,
        Saturday = 64,
        Weekend = Sunday | Saturday,
        Workdays = Monday | Tuesday | Wednesday | Thursday | Friday,

    }
}

