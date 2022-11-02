using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SistemaDivisas1._0._0.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SistemaDivisasUser class
public class SistemaDivisasUser : IdentityUser
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

