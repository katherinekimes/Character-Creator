using System;
using System.Collections.Generic;
using System.Text;
using CharacterGenerator.Classes;

namespace CharacterGenerator.Classes
{
    public class SubRace
    {
        Race newRace;

        public SubRace(Race race)
        {
            newRace = race;
        }

        public string assignedSubRace { get; set; }
        public string subRaceDescription { get; set; }

        public string SubRaceGenerator()
        {
      
            List<string> dragonbornSubRaces = new List<string>();
            dragonbornSubRaces.Add("Black");
            dragonbornSubRaces.Add("Blue");
            dragonbornSubRaces.Add("Brass");
            dragonbornSubRaces.Add("Bronze");
            dragonbornSubRaces.Add("Copper");
            dragonbornSubRaces.Add("Gold");
            dragonbornSubRaces.Add("Green");
            dragonbornSubRaces.Add("Red");
            dragonbornSubRaces.Add("Silver");
            dragonbornSubRaces.Add("White");

            List<string> dwarfSubRaces = new List<string>();
            dwarfSubRaces.Add("Hill");
            dwarfSubRaces.Add("Mountain");

            List<string> elfSubRaces = new List<string>();
            elfSubRaces.Add("High");
            elfSubRaces.Add("Wood");

            List<string> halflingSubRaces = new List<string>();
            halflingSubRaces.Add("Stout");
            halflingSubRaces.Add("Lightfoot");

            List<string> gnomeSubRaces = new List<string>();
            gnomeSubRaces.Add("Deep");
            gnomeSubRaces.Add("Rock");

            List<string> genasiSubRaces = new List<string>();
            genasiSubRaces.Add("Air");
            genasiSubRaces.Add("Water");
            genasiSubRaces.Add("Earth");
            genasiSubRaces.Add("Fire");

            assignedSubRace = "";
            if (newRace.assignedRace == "Dragonborn")
            {
                Random subrace = new Random();
                int s = subrace.Next(dragonbornSubRaces.Count);
                assignedSubRace += (dragonbornSubRaces[s].ToString());
            }
            if (newRace.assignedRace == "Dwarf")
            {
                Random subrace = new Random();
                int s = subrace.Next(dwarfSubRaces.Count);
                assignedSubRace += (dwarfSubRaces[s].ToString());
            }
            if (newRace.assignedRace == "Elf")
            {
                Random subrace = new Random();
                int s = subrace.Next(elfSubRaces.Count);
                assignedSubRace += (elfSubRaces[s].ToString());
            }
            if (newRace.assignedRace == "Gnome")
            {
                Random subrace = new Random();
                int s = subrace.Next(gnomeSubRaces.Count);
                assignedSubRace += (gnomeSubRaces[s].ToString());
            }
            if (newRace.assignedRace == "Genasi")
            {
                Random subrace = new Random();
                int s = subrace.Next(genasiSubRaces.Count);
                assignedSubRace += (genasiSubRaces[s].ToString());
            }
            if (newRace.assignedRace == "Halfling")
            {
                Random subrace = new Random();
                int s = subrace.Next(halflingSubRaces.Count);
                assignedSubRace += (halflingSubRaces[s].ToString());
            }
            return assignedSubRace;
        }

        public string SubRaceDescription()
        {
            if ((assignedSubRace == "Black") | (assignedSubRace == "Copper"))
            {
                subRaceDescription = ($"\nAs a {assignedSubRace} Dragonborn, you are resistant to acid damage and can spit a vicious stream of acid at your foes.");
            }
            if ((assignedSubRace == "Blue") | (assignedSubRace == "Bronze"))
            {
                subRaceDescription = ($"\nAs a {assignedSubRace} Dragonborn, you are resistant to lightning damage and can shoot a bolt of lightning from your maw.");
            }
            if ((assignedSubRace == "Brass") | (assignedSubRace == "Gold") | (assignedSubRace == "Red"))
            {
                subRaceDescription = ($"\nAs a {assignedSubRace} Dragonborn, you are resistant to fire damage and can breath a jet of flame up to 30 feet!");
            }
            if (assignedSubRace == "Green")
            {
                subRaceDescription = ($"\nAs a {assignedSubRace} Dragonborn, you are resistant to poison and can spew a stream of poison on your foes!");
            }
            if (assignedSubRace == "Silver" | assignedSubRace == "White")
            {
                subRaceDescription = ($"\nAs a {assignedSubRace} Dragonborn, you are resistant to cold damage and can chill your enemies with your icy breath!");
            }
            if (assignedSubRace == "Hill")
            {
                subRaceDescription = "As a Hill Dwarf, you have deep intuition and remarkable resilience.";
            }
            if (assignedSubRace == "Mountain")
            {
                subRaceDescription = "As a Mountain Dwarf, you are accustomed to a hard life in rugged terrain.";
            }
            if (assignedSubRace == "High")
            {
                subRaceDescription = "As a High Elf, you have a keen mind and a mastery of at least the basics of magic.";
            }
            if (assignedSubRace == "Wood")
            {
                subRaceDescription = "As a Wood Elf, you have keen senses and intuition, and your feet carry you quickly and stealthily\nthrough your native forests.";
            }
            if (assignedSubRace == "Lightfoot")
            {
                subRaceDescription = "As a Lightfoot Halfling, you can hide during combat, even using your allies as cover.";
            }
            if (assignedSubRace == "Stout")
            {
                subRaceDescription = "As a Stout Halfling, you are especially hardy and have a natural resistence to poison.";
            }
            if (assignedSubRace == "Rock")
            {
                subRaceDescription = "\nAs a Rock Gnome, you have a natural inventiveness and hardiness.";
            }
            if (assignedSubRace == "Deep")
            {
                subRaceDescription = "\nAs a Deep Ghome, or Svirfneblin, you hail from deep underground, and are as cunning as you are loyal to your people.";
            }
            if (assignedSubRace == "Air")
            {
                subRaceDescription = "As an Air Genasi,\nyou have light blue hair and skin, a constant tousled appearance, and a breathy voice.";
            }
            if (assignedSubRace == "Earth")
            {
                subRaceDescription = "As an Earth Genasi,\nyou have earth-toned skin, eyes like gemstones, and possibly even crystals embedded in your flesh instead of hair.";
            }
            if (assignedSubRace == "Fire")
            {
                subRaceDescription = "As a Fire Genasi,\nyou may have eyes that flare with anger, a voice like crackling flame, and the faint smell of brimstone.";
            }
            if (assignedSubRace == "Water")
            {
                subRaceDescription = "As a Water Genasi,\nyou have eyes like green-blue lagoons, perpetual beads of moisture in your hair, and the smell of fresh rain.";
            }
            return subRaceDescription;
        }
    }
}
