using Discord;
using Discord.Commands;
using System;

namespace ServerLordManager
{
    public class DiscordBot
    {
        DiscordClient client;
        CommandService commands;

        public DiscordBot()
        {

            client = new DiscordClient(input =>
            {
                input.LogLevel = LogSeverity.Info;
                input.LogHandler = Log;    
            });

            client.UsingCommands(input =>
            {
                input.PrefixChar = '!';
                input.AllowMentionPrefix = true;
            });

            commands = client.GetService<CommandService>();

            commands.CreateCommand("Hi").Do(async (e) =>
            {
                await.e.Channel.sendMessage("What are you needing?");
            });

            client.ExcuteAndWait(async() =>
            {
                await client.Connect("MzU4OTI0Nzk3MjAxMjE5NTg3.DJ_iRw.sE-fT3IBjxCGS3pgLuZF_Y-ZZLk", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}