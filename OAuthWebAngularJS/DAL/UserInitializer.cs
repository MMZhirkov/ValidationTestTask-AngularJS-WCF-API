﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace OAuthWebAngularJS.DAL
{
    public class UserInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User { Id = Guid.NewGuid(), Login = "pikuser" },
                new User { Id = Guid.NewGuid(), Login = "guestuser" }
            };

            users.ForEach(s => context.Users.Add(s));

            context.SaveChanges();
        }
    }
}