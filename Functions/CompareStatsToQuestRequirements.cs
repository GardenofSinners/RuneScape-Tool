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
            //var QuestJsonObject  = JsonConvert.DeserializeObject<QuestsJson>(QuestJSONString);
            //var PlayerJsonObject = JsonConvert.DeserializeObject<>

            //var Skill_Requirements  = QuestJsonObject.skill_requirements[0];
            //var index = 0;
            //foreach(string item in QuestJsonObject.items_required)
            //{
            //var Items_Required = QuestJsonObject.items_required[index];
            //index++;
            //}

            JObject QuestJsonObject = JObject.Parse(QuestJSONString);
        }
    }
}
