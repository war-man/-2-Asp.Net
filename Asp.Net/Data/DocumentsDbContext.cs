using Kursach.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data
{
    public class DocumentsDbContext:DbContext
    {
        public DocumentsDbContext(DbContextOptions<DocumentsDbContext> options)
            : base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Input_Documents> input_Documents { get; set; }

        public DbSet<Interior_Document> Interior_Documents { get; set; }

        public DbSet<Output_Documents> Output_Documents { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<TypeOfDocument> TypeOfDocuments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Interior_Document>(table =>
            {
                table.HasKey(f=> new {f.Interior_DocumentId , f.ExecutorEmployeeId , f.ApproverEmployeeId});




                table.HasOne(x => x.ApproverEmployee)
                .WithMany(x => x.interior_Documents_approver)
                .HasForeignKey(f => f.ApproverEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

                table.HasOne(x => x.ExecutorEmployee)
                .WithMany(x => x.interior_Documents_executor)
                .HasForeignKey(f => f.ExecutorEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
               

            });


           


        }
    }
}
