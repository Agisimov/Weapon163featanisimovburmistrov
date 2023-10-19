using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapon163featanisimovburmistrov.DB;

namespace Weapon163featanisimovburmistrov.ClassHelper
{
    class EFClass
    {
        public static Entities context { get; } = new Entities();
    }
}
