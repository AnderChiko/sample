﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test.Context
{
    public partial class testContext : DbContext
    {
        public testContext()
        {
        }

        public testContext(DbContextOptions<testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Campaign> Campaign { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<MessageContent> MessageContent { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-3ORTUEN;Initial Catalog=test;Integrated Security=True", x => x.UseDateOnlyTimeOnly());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkMessageNavigation)
                    .WithMany(p => p.Campaign)
                    .HasForeignKey(d => d.FkMessage)
                    .HasConstraintName("FK__Campaign__FK_Mes__2C3393D0");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessageContent>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.FkMessage).HasColumnName("FK_Message");

                entity.Property(e => e.MessageText)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Message_Text");

                entity.HasOne(d => d.FkMessageNavigation)
                    .WithMany(p => p.MessageContent)
                    .HasForeignKey(d => d.FkMessage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MessageCo__FK_Me__2B3F6F97");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.DateTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.FkCampaign).HasColumnName("FK_Campaign");

                entity.Property(e => e.NumberContacts).HasColumnName("Number_Contacts");

                entity.Property(e => e.StartDate).HasColumnName("Start_Date");

                entity.Property(e => e.StartTime).HasColumnName("Start_Time");

                entity.HasOne(d => d.FkCampaignNavigation)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.FkCampaign)
                    .HasConstraintName("FK__Schedule__FK_Cam__2D27B809");
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}