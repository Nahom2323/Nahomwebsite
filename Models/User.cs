using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;


namespace QuarterlySales.Models
{
    public class User : IdentityUser
    {
        // Inherits all IdentityUser properties
        //
        // You can add properties/methods specific
        // to your app’s needs

        [NotMapped]

        public IList<string> RoleNames { get; set; }
    }
}
