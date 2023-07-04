using AppCore.Interfaces.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Models
{
    public class Module : IIdentity<Guid>
    {
        public Guid Id { get; set; }
        public string ModuleName { get; set; }

        public double NoOfHour { get; set; }//meybe be Enum class
    }
}
