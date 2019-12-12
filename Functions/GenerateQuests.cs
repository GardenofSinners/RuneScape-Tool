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

        public static void ExecuteClassGeneration()
        {
            Cooks_Assistant();
            The_Restless_Ghost();
        }
        private static void Cooks_Assistant()
        {

            //Skill requirements
            skills.Add("0"); //Overall
            skills.Add("0"); //Attack
            skills.Add("0"); //Defence
            skills.Add("0"); //Strength
            skills.Add("0"); //Hitpoints
            skills.Add("0"); //Ranged
            skills.Add("0"); //Prayer
            skills.Add("0"); //Magic
            skills.Add("0"); //Cooking
            skills.Add("0"); //Woodcutting
            skills.Add("0"); //Fletching
            skills.Add("0"); //Fishing
            skills.Add("0"); //Firemaking
            skills.Add("0"); //Crafting
            skills.Add("0"); //Smithing
            skills.Add("0"); //Mining
            skills.Add("0"); //Herblore
            skills.Add("0"); //Agility
            skills.Add("0"); //Thieving
            skills.Add("0"); //Slayer
            skills.Add("0"); //Farming
            skills.Add("0"); //Runecrafting
            skills.Add("0"); //Hunter
            skills.Add("0"); //Construction

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
            _jsonHandler.Write("skill_requirements", skills, @"Quests\Old School Runescape\Cooks_Assistant.json");
            _jsonHandler.Write("items_required", items, @"Quests\Old School Runescape\Cooks_Assistant.json");
            _jsonHandler.Write("quest_steps", qSteps, @"Quests\Old School Runescape\Cooks_Assistant.json");
            _jsonHandler.Write("quest_rewards", qRewards, @"Quests\Old School Runescape\Cooks_Assistant.json");

            //Clear all JArray's for the next quest.
            skills.RemoveAll();
            items.RemoveAll();
            qSteps.RemoveAll();
            qRewards.RemoveAll();
        }

        private static void The_Restless_Ghost()
        {

            //Skill requirements
            skills.Add("0"); //Overall
            skills.Add("0"); //Attack
            skills.Add("0"); //Defence
            skills.Add("0"); //Strength
            skills.Add("0"); //Hitpoints
            skills.Add("0"); //Ranged
            skills.Add("0"); //Prayer
            skills.Add("0"); //Magic
            skills.Add("0"); //Cooking
            skills.Add("0"); //Woodcutting
            skills.Add("0"); //Fletching
            skills.Add("0"); //Fishing
            skills.Add("0"); //Firemaking
            skills.Add("0"); //Crafting
            skills.Add("0"); //Smithing
            skills.Add("0"); //Mining
            skills.Add("0"); //Herblore
            skills.Add("0"); //Agility
            skills.Add("0"); //Thieving
            skills.Add("0"); //Slayer
            skills.Add("0"); //Farming
            skills.Add("0"); //Runecrafting
            skills.Add("0"); //Hunter
            skills.Add("0"); //Construction

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
            _jsonHandler.Write("skill_requirements", skills, @"Quests\Old School Runescape\The_Restless_Ghost.json");
            _jsonHandler.Write("items_required", items, @"Quests\Old School Runescape\The_Restless_Ghost.json");
            _jsonHandler.Write("quest_steps", qSteps, @"Quests\Old School Runescape\The_Restless_Ghost.json");
            _jsonHandler.Write("quest_rewards", qRewards, @"Quests\Old School Runescape\The_Restless_Ghost.json");

            //Clear all JArray's for the next quest.
            skills.RemoveAll();
            items.RemoveAll();
            qSteps.RemoveAll();
            qRewards.RemoveAll();
        }
    }
}
