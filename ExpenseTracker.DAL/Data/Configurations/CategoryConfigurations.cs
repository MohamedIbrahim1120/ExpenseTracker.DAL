using ExpenseTracker.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DAL.Data.Configurations
{
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(C=>C.CategoryId);
            builder.Property(X=>X.Title).HasColumnType("nvarchar(50)");
            builder.Property(X=>X.Icon).HasColumnType("nvarchar(5)");
            builder.Property(X=>X.Type).HasColumnType("nvarchar(10)");


        }
    }
}
