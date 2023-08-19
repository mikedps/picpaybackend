﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PicPayBackEnd.Data.Context;

#nullable disable

namespace PicPayBackEnd.Data.Migrations
{
    [DbContext(typeof(PicPayContext))]
    [Migration("20230819201034_First1")]
    partial class First1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Payees");
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Payers");
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getDate()");

                    b.Property<Guid>("FkPayee")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FkPayer")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FkPayee");

                    b.HasIndex("FkPayer");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payee", b =>
                {
                    b.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Money", "Balance", b1 =>
                        {
                            b1.Property<Guid>("PayeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Value")
                                .HasMaxLength(14)
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Balance");

                            b1.HasKey("PayeeId");

                            b1.ToTable("Payees");

                            b1.WithOwner()
                                .HasForeignKey("PayeeId");
                        });

                    b.OwnsOne("PicPayBackEnd.Domain.Models.User", "User", b1 =>
                        {
                            b1.Property<Guid>("PayeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Name")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.Property<string>("Surename")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Surename");

                            b1.HasKey("PayeeId");

                            b1.ToTable("Payees");

                            b1.WithOwner()
                                .HasForeignKey("PayeeId");

                            b1.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Cpf", "Cpf", b2 =>
                                {
                                    b2.Property<Guid>("UserPayeeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(14)
                                        .HasColumnType("nvarchar(14)")
                                        .HasColumnName("Cpf");

                                    b2.HasKey("UserPayeeId");

                                    b2.ToTable("Payees");

                                    b2.WithOwner()
                                        .HasForeignKey("UserPayeeId");
                                });

                            b1.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Email", "Email", b2 =>
                                {
                                    b2.Property<Guid>("UserPayeeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)")
                                        .HasColumnName("Email");

                                    b2.HasKey("UserPayeeId");

                                    b2.ToTable("Payees");

                                    b2.WithOwner()
                                        .HasForeignKey("UserPayeeId");
                                });

                            b1.Navigation("Cpf");

                            b1.Navigation("Email");
                        });

                    b.Navigation("Balance")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payer", b =>
                {
                    b.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Money", "Balance", b1 =>
                        {
                            b1.Property<Guid>("PayerId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Value")
                                .HasMaxLength(14)
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Balance");

                            b1.HasKey("PayerId");

                            b1.ToTable("Payers");

                            b1.WithOwner()
                                .HasForeignKey("PayerId");
                        });

                    b.OwnsOne("PicPayBackEnd.Domain.Models.User", "User", b1 =>
                        {
                            b1.Property<Guid>("PayerId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Name")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Name");

                            b1.Property<string>("Surename")
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)")
                                .HasColumnName("Surename");

                            b1.HasKey("PayerId");

                            b1.ToTable("Payers");

                            b1.WithOwner()
                                .HasForeignKey("PayerId");

                            b1.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Cpf", "Cpf", b2 =>
                                {
                                    b2.Property<Guid>("UserPayerId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(14)
                                        .HasColumnType("nvarchar(14)")
                                        .HasColumnName("Cpf");

                                    b2.HasKey("UserPayerId");

                                    b2.ToTable("Payers");

                                    b2.WithOwner()
                                        .HasForeignKey("UserPayerId");
                                });

                            b1.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Email", "Email", b2 =>
                                {
                                    b2.Property<Guid>("UserPayerId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)")
                                        .HasColumnName("Email");

                                    b2.HasKey("UserPayerId");

                                    b2.ToTable("Payers");

                                    b2.WithOwner()
                                        .HasForeignKey("UserPayerId");
                                });

                            b1.Navigation("Cpf");

                            b1.Navigation("Email");
                        });

                    b.Navigation("Balance")
                        .IsRequired();

                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Transaction", b =>
                {
                    b.HasOne("PicPayBackEnd.Domain.Models.Payee", "Payee")
                        .WithMany("Transactions")
                        .HasForeignKey("FkPayee")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PicPayBackEnd.Domain.Models.Payer", "Payer")
                        .WithMany("Transactions")
                        .HasForeignKey("FkPayer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("PicPayBackEnd.Domain.ValueObjects.Money", "Amount", b1 =>
                        {
                            b1.Property<Guid>("TransactionId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Value")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Amount");

                            b1.HasKey("TransactionId");

                            b1.ToTable("Transactions");

                            b1.WithOwner()
                                .HasForeignKey("TransactionId");
                        });

                    b.Navigation("Amount")
                        .IsRequired();

                    b.Navigation("Payee");

                    b.Navigation("Payer");
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payee", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("PicPayBackEnd.Domain.Models.Payer", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
