using System;
using System.Collections.Generic;
using System.Text;
using CharacterGenerator.Classes;

namespace CharacterGenerator.Classes
{
    public class Equipment
    {
        public string startingEquipment { get; set; }

        PlayerClass newClass;

        public Equipment(PlayerClass playerClass)
        {
            newClass = playerClass;
        }

        public string Equip()
        {
            List<string> simpleMeleeWeapons = new List<string>();
            simpleMeleeWeapons.Add("Club");
            simpleMeleeWeapons.Add("Handaxe");
            simpleMeleeWeapons.Add("Hammer");
            simpleMeleeWeapons.Add("Mace");
            simpleMeleeWeapons.Add("Quarterstaff");
            simpleMeleeWeapons.Add("Sickle");
            simpleMeleeWeapons.Add("Spear");

            Random simpleMelee = new Random();
            int selectedSimpleMelee = simpleMelee.Next(simpleMeleeWeapons.Count);
            string assignedSimpleMelee = (simpleMeleeWeapons[selectedSimpleMelee].ToString());

            List<string> finesseMeleeWeapons = new List<string>();
            finesseMeleeWeapons.Add("Dagger");
            finesseMeleeWeapons.Add("Rapier");
            finesseMeleeWeapons.Add("Shortsword");
            finesseMeleeWeapons.Add("Scimitar");
            finesseMeleeWeapons.Add("Whip");

            Random finesseMelee = new Random();
            int selectedFinesseMelee = finesseMelee.Next(finesseMeleeWeapons.Count);
            string assignedFinesseMelee = (finesseMeleeWeapons[selectedFinesseMelee].ToString());

            List<string> martialMeleeWeapons = new List<string>();
            martialMeleeWeapons.Add("Battleaxe");
            martialMeleeWeapons.Add("Glaive");
            martialMeleeWeapons.Add("Greataxe");
            martialMeleeWeapons.Add("Greatsword");
            martialMeleeWeapons.Add("Lance");
            martialMeleeWeapons.Add("Longsword");
            martialMeleeWeapons.Add("Maul");
            martialMeleeWeapons.Add("Morningstar");
            martialMeleeWeapons.Add("Pike");
            martialMeleeWeapons.Add("Trident");
            martialMeleeWeapons.Add("Warhamer");

            Random martialMelee = new Random();
            int selectedMartialMelee = martialMelee.Next(martialMeleeWeapons.Count);
            string assignedMartialMelee = (martialMeleeWeapons[selectedMartialMelee].ToString());

            List<string> simpleRangedWeapons = new List<string>();
            simpleRangedWeapons.Add("Light Crossbow");
            simpleRangedWeapons.Add("Shortbow");
            simpleRangedWeapons.Add("Sling");

            Random simpleRanged = new Random();
            int selectedSimpleRanged = simpleRanged.Next(simpleRangedWeapons.Count);
            string assignedSimpleRanged = (simpleRangedWeapons[selectedSimpleRanged].ToString());

            List<string> instruments = new List<string>();
            instruments.Add("Lute");
            instruments.Add("Bagpipes");
            instruments.Add("Lyre");
            instruments.Add("Flute");
            instruments.Add("Pan Flute");
            instruments.Add("Viol");
            instruments.Add("Horn");
            instruments.Add("Drum");
            instruments.Add("Dulcimer");

            Random instrument = new Random();
            int inst = instrument.Next(instruments.Count);
            string assignedInstrument = (instruments[inst].ToString());

            List<string> tools = new List<string>();
            tools.Add("Alchemist's Supplies");
            tools.Add("Brewer's Supplies");
            tools.Add("Calligrapher's Supplies");
            tools.Add("Carpenter's Tools");
            tools.Add("Cartographer's Tools");
            tools.Add("Carpenter's Tools");
            tools.Add("Cartographer's Tools");
            tools.Add("Cook's Utensils");
            tools.Add("Cobbler's Tools");
            tools.Add("Glassblower's Tools");
            tools.Add("Jeweler's Tools");
            tools.Add("Mason's Tools");
            tools.Add("Leatherworker's Tools");
            tools.Add("Painter's Supplies");
            tools.Add("Potter's Tools");
            tools.Add("Smith's Tools");
            tools.Add("Tinker's Tools");
            tools.Add("Weaver's Tools");
            tools.Add("Woodcarver's Tools");

            Random tool = new Random();
            int selectedTool = tool.Next(tools.Count);
            string assignedTool = (tools[selectedTool].ToString());

            string burglarsPack = "-- backpack with bag of 1,000 ball bearings, 10 feet of string, a bell, 5 candles, a crowbar,\na hammer, 10 pitons, a hooded lantern, 2 flasks of oil, 5 days rations, a tinderbox, a waterskin, and 50 feet of hempen rope.";
            string dungeoneersPack = "-- backback with a crowbar, a hammer, 10 pitons, 10 torches, a tinderbox, 10 days rations,\na waterskin, and 50 feet of hempen rope.";
            string entertainersPack = "-- backpack with a bedroll, 2 costumes, 5 candles, 5 days rations, a waterskin,\nand a disguise kit.";
            string explorersPack = "-- backpack with a bedroll, a mess kit, a tinderbox, 10 torches, 10 days rations, a waterskin,\nand 50 feet of hempen rope.";
            string priestsPack = "-- backpack with a blanket, 10 candles, a tinderbox, an alms box, 2 blocks of incense,\na censer, vestments, 2 days rations, and a waterskin.";
            string scholarsPack = "-- backpack with a book of lore, a bottle of ink, an ink pen, 10 sheets of parchment,\na little bag of sand,\nand a small knife.";

            if (newClass.assignedClass == "Barbarian")
            {
                startingEquipment = ($"Armor: None\nMelee Weapons: Greataxe, 2 Handaxes\nRanged Weapons: 5 Javelins\nShield: None\nTool 1: Hunting Trap\nTool 2: {assignedTool}\nGear: Explorer's Pack {explorersPack}");
            }
            if (newClass.assignedClass == "Bard")
            {
                List<string> cantrips = new List<string>();
                cantrips.Add("Blade Ward");
                cantrips.Add("Dancing Lights");
                cantrips.Add("Friends");
                cantrips.Add("Light");
                cantrips.Add("Mage Hand");
                cantrips.Add("Mending");
                cantrips.Add("Message");
                cantrips.Add("Minor Illusion");
                cantrips.Add("Prestidigitation");
                cantrips.Add("True Strike");
                cantrips.Add("Vicious Mockery");

                List<string> spells = new List<string>();
                spells.Add("Animal Friendship");
                spells.Add("Bane");
                spells.Add("Charm Person");
                spells.Add("Comprehend Languages");
                spells.Add("Cure Wounds");
                spells.Add("Detect Magic");
                spells.Add("Disguise Self");
                spells.Add("Dissonent Whispers");
                spells.Add("Faerie Fire");
                spells.Add("Feather Fall");
                spells.Add("Healing Word");
                spells.Add("Heroism");
                spells.Add("Identify");
                spells.Add("Illusory Script");
                spells.Add("Longstrider");
                spells.Add("Silent Image");
                spells.Add("Sleep");
                spells.Add("Speak with Animals");
                spells.Add("Tasha's Hideous Laughter");
                spells.Add("Thunderwave");
                spells.Add("Unseen Servant");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: Leather Armor\nMelee Weapons: Rapier, Dagger\nRanged Weapons: None\nShield: None\nTool: {assignedTool}\nGear: Entertainer's Pack {entertainersPack}\nInstrument: {assignedInstrument}\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}, {assignedSpell3}, {assignedSpell4}");
            }
            if (newClass.assignedClass == "Cleric")
            {
                List<string> cantrips = new List<string>();
                cantrips.Add("Guidance");
                cantrips.Add("Light");
                cantrips.Add("Mending");
                cantrips.Add("Resistance");
                cantrips.Add("Sacred Flame");
                cantrips.Add("Spare the Dying");
                cantrips.Add("Thaumaturgy");

                List<string> spells = new List<string>();
                spells.Add("Bane");
                spells.Add("Bless");
                spells.Add("Command");
                spells.Add("Create or Destroy Water");
                spells.Add("Cure Wounds");
                spells.Add("Detect Evil and Good");
                spells.Add("Detect Magic");
                spells.Add("Detect Poison and Disease");
                spells.Add("Guiding Bolt");
                spells.Add("Healing Word");
                spells.Add("Inflict Wounds");
                spells.Add("Protection from Evil and Good");
                spells.Add("Purify Food and Drink");
                spells.Add("Sanctuary");
                spells.Add("Shield of Faith");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random cantrip3 = new Random();
                int selectedCantrip3 = cantrip3.Next(cantrips.Count);
                string assignedCantrip3 = (cantrips[selectedCantrip3].ToString());
                cantrips.Remove(assignedCantrip3);

                Random cantrip4 = new Random();
                int selectedCantrip4 = cantrip4.Next(cantrips.Count);
                string assignedCantrip4 = (cantrips[selectedCantrip4].ToString());
                cantrips.Remove(assignedCantrip4);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: Chainmail\nMelee Weapons: Warhammer\nRanged Weapons: Light Crossbow, Case with 20 Bolts\nShield: Metal Shield\nTool: {assignedTool}\nGear: Priest's Pack {priestsPack}\nMagical Focus: Holy Symbol\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}, {assignedCantrip3}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}");
            }
            if (newClass.assignedClass == "Druid")
            {
                List<string> cantrips = new List<string>();
                cantrips.Add("Druidcraft");
                cantrips.Add("Guidance");
                cantrips.Add("Mending");
                cantrips.Add("Poison Spray");
                cantrips.Add("Produce Flame");
                cantrips.Add("Resistance");
                cantrips.Add("Shillelagh");

                List<string> spells = new List<string>();
                spells.Add("Animal Friendship");
                spells.Add("Charm Person");
                spells.Add("Create or Destroy Water");
                spells.Add("Cure Wounds");
                spells.Add("Detect Magic");
                spells.Add("Detect Poison and Disease");
                spells.Add("Entangle");
                spells.Add("Faerie Fire");
                spells.Add("Fog Cloud");
                spells.Add("Goodberry");
                spells.Add("Healing Word");
                spells.Add("Jump");
                spells.Add("Longstrider");
                spells.Add("Purify Food and Drink");
                spells.Add("Speak with Animals");
                spells.Add("Thunderwave");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random cantrip3 = new Random();
                int selectedCantrip3 = cantrip3.Next(cantrips.Count);
                string assignedCantrip3 = (cantrips[selectedCantrip3].ToString());
                cantrips.Remove(assignedCantrip3);

                Random cantrip4 = new Random();
                int selectedCantrip4 = cantrip4.Next(cantrips.Count);
                string assignedCantrip4 = (cantrips[selectedCantrip4].ToString());
                cantrips.Remove(assignedCantrip4);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: Leather Armor\nMelee Weapons: Scimitar\nRanged Weapons: {assignedSimpleRanged}\nShield: Wooden Shield\nTool: {assignedTool}\nGear: Explorer's Pack {explorersPack}\nMagical Focus: Druidic Focus\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}, {assignedSpell3}");
            }
            if (newClass.assignedClass == "Fighter")
            {
                startingEquipment = ($"Armor: Chainmail\nMelee Weapons: {assignedMartialMelee}\nRanged Weapons: Light Crossbow, Case with 20 Bolts\nShield: Metal Shield\nTool: {assignedTool}\nGear: Explorer's Pack {explorersPack}");
            }
            if (newClass.assignedClass == "Monk")
            {
                startingEquipment = ($"Armor: None\nMelee Weapons: Shortsword\nRanged Weapons: 10 Throwing Darts\nUnarmed Strike: You can deal significant damage with kicks and punches\nShield: None\nTool: {assignedTool}\nGear: Explorer's Pack {explorersPack}");
            }
            if (newClass.assignedClass == "Paladin")
            {
                startingEquipment = ($"Armor: Chainmail\nMelee Weapons: {assignedMartialMelee}\nRanged Weapons: 5 Javelins\nShield: Metal Shield\nTool 1: {assignedTool}\nGear: Explorer's Pack {explorersPack}\nMagical Focus: Holy Symbol");
            }
            if (newClass.assignedClass == "Ranger")
            {
                startingEquipment = ($"Armor: Leather Armor\nMelee Weapons: 2 Shortswords\nRanged Weapons: Longbow, Quiver with 20 Arrows\nShield: None\nTool: {assignedTool}\nGear: Explorer's Pack {explorersPack}");
            }
            if (newClass.assignedClass == "Rogue")
            {
                startingEquipment = ($"Armor: Leather Armor\nMelee Weapons: Rapier, 2 Daggers\nRanged Weapons: Shortbow, Quiver with 20 Arrows\nShield: None\nTool: Thieve's Tools\nGear: Burglar's Pack {burglarsPack}");
            }
            if (newClass.assignedClass == "Sorcerer")
            {
                List<string> cantrips = new List<string>();
                cantrips.Add("Acid Splash");
                cantrips.Add("Chill Touch");
                cantrips.Add("Dancing Lights");
                cantrips.Add("Fire Bolt");
                cantrips.Add("Light");
                cantrips.Add("Mending");
                cantrips.Add("Message");
                cantrips.Add("Minor Illusion");
                cantrips.Add("Poison Spray");
                cantrips.Add("Prestidigitation");
                cantrips.Add("Ray of Frost");
                cantrips.Add("Shocking Grasp");
                cantrips.Add("True Strike");

                List<string> spells = new List<string>();
                spells.Add("Burning Hands");
                spells.Add("Charm Person");
                spells.Add("Color Spray");
                spells.Add("Comprehend Languages");
                spells.Add("Detect Magic");
                spells.Add("Disguise Self");
                spells.Add("Expeditious Retreat");
                spells.Add("False Life");
                spells.Add("Feather Fall");
                spells.Add("Fog Cloud");
                spells.Add("Jump");
                spells.Add("Mage Armor");
                spells.Add("Magic Missile");
                spells.Add("Shield");
                spells.Add("Silent Image");
                spells.Add("Sleep");
                spells.Add("Thunderwave");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random cantrip3 = new Random();
                int selectedCantrip3 = cantrip3.Next(cantrips.Count);
                string assignedCantrip3 = (cantrips[selectedCantrip3].ToString());
                cantrips.Remove(assignedCantrip3);

                Random cantrip4 = new Random();
                int selectedCantrip4 = cantrip4.Next(cantrips.Count);
                string assignedCantrip4 = (cantrips[selectedCantrip4].ToString());
                cantrips.Remove(assignedCantrip4);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: None\nMelee Weapons: 2 Daggers\nRanged Weapons: Light Crossbow, Case with 20 Bolts\nShield: None\nTool: {assignedTool}\nGear: Explorer's Pack {explorersPack}\nMagical Focus: Arcane Focus\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}, {assignedCantrip3}, {assignedCantrip4}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}");
            }
            if (newClass.assignedClass == "Warlock")
            {
                List<string> cantrips = new List<string>();
                cantrips.Add("Chill Touch");
                cantrips.Add("Eldritch Blast");
                cantrips.Add("Mage Hand");
                cantrips.Add("Minor Illusion");
                cantrips.Add("Poison Spray");
                cantrips.Add("Prestidigitation");
                cantrips.Add("True Strike");

                List<string> spells = new List<string>();
                spells.Add("Charm Person");
                spells.Add("Comprehend Languages");
                spells.Add("Expeditious Retreat");
                spells.Add("Hellish Rebuke");
                spells.Add("Illusory Script");
                spells.Add("Protection from Good and Evil");
                spells.Add("Unseen Servant");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random cantrip3 = new Random();
                int selectedCantrip3 = cantrip3.Next(cantrips.Count);
                string assignedCantrip3 = (cantrips[selectedCantrip3].ToString());
                cantrips.Remove(assignedCantrip3);

                Random cantrip4 = new Random();
                int selectedCantrip4 = cantrip4.Next(cantrips.Count);
                string assignedCantrip4 = (cantrips[selectedCantrip4].ToString());
                cantrips.Remove(assignedCantrip4);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: Leather Armor\nMelee Weapons: {assignedSimpleMelee}, 2 Daggers\nRanged Weapons: Light Crossbow, Case with 20 Bolts\nShield: None\nTool: {assignedTool}\nGear: Dungeoneer's Pack {dungeoneersPack}\nMagical Focus: Arcane Focus\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}");
            }
            if (newClass.assignedClass == "Wizard")
            {

                List<string> cantrips = new List<string>();
                cantrips.Add("Acid Splash");
                cantrips.Add("Chill Touch");
                cantrips.Add("Dancing Lights");
                cantrips.Add("Fire Bolt");
                cantrips.Add("Light");
                cantrips.Add("Mage Hand");
                cantrips.Add("Mending");
                cantrips.Add("Message");
                cantrips.Add("Minor Illusion");
                cantrips.Add("Poison Spray");
                cantrips.Add("Prestidigitation");
                cantrips.Add("Ray of Frost");
                cantrips.Add("Shocking Grasp");
                cantrips.Add("True Strike");

                List<string> spells = new List<string>();
                spells.Add("Alarm");
                spells.Add("Burning Hands");
                spells.Add("Charm Person");
                spells.Add("Color Spray");
                spells.Add("Comprehend Languages");
                spells.Add("Detect Magic");
                spells.Add("Disguise Self");
                spells.Add("Expeditious Retreat");
                spells.Add("False Life");
                spells.Add("Feather Fall");
                spells.Add("Find Familiar");
                spells.Add("Floating Disk");
                spells.Add("Fog Cloud");
                spells.Add("Grease");
                spells.Add("Hideous Laughter");
                spells.Add("Identify");
                spells.Add("Illusory Script");
                spells.Add("Jump");
                spells.Add("Longstrider");
                spells.Add("Mage Armor");
                spells.Add("Magic Missile");
                spells.Add("Protection from Evil and Good");
                spells.Add("Shield");
                spells.Add("Silent Image");
                spells.Add("Sleep");
                spells.Add("Thunderwave");
                spells.Add("Unseen Servan");

                Random cantrip1 = new Random();
                int selectedCantrip1 = cantrip1.Next(cantrips.Count);
                string assignedCantrip1 = (cantrips[selectedCantrip1].ToString());
                cantrips.Remove(assignedCantrip1);

                Random cantrip2 = new Random();
                int selectedCantrip2 = cantrip2.Next(cantrips.Count);
                string assignedCantrip2 = (cantrips[selectedCantrip2].ToString());
                cantrips.Remove(assignedCantrip2);

                Random cantrip3 = new Random();
                int selectedCantrip3 = cantrip3.Next(cantrips.Count);
                string assignedCantrip3 = (cantrips[selectedCantrip3].ToString());
                cantrips.Remove(assignedCantrip3);

                Random cantrip4 = new Random();
                int selectedCantrip4 = cantrip4.Next(cantrips.Count);
                string assignedCantrip4 = (cantrips[selectedCantrip4].ToString());
                cantrips.Remove(assignedCantrip4);

                Random spell1 = new Random();
                int selectedSpell1 = spell1.Next(spells.Count);
                string assignedSpell1 = (spells[selectedSpell1].ToString());
                spells.Remove(assignedSpell1);

                Random spell2 = new Random();
                int selectedSpell2 = spell1.Next(spells.Count);
                string assignedSpell2 = (spells[selectedSpell2].ToString());
                spells.Remove(assignedSpell2);

                Random spell3 = new Random();
                int selectedSpell3 = spell3.Next(spells.Count);
                string assignedSpell3 = (spells[selectedSpell3].ToString());
                spells.Remove(assignedSpell3);

                Random spell4 = new Random();
                int selectedSpell4 = spell1.Next(spells.Count);
                string assignedSpell4 = (spells[selectedSpell4].ToString());
                spells.Remove(assignedSpell4);

                startingEquipment = ($"Armor: None\nMelee Weapons: Quarterstaff\nRanged Weapons: None\nShield: None\nTool: {assignedTool}\nGear: Scholar's Pack {scholarsPack}\nMagical Focus: Spellbook\nCantrips (at-will spells): {assignedCantrip1}, {assignedCantrip2}, {assignedCantrip3}\nSpells (limited number per day): {assignedSpell1}, {assignedSpell2}");
            }
            return startingEquipment;


        }
    }
}
    

 