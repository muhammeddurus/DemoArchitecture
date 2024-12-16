using DrsDemo.Domain;
using DrsDemo.Domain.Countries;
using DrsDemo.Domain.Draws;
using DrsDemo.Domain.Groups;
using DrsDemo.Domain.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrsDemo.Infrastructure.Context
{
    public static class DrsDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureDrsDemo(this ModelBuilder builder)
        {
            #region Team
            builder.Entity<Team>(t =>
            {
                t.ToTable(TeamConst.TableName);
                t.HasKey(t => t.Id);
                t.Property(t => t.Id).ValueGeneratedOnAdd();
                t.Property(t => t.Name).HasMaxLength(TeamConst.NameMaxLength);
                t.HasQueryFilter(x => !x.IsDeleted);
            });
            #endregion

            #region Country
            builder.Entity<Country>(t =>
            {
                t.ToTable(CountryConst.TableName);
                t.HasKey(t => t.Id);
                t.Property(t => t.Id).ValueGeneratedOnAdd();
                t.Property(t => t.Name).HasMaxLength(CountryConst.NameMaxLength);
                t.HasQueryFilter(x => !x.IsDeleted);
            });
            #endregion

            #region Group
            builder.Entity<Group>(t =>
            {
                t.ToTable(GroupConst.TableName);
                t.HasKey(t => t.Id);
                t.Property(t => t.Id).ValueGeneratedOnAdd();
                t.Property(t => t.Name).HasMaxLength(GroupConst.NameMaxLength);
                t.HasQueryFilter(x => !x.IsDeleted);
            });
            #endregion

            #region Draw
            builder.Entity<Draw>(t =>
            {
                t.ToTable(DrawConst.TableName);
                t.HasKey(t => t.Id);
                t.Property(t => t.Id).ValueGeneratedOnAdd();
                t.Property(t => t.Firstname);
                t.Property(t => t.Surname);
                t.HasQueryFilter(x => !x.IsDeleted);
            });
            #endregion
        }
    }
}
