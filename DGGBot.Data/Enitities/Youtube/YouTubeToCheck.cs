﻿namespace DGGBot.Data.Enitities.Youtube
{
    public class YouTubeToCheck
    {
        public string ChannelId { get; set; }

        public string FriendlyUsername { get; set; }

        public int Frequency { get; set; }

        public long DiscordServerId { get; set; }

        public long DiscordChannelId { get; set; }
    }
}