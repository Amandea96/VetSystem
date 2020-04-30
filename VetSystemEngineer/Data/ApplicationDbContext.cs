using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        
        public virtual DbSet<Institution> Institution { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<Visit> Visit { get; set; }
        public virtual DbSet<Genus> Genus { get; set; }
        public virtual DbSet<PatientInstitution> PatientInstitution { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.Property(e => e.IdInst).ValueGeneratedOnAdd().UseIdentityColumn();

                entity.Property(e => e.AddressInst).IsUnicode(true);

                entity.Property(e => e.City).IsUnicode(true);
                entity.Property(e => e.InterList).IsUnicode(true);

                entity.Property(e => e.EmailInst).IsUnicode(false);

                entity.Property(e => e.NameInst).IsUnicode(true);

                entity.Property(e => e.PhNumInst).IsFixedLength();

                entity.Property(e => e.Postcode).IsFixedLength();
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.IdPatient).ValueGeneratedOnAdd().UseIdentityColumn();

                entity.Property(e => e.Breed).IsUnicode(true);

                entity.Property(e => e.Name).IsUnicode(true);

                entity.Property(e => e.Sex).IsUnicode(true);
               

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Vet");

                entity.HasOne(d => d.IdGenusNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.IdGenus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Genus");
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Vet");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Education).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);

                entity.Property(e => e.PasswordHash).IsFixedLength();

                entity.Property(e => e.Surname).IsUnicode(true);

                entity.HasOne(d => d.IdInstNavigation)
                    .WithMany(p => p.ApplicationUser)
                    .HasForeignKey(d => d.IdInst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vet_Institution");
            });

            modelBuilder.Entity<Visit>(entity =>
            {
                entity.HasKey(e => e.IdVisit)
                    .HasName("PK_Vis");

                entity.Property(e => e.IdVisit).ValueGeneratedOnAdd().UseIdentityColumn();

                entity.Property(e => e.DecrDisActions).IsUnicode(true);

                entity.Property(e => e.Purpose).IsUnicode(true);

                entity.HasOne(d => d.IdPatientNavigation)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.IdPatient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Patient");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Visit)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Visit_Vet");
            });

            modelBuilder.Entity<Genus>(entity =>
            {
                entity.HasKey(e => e.IdGenus)
                    .HasName("PK_Genus");

                entity.Property(e => e.IdGenus).ValueGeneratedOnAdd().UseIdentityColumn();

                entity.Property(e => e.NameGenus).IsUnicode(true);

                


            });

            modelBuilder.Entity<PatientInstitution>(entity =>
            {
                entity.HasKey(e => new { e.IdPatient, e.IdInst });

                entity.Property(e => e.IdPatient).HasColumnName("id_patient");

                entity.Property(e => e.IdInst).HasColumnName("id_inst");

                entity.HasOne(d => d.IdInstNavigation)
                    .WithMany(p => p.PatientInstitution)
                    .HasForeignKey(d => d.IdInst)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientInstitution_Institution");

                entity.HasOne(d => d.IdPatientNavigation)
                    .WithMany(p => p.PatientInstitution)
                    .HasForeignKey(d => d.IdPatient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientInstitution_Patient");
            });



            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);




    }
}
