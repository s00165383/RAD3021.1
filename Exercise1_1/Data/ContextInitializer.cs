using Exercise1_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exercise1_1.Data
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<CoreContext>
    {
        protected override void Seed(CoreContext context)
        {
            var users = new List<User>
            {
                new User() {FirstName="John",MidName="Frank",LastName="Doe",
                DOB=DateTime.Parse("1980-01-01")},

                new User() {FirstName="Jane",MidName="Frank",LastName="Doe",
                DOB=DateTime.Parse("1986-01-01")},

                new User() {FirstName="Mark",MidName="Frank",LastName="Smith",
                DOB=DateTime.Parse("1972-01-01")},

                new User() {FirstName="Mary",MidName="Frank",LastName="Smith",
                DOB=DateTime.Parse("1975-01-01")},
            };

            users.ForEach(u => context.Users.Add(u));

            base.Seed(context);
        }
    }
}