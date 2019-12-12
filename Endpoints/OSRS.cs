using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneScape_Tool.Endpoints
{
    class OSRS
    {

        // A username needs to be added to the end of the string in order for this to work
        // At the current time all this does is give a standard link which you can apply the username to afterwards.

        public const string Hiscore_Regular             = "secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=";
        public const string Hiscore_Ironman             = "secure.runescape.com/m=hiscore_oldschool_ironman/index_lite.ws?player=";
        public const string Hiscore_Hardcore_Ironman    = "secure.runescape.com/m=hiscore_oldschool_hardcore_ironman/index_lite.ws?player=";
        public const string Hiscore_Ultimate_Ironoman   = "secure.runescape.com/m=hiscore_oldschool_ultimate/index_lite.ws?player=";
        public const string Hiscore_Deadman_Ironman     = "secure.runescape.com/m=hiscore_oldschool_deadman/index_lite.ws?player=";
        public const string Hiscore_Season              = "secure.runescape.com/m=hiscore_oldschool_seasonal/index_lite.ws?player=";
        public const string Hiscore_Tournament          = "secure.runescape.com/m=hiscore_oldschool_tournament/index_lite.ws?player=";

    }
}
