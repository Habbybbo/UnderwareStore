using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwareStore.Infrastructure.Data
{
    public class User: IdentityUser
    {
        [StringLength(150)]
        public string FullName { get; set; }
    }
}
