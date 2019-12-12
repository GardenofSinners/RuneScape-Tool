using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuneScape_Tool.Functions
{
    class QuestsJson
    {
        public class SkillRequirements
        {
            public string first { get; set; }
        }

        public class ItemsRequired
        {
            public string item1 { get; set; }
            public string item2 { get; set; }
            public string item3 { get; set; }
        }

        public class QuestSteps
        {
            public string step_1 { get; set; }
            public string step_2 { get; set; }
            public string step_3 { get; set; }
            public string step_4 { get; set; }
            public string step_5 { get; set; }
        }

        public class QuestRewards
        {
            public string quest_points { get; set; }
            public string stat_xp_1 { get; set; }
        }

        public class RootObject
        {
            public SkillRequirements skill_requirements { get; set; }
            public ItemsRequired items_required { get; set; }
            public QuestSteps quest_steps { get; set; }
            public QuestRewards quest_rewards { get; set; }
        }
    }
}
