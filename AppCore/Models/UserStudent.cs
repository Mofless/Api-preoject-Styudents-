using AppCore.Interfaces.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Models
{
    public class UserStudent : IIdentity<Guid>
    {
        //[Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set;}

        public DateTime DateofBirth { get; set; }

        public string? Email { get; set; }  

        public string? PictureProfileURL { get; set; }

        public int? NumberPhone { get; set; }

     }
}
