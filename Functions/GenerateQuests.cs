using Newtonsoft.Json.Linq;

namespace RuneScape_Tool
{
    public class GenerateQuests
    {
        private static readonly JArray skills = new JArray();
        private static readonly JArray items = new JArray();
        private static readonly JArray qSteps = new JArray();
        private static readonly JArray qRewards = new JArray();
        private static readonly JsonHandler _jsonHandler = new JsonHandler();

        public static void ExecuteQuestGeneration()
        {
            Cooks_Assistant();
            The_Restless_Ghost();
            Rune_Mysteries();
        }
        private static void Cooks_Assistant()
        {

            //Skill requirements
            SkillRequirements(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            //Item requirements
            items.Add("Empty Pot");
            items.Add("A Bucket");
            items.Add("An Egg");

            //Quest instructions
            qSteps.Add("To begin the quest, talk to the Cook on the ground floor of Lumbridge Castle inside the kitchen he will and ask you bring him a bucket of milk, an egg, and a pot of flour.");
            qSteps.Add("To Get a Bucket of Milk go east and across the River Lum then walk north to the Lumbridge cow field and use the empty bucket on a dairy cow to obtain some milk.");
            qSteps.Add("From the cow field, follow the path north-west towards the chicken coop and pick up an egg.");
            qSteps.Add("With an empty pot, head north of lumbridge and follow the path until you reach the mill. Collect grain from the fields outside of the mill. Head to the top floor and put the wheat in the hopper then pull the lever. Back on the ground floor, use your pot to collect flour from the bin.");
            qSteps.Add("After collecting all the ingredients, take them back to the cook. Speak to him one last time to give him the ingredients.");

            //Quest rewards
            qRewards.Add(1);
            qRewards.Add("300 Cooking XP");

            //Write all JArray's to a JSON format file.
            AddToJsonFile("Cooks_Assistant");

            // Clear the JArray for the next quest
            ClearJArray();
        }

        private static void The_Restless_Ghost()
        {

            //Skill requirements
            SkillRequirements(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            //Item requirements
            items.Add("None");

            //Quest instructions
            qSteps.Add("Talk to Father Aereck located in the Lumbridge chapel just east of Bob's Brilliant Axes, and he will tell you that a ghost is haunting the graveyard in Lumbridge. He needs you to help him. He wants you to talk to Father Urhney, located in a house west of Lumbridge Swamp, and get some information from him on ghosts.");
            qSteps.Add("Go south of the castle, and then keep going west in the swamps. You'll soon come upon a small house. Go inside, and talk to Father Urhney about Father Aereck needing help with the ghost haunting the graveyard. He will give you an amulet of ghostspeak so that you're able to talk to the ghost. It is advised to keep the amulet for future quests. Now, go back to the graveyard in Lumbridge, and go to the marble coffin that is located in a small house by the graveyard.");
            qSteps.Add("Wear your amulet of ghostspeak and search the coffin. Talk to the ghost who comes out. He will tell you he is missing his skull and wants you to get it for him. He will say he was near the Wizards' Tower on an island south of Draynor Village.");
            qSteps.Add("Head to the Wizards' Tower, and climb down the ladder in the room directly next to the entrance. Down the ladder you will find an altar. Search the altar. The ghost's skull shall be there, but when you grab it, a skeleton will appear and attack you. Fighting it is optional, so kill it or run, and make sure you have the skull in your inventory. Then, go back to the Lumbridge graveyard.");
            qSteps.Add("Talk to the ghost. He'll want you to put it in his coffin. Use the skull with the coffin and he will rest in peace. You will see his spirit disappear into the river. When you have done this, you will have finished the quest.");

            //Quest rewards
            qRewards.Add(1);
            qRewards.Add("1125 Prayer XP");

            //Write all JArray's to a JSON format file.
            AddToJsonFile("The_Restless_Ghost");

            // Clear the JArray for the next quest
            ClearJArray();

        }

        private static void Rune_Mysteries()
        {
            //Skill requirements
            SkillRequirements(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            //Item requirements
            items.Add("None");

            //Quest instructions
            qSteps.Add("Talk to Duke Horacio on the 1st floor of Lumbridge Castle, and ask him if he has any quests to give out. He will explain that although he himself has no tasks for the player, he did find a strange talisman. Curious about its origin, he will give you an air talisman and ask you to bring it to the arch mage of the Wizards' Tower.");
            qSteps.Add("Go to the Wizards' Tower, which is south of Draynor Village. Once there, descend the ladder into the basement and converse with Wizard Sedridor. He will take your air talisman and give you a Research package. He will then instruct you to deliver it to Aubury in Varrock.");
            qSteps.Add("Talk to Aubury twice, and he will give you some notes and instruct you to deliver them back to Wizard Sedridor.");
            qSteps.Add("Make your way back to the Wizards' Tower, and talk to Wizard Sedridor once more. He will give you back your air talisman and will explain to you the basics of Runecraft.");

            //Quest rewards
            qRewards.Add(1);
            qRewards.Add("Runecrafting Skill Access");
            qRewards.Add("Air Talisman");

            //Write all JArray's to a JSON format file.
            AddToJsonFile("Rune_Mysteries");

            // Clear the JArray for the next quest
            ClearJArray();

        }

        #region Methods to make the quest generation not look super ugly.
        #region Skill Requirements Method ( Looks Ugly )
        private static void SkillRequirements(int Overall, int Attack, int Defence, int Strength, 
            int Hitpoints, int Ranged, int Prayer, int Magic, int Cooking, int Woodcutting, int Fletching, int Fishing,
            int Firemaking, int Crafting, int Smithing, int Mining, int Herblore, int Agility, int Thieving, int Slayer,
            int Farming, int Runecrafting, int Hunter, int Construction)
        {
            //Skill requirements
            skills.Add(Overall);
            skills.Add(Attack);
            skills.Add(Defence);
            skills.Add(Strength);
            skills.Add(Hitpoints);
            skills.Add(Ranged);
            skills.Add(Prayer);
            skills.Add(Magic);
            skills.Add(Cooking);
            skills.Add(Woodcutting);
            skills.Add(Fletching);
            skills.Add(Fishing);
            skills.Add(Firemaking);
            skills.Add(Crafting);
            skills.Add(Smithing);
            skills.Add(Mining);
            skills.Add(Herblore);
            skills.Add(Agility);
            skills.Add(Thieving);
            skills.Add(Slayer); 
            skills.Add(Farming);
            skills.Add(Runecrafting); 
            skills.Add(Hunter); 
            skills.Add(Construction); 
        }
        #endregion

        private static void AddToJsonFile(string QuestFileName)
        {
            //Write all JArray's to a JSON format file.
            _jsonHandler.Write("skill_requirements", skills, @"Quests\Old School Runescape\" + QuestFileName + ".json");
            _jsonHandler.Write("items_required", items, @"Quests\Old School Runescape\" + QuestFileName + ".json");
            _jsonHandler.Write("quest_steps", qSteps, @"Quests\Old School Runescape\" + QuestFileName + ".json");
            _jsonHandler.Write("quest_rewards", qRewards, @"Quests\Old School Runescape\" + QuestFileName + ".json");
        }

        private static void ClearJArray()
        {
            //Clear all JArray's for the next quest.
            skills.RemoveAll();
            items.RemoveAll();
            qSteps.RemoveAll();
            qRewards.RemoveAll();
        }
        #endregion
    }
}
