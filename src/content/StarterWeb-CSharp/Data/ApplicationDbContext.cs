using System;
using System.Collections.Generic;
using System.Text;
#if (IndividualLocalAuth)
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
#endif
using Microsoft.EntityFrameworkCore;

namespace Company.WebApplication1.Data
{
    public class ApplicationDbContext
#if (IndividualLocalAuth)
        : IdentityDbContext
#else
        : DbContext
#endif

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
