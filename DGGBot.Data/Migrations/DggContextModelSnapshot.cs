﻿// <auto-generated />
using DGGBot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DGGBot.Data.Migrations
{
    [DbContext(typeof(DggContext))]
    partial class DggContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("DGGBot.Data.Enitities.Throttle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<ulong>("DiscordChannelId")
                        .HasColumnName("discord_channel_id");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnName("module_name");

                    b.HasKey("Id");

                    b.ToTable("throttle");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.TrustedUser", b =>
                {
                    b.Property<ulong>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("trusted_user");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitch.StreamGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Game")
                        .IsRequired()
                        .HasColumnName("game")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("start_time")
                        .HasDefaultValue(new DateTime(2017, 9, 8, 14, 17, 6, 293, DateTimeKind.Utc));

                    b.Property<DateTime?>("StopTime")
                        .HasColumnName("stop_time");

                    b.Property<long>("StreamId")
                        .HasColumnName("stream_id");

                    b.HasKey("Id");

                    b.ToTable("stream_game");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitch.StreamLastOnline", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<string>("FriendlyUsername")
                        .IsRequired()
                        .HasColumnName("friendly_username")
                        .HasMaxLength(100);

                    b.Property<string>("LastGame")
                        .IsRequired()
                        .HasColumnName("last_game")
                        .HasMaxLength(200);

                    b.Property<DateTime>("LastOnlineAt")
                        .HasColumnName("last_online_at");

                    b.HasKey("UserId");

                    b.ToTable("stream_last_online");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitch.StreamNullResponse", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<DateTimeOffset>("NullResponseDate")
                        .HasColumnName("null_response_date");

                    b.HasKey("UserId");

                    b.ToTable("stream_null_response");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitch.StreamRecord", b =>
                {
                    b.Property<long>("StreamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("stream_id");

                    b.Property<string>("CurrentGame")
                        .IsRequired()
                        .HasColumnName("current_game");

                    b.Property<long>("DiscordMessageId")
                        .HasColumnName("discord_message_id");

                    b.Property<DateTime>("StartTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("start_time")
                        .HasDefaultValue(new DateTime(2017, 9, 8, 14, 17, 6, 291, DateTimeKind.Utc));

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("StreamId");

                    b.ToTable("stream_record");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitch.StreamToCheck", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<bool>("DeleteDiscordMessage")
                        .HasColumnName("delete_discord_message");

                    b.Property<long>("DiscordChannelId")
                        .HasColumnName("discord_channel_id");

                    b.Property<string>("DiscordMessage")
                        .IsRequired()
                        .HasColumnName("discord_message");

                    b.Property<long>("DiscordServerId")
                        .HasColumnName("discord_server_id");

                    b.Property<int>("EmbedColor")
                        .HasColumnName("embed_color");

                    b.Property<int>("Frequency")
                        .HasColumnName("frequency");

                    b.Property<string>("FriendlyUsername")
                        .IsRequired()
                        .HasColumnName("friendly_username")
                        .HasMaxLength(200);

                    b.Property<bool>("PinMessage")
                        .HasColumnName("pin_message");

                    b.HasKey("UserId");

                    b.ToTable("stream_to_check");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitter.TweetRecord", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnName("author_name")
                        .HasMaxLength(150);

                    b.Property<string>("AuthorUsername")
                        .IsRequired()
                        .HasColumnName("author_username")
                        .HasMaxLength(100);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnName("profile_image_url")
                        .HasMaxLength(500);

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnName("text")
                        .HasMaxLength(200);

                    b.Property<long>("TweetId")
                        .HasColumnName("tweet_id");

                    b.HasKey("UserId");

                    b.ToTable("tweet_record");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Twitter.TwitterToCheck", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("user_id");

                    b.Property<long>("DiscordChannelId")
                        .HasColumnName("discord_channel_id");

                    b.Property<long>("DiscordServerId")
                        .HasColumnName("discord_server_id");

                    b.Property<int>("Frequency")
                        .HasColumnName("frequency");

                    b.Property<string>("FriendlyUsername")
                        .IsRequired()
                        .HasColumnName("friendly_username")
                        .HasMaxLength(45);

                    b.HasKey("UserId");

                    b.ToTable("twitter_to_check");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Youtube.YouTubeRecord", b =>
                {
                    b.Property<string>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("channel_id")
                        .HasMaxLength(30);

                    b.Property<string>("AuthorIconUrl")
                        .IsRequired()
                        .HasColumnName("author_icon_url")
                        .HasMaxLength(500);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnName("author_name")
                        .HasMaxLength(200);

                    b.Property<string>("AuthorUrl")
                        .IsRequired()
                        .HasColumnName("author_url")
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnName("image_url")
                        .HasMaxLength(500);

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnName("published_at");

                    b.Property<string>("VideoDescription")
                        .IsRequired()
                        .HasColumnName("video_description")
                        .HasMaxLength(550);

                    b.Property<string>("VideoId")
                        .IsRequired()
                        .HasColumnName("video_id")
                        .HasMaxLength(20);

                    b.Property<string>("VideoTitle")
                        .IsRequired()
                        .HasColumnName("video_title")
                        .HasMaxLength(200);

                    b.HasKey("ChannelId");

                    b.ToTable("youtube_record");
                });

            modelBuilder.Entity("DGGBot.Data.Enitities.Youtube.YouTubeToCheck", b =>
                {
                    b.Property<string>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("channel_id")
                        .HasMaxLength(200);

                    b.Property<long>("DiscordChannelId")
                        .HasColumnName("discord_channel_id");

                    b.Property<long>("DiscordServerId")
                        .HasColumnName("discord_server_id");

                    b.Property<int>("Frequency")
                        .HasColumnName("frequency");

                    b.Property<string>("FriendlyUsername")
                        .IsRequired()
                        .HasColumnName("friendly_username")
                        .HasMaxLength(100);

                    b.HasKey("ChannelId");

                    b.ToTable("youtube_to_check");
                });
#pragma warning restore 612, 618
        }
    }
}
