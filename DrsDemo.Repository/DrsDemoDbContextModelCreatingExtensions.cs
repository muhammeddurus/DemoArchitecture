using DrsDemo.Domain;
using DrsDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Repository
{
    public static class DrsDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureDrsDemo(this ModelBuilder builder)
        {
            #region Team
            builder.Entity<Team>(t =>
            {
                t.ToTable(TableNameConst.Country);
                t.HasKey(t => t.Id);
                t.Property(t => t.Id).ValueGeneratedOnAdd();
                t.Property(t => t.Name);
            });
            #endregion
        }
    }
}
