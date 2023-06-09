﻿using DataAccessLogic.DatabaseModels;
using DataAccessLogic.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLogic.CrudLogic
{
    public class UserLogic : ICrudLogic<User>
    {
        private readonly ApplicationContext context;

        public UserLogic(ApplicationContext context)
        {
            this.context = context;
        }

        public Task Create(User model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(User model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> Read(User model)
        {
            return await context.Users.Where(user => (model == null)
            || (!string.IsNullOrWhiteSpace(model.UserName) && user.UserName == model.UserName))
            .ToListAsync();
        }

        public async Task Update(User model)
        {
            if (model == null)
            {
                throw new Exception("Пользователь не определен");
            }
            await context.SaveChangesAsync();
        }
    }
}