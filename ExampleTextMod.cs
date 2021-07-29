using Oxide.Core.Libraries.Covalence;
namespace Oxide.Plugins
{
    [Info("Example Multiple-Argument Text Plugin", "YT-Rotating Fan", "0.01")]
    public class ExampleTextMod : CovalencePlugin
    {
        [Command("help")]
        private void HelpCommand(IPlayer player, string command, string[] args)
        {
            // args[0] will only return the arg directly after the command!
            string CustomError = "Argument not found: " + args[0] + " for parent command: "+command;
            switch (args[0])
            {
                case "command1":
                    // test command 1
                    player.Reply("Respond with help for the command: command1");
                    break;
                case "command2":
                    // test command 2
                    player.Reply("Respond with help for the command: command2");
                    break;
                case "command3":
                    // test command 3
                    player.Reply("Respond with help for the command: command3");
                    break;
                default:
                    // this will run when there is no argument set that matches the one the player used in game, so in our case, this default will return an error shown in line 9
                    player.Reply(CustomError);
                    break;
            }
        }
    }
}
