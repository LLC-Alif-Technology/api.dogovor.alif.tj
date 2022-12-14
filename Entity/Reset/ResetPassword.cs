using Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Reset
{
    public class ResetPassword
    {
        public int Id { get; set; }
        public string RandomNumber { get; set; }
        public DateTime? ValidDate { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
