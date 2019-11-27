using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class Race
    {

        public string assignedRace { get; set; }
        public string raceDescription { get; set; }


        public string RaceGenerator()
            {
            List<string> raceOptions = new List<string>();
            raceOptions.Add("Dragonborn");
            raceOptions.Add("Dwarf");
            raceOptions.Add("Elf");
            raceOptions.Add("Gnome");
            raceOptions.Add("Half-Elf");
            raceOptions.Add("Halfling");
            raceOptions.Add("Half-Orc");
            raceOptions.Add("Human");
            raceOptions.Add("Tiefling");
            raceOptions.Add("Genasi");
            raceOptions.Add("Aasimar");

            Random rnd = new Random();
            int r = rnd.Next(raceOptions.Count);
            assignedRace = (raceOptions[r].ToString());
            return assignedRace;
        }
        public string RaceDescription()
        {
            if (assignedRace == "Dragonborn")
            {
                raceDescription = "Tall and strongly-built, Dragonborn have scales ranging in color from silver or gold to scarlet-red or emerald-green.";
            }
            if (assignedRace == "Dwarf")
            {
               raceDescription = "Dwarves are bold and hardy, broad and compact. Though they stand under five feet tall, their courage and endurance are\na match for any of the larger folk.";
            }
            if (assignedRace == "Elf")
            {
                raceDescription = "Elves are tall and slender. With their unearthly grace and fine features, elves appear hauntingly beautiful to members\nof most other races.";
            }
            if (assignedRace == "Gnome")
            {
                raceDescription = "A gnome's energy and enthusiasm for living shine through every inch of his or her tiny body and large, sparkling eyes.";
            }
            if (assignedRace == "Half-Elf")
            {
                raceDescription = "Half-Elves appear in most respects to be human, but a careful eye will note their slightly pointed ears. They often\ncombine the best qualities of their elf and human parents, yet walk in two worlds, never truly belonging to either.";
            }
            if (assignedRace == "Halfling")
            {
                raceDescription = "The diminutive halflings are an affable and cheerful people. They cherish the bonds of family and friendship and the\ncomforts of home above all else.";
            }
            if (assignedRace == "Half-Orc")
            {
                raceDescription = "Half-Orcs' grey-greenish pigmentation, sloping foreheads, jutting jaws, prominent teeth, and towering builds make their orcish heritage plain for all to see.";
            }
            if (assignedRace == "Human")
            {
                raceDescription = "Humans are the youngest and most diverse of the common races. Because of their shorter lives, they strive to achieve\nas much as they can in the years they are given.";
            }
            if (assignedRace == "Tiefling")
            {
                raceDescription = "Tieflings' infernal heritage has left a clear imprint on their appearance: curling horns, thick tails, sharp canine\nteeth, and skin in shades of red.";
            }
            if (assignedRace == "Aasimar")
            {
                raceDescription = "Aasimar bear the mark of their celestial ancestry: hair that shines like metal, jewel-toned eyes, lustrous skin,\nand ridges of feathers, like wings trying to sprout from their backs.";
            }
            if (assignedRace == "Genasi")
            {
                raceDescription = "The offspring of genies and mortals, a Genasi's appearance takes on aspects of its elemental plane.";
            }
            return raceDescription;
        }

    }
}
