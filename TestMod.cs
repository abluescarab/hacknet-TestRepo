using Pathfinder.Util;
using Pathfinder.Command;

namespace TestMod {
    public class TestMod : Pathfinder.IPathfinderMod {
        public const string Name = "Test Mod";
        public const string Version = "2_0";
        public const string ID = Name + " v" + Version;
        public const string Author = "abluescarab";
        public string Identifier => ID;

        public void Load() {
            Logger.Verbose("Loading " + ID + "...");
        }

        public void LoadContent() {
            Handler.AddCommand(Commands.MyCommand.Key, Commands.MyCommand.RunCommand, Commands.MyCommand.Description, true);
        }

        public void Unload() {
            Logger.Verbose("Unloading " + ID + "...");
        }
    }
}
