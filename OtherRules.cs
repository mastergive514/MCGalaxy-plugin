# You Need to Edit rules On 29 Line
# You Can Use p.Message(""); for other rule

using System;
using MCGalaxy;

namespace Core {
    public class CommandsInPluginExample : Plugin {  
        public override string creator { get { return "AlboDichi"; } }
        public override string MCGalaxy_Version { get { return "1.9.4.1"; } }
        public override string name { get { return "Otherrule"; } }

        public override void Load(bool startup) {
            Command.Register(new CmdOtherrules());
        }
        
        public override void Unload(bool shutdown) {
        	Command.Unregister(Command.Find("Otherrules"));
        }
    }
    
    public class CmdSomething : Command2 {
        public override string name { get { return "otherrules"; } }
        public override string type { get { return "other"; } }
        public override LevelPermission defaultRank { get { return LevelPermission.Operator; } }
        
        public override void Use(Player p, string message) {
            p.Message("&eOther rules:");
            p.Message("");
        }

        public override void Help(Player p) {
            p.Message("%T/Otherrules %S- See Other rules for Server");
        }
    }
}
