using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneScape_Tool.Functions
{
    class CompareStatsToQuestRequirements
    {
        public void CompareQuestRequirements(string QuestJSONString /*, string PlayerStats*/)
        {
            JObject QuestJsonObject = JObject.Parse(QuestJSONString);

            var Skill_Requirements = QuestJsonObject["skill_requirements"];

            foreach(var item in Skill_Requirements)
            {
                //Do stuff with <item>.
            }
        }
    }
}
