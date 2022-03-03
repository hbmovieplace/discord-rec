﻿// <auto-generated />
using DiscordToTelegramBot.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiscordToTelegramBot.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220303095951_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("DiscordToTelegramBot.Database.Tables.DatabaseMessages", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<ulong>("DiscordId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("discord_id");

                    b.Property<ulong>("DisocrdChannelId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("discord_channel_id");

                    b.Property<long>("TelegramChannelId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("telegram_chanel_id");

                    b.Property<int>("TelegramId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("telegram_id");

                    b.Property<ulong>("ThreadId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("discord_thread_id");

                    b.HasKey("Id");

                    b.ToTable("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
