using System;
using System.Collections.Generic;
using TwitchLib.Controllers;
using TwitchLib.Models;
using TwitchLib.Models.Static;
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
            var twitchController = new TwitchController();

            Console.WriteLine("Configuration directory: {0}", initTwitch.Configuration.DirectoryConfiguration);
            Console.WriteLine("Version: {0}", initTwitch.Configuration.Version);
            Console.WriteLine("Channel: {0}", initTwitch.Configuration.Channel);

            // parse that data
            twitchController.ApiRequest<Chat>($"group/user/{initTwitch.Configuration.Channel}/chatters", TwitchController.RequestType.Tmi);
            twitchController.ApiRequest<Channel>($"channels/{initTwitch.Configuration.Channel}", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<ChatBadges>($"chat/{initTwitch.Configuration.Channel}/badges", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<ChatEmoticons>("chat/emoticon_images", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<GamesTop>("games/top", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<StreamLive>($"streams/{initTwitch.Configuration.Channel}", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<IngestServer>("ingests", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<User>($"users/{initTwitch.Configuration.Channel}", TwitchController.RequestType.Kraken);
            twitchController.ApiRequest<UserVideos>($"channels/{initTwitch.Configuration.Channel}/videos?broadcasts=true", TwitchController.RequestType.Kraken);

            initTwitch = twitchController._twitch;
            

            Console.WriteLine("-----------------------------------------");

            // test parsed data (make sure it's not returning null)
            Console.WriteLine("Chatter Count: {0}", initTwitch.Chat.ChatterCount);
            Console.WriteLine("Channel Display Name: {0}", initTwitch.Channel.DisplayName);
            Console.WriteLine("Test Mod Image: {0}", initTwitch.ChatBadges.Mod.Image);
            Console.WriteLine("Emote: {0}", initTwitch.ChatEmoticons.Emoticons[0].Code);

            var iGames = initTwitch.GamesTop.Top.Count;
            Console.Write("Top ({0}) Games: ", iGames);
            foreach (var game in initTwitch.GamesTop.Top)
            {
                if (iGames != 1)
                    Console.Write("{0}, ", game.Game.Name);
                else
                    Console.WriteLine(game.Game.Name);
                iGames--;
            }

            if (initTwitch.StreamLive.Stream != null)
                Console.WriteLine("Viewers: {0}", initTwitch.StreamLive.Stream.Viewers);

            var iIngests = initTwitch.IngestServer.Ingests.Count;
            Console.Write("Top ({0}) Ingests: ", iIngests);
            foreach (var server in initTwitch.IngestServer.Ingests)
            {
                if (iIngests != 1)
                    Console.Write("\"{0}\", ", server.Name);
                else
                    Console.WriteLine(server.Name);
                iIngests--;
            }

            Console.WriteLine("Bio: {0}", initTwitch.User.Bio);
            Console.WriteLine("User Video: {0}", initTwitch.UserVideos.Total);

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