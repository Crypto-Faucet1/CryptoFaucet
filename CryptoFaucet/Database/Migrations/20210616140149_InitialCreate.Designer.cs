﻿// <auto-generated />
using System;
using CryptoFaucet.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CryptoFaucet.Database.Migrations
{
    [DbContext(typeof(FaucetDbContext))]
    [Migration("20210616140149_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("CryptoFaucet.Database.Model.FaucetAccount", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("BtcBalance")
                        .HasColumnType("TEXT");

                    b.HasKey("AccountId");

                    b.ToTable("FaucetAccount");

                    b.HasData(
                        new
                        {
                            AccountId = "396806e5-03f6-40ff-ae8f-2a5cb736dfe4",
                            BtcBalance = 0m
                        });
                });

            modelBuilder.Entity("CryptoFaucet.Database.Model.FaucetAccountTransaction", b =>
                {
                    b.Property<DateTime>("TransactionTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("BtcExchangeRate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CurrentBalance")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("InitialBalance")
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTime");

                    b.HasIndex("AccountId");

                    b.ToTable("FaucetTransaction");
                });

            modelBuilder.Entity("CryptoFaucet.Database.Model.FaucetClaim", b =>
                {
                    b.Property<string>("ClaimId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClaimTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<short>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClaimId");

                    b.ToTable("FaucetClaim");
                });

            modelBuilder.Entity("CryptoFaucet.Database.Model.FaucetAccountTransaction", b =>
                {
                    b.HasOne("CryptoFaucet.Database.Model.FaucetAccount", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CryptoFaucet.Database.Model.FaucetAccount", b =>
                {
                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
