using Backend_Template.DAL;
using Backend_Template.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Template.Services
{
    public class LayoutService
    {
        private readonly AppDbContext context;

        public LayoutService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Setting> GetDatas()
        {
            Setting setting = await context.Settings.FirstOrDefaultAsync();
            return setting;
        }
    }
}
