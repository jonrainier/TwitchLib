using System;
using System.Collections.Generic;
using TwitchLib;
using TwitchLib.Util;

namespace TwitchLibTest
{
    internal class TwitchLibTest
    {
        private static string _twitchChannel = "";

        private static void Main(string[] args)
        {
            if (args.Length >= 1)
                ProcessArgs(args);
            else
                return;

            var initTwitch = new Twitch(_twitchChannel);
            
            Console.WriteLine("Version: {0}", Twitch.Configuration.Version);
            Console.WriteLine("Channel: {0}", Twitch.Configuration.Channel);

            // parse that data
            Twitch.Parse.TwitchParse($"group/user/{Twitch.Configuration.Channel}/chatters", "CHAT",
                Parse.RequestType.Tmi);
            Twitch.Parse.TwitchParse($"channels/{Twitch.Configuration.Channel}", "CHANNEL", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse($"chat/{Twitch.Configuration.Channel}/badges", "CHATBADGES",
                Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse("chat/emoticon_images", "CHATEMOTICONS", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse("games/top", "GAMESTOP", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse($"streams/{Twitch.Configuration.Channel}", "STREAM", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse("ingests", "INGEST", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse($"users/{Twitch.Configuration.Channel}", "USER", Parse.RequestType.Kraken);
            Twitch.Parse.TwitchParse($"channels/{Twitch.Configuration.Channel}/videos?broadcasts=true", "USERVIDEOS",
                Parse.RequestType.Kraken);

            Console.WriteLine("-----------------------------------------");

            // test parsed data (make sure it's not returning null)
            Console.WriteLine("Chatter Count: {0}", Twitch.Chat.ChatterCount);
            Console.WriteLine("Channel Display Name: {0}", Twitch.Channel.DisplayName);
            Console.WriteLine("Test Mod Image: {0}", Twitch.ChatBadges.Mod.Image);
            Console.WriteLine("Emote: {0}", Twitch.ChatEmoticons.Emoticons[0].Code);

            var iGames = Twitch.GamesTop.Top.Count;
            Console.Write("Top ({0}) Games: ", iGames);
            foreach (var game in Twitch.GamesTop.Top)
            {
                if (iGames != 1)
                    Console.Write("{0}, ", game.Game.Name);
                else
                    Console.WriteLine(game.Game.Name);
                iGames--;
            }

            if (Twitch.StreamLive.Stream != null)
                Console.WriteLine("Viewers: {0}", Twitch.StreamLive.Stream.Viewers);

            var iIngests = Twitch.IngestServer.Ingests.Count;
            Console.Write("Top ({0}) Ingests: ", iIngests);
            foreach (var server in Twitch.IngestServer.Ingests)
            {
                if (iIngests != 1)
                    Console.Write("\"{0}\", ", server.Name);
                else
                    Console.WriteLine(server.Name);
                iIngests--;
            }

            Console.WriteLine("Bio: {0}", Twitch.User.Bio);
            Console.WriteLine("User Video: {0}", Twitch.UserVideos.Total);

            Console.ReadKey();
        }

        private static void ProcessArgs(IEnumerable<string> args)
        {
            foreach (var s in args)
            {
                var cl = s.Split('=');
                var clSwitch = cl[0];
                var clParam = cl[1];
                switch (clSwitch)
                {
                    case "-stream":
                        _twitchChannel = clParam;
                        break;
                }
            }
        }
    }
}