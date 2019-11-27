using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharacterGenerator.Classes;

namespace CharacterGenerator.Classes
{
    public class Stats
    {

        Race newRace;
        SubRace newSubRace;
        PlayerClass newClass;

        public Stats(Race race, SubRace subRace, PlayerClass playerClass)
        {
            newRace = race;
            newSubRace = subRace;
            newClass = playerClass;
        }

        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }


        public void StatGenerator()
        {
            Random random = new Random();

            int GenerateStat(int roll1, int roll2, int roll3, int roll4)
            {
                roll1 = random.Next(1, 6);
                roll2 = random.Next(1, 6);
                roll3 = random.Next(1, 6);
                roll4 = random.Next(1, 6);

                int sum = 0;
                if (roll1 <= roll2 && roll1 <= roll3 && roll1 <= roll4)
                {
                    sum = (roll2 + roll3 + roll4);
                }
                else if (roll2 <= roll1 && roll2 <= roll3 && roll2 <= roll4)
                {
                    sum = (roll1 + roll3 + roll4);
                }
                else if (roll3 <= roll1 && roll3 <= roll2 && roll3 <= roll4)
                {
                    sum = (roll1 + roll2 + roll4);
                }
                else
                {
                    sum = (roll1 + roll2 + roll3);
                }
                return sum;

            }
            int stat1 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));
            int stat2 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));
            int stat3 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));
            int stat4 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));
            int stat5 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));
            int stat6 = GenerateStat(random.Next(1, 6), random.Next(1, 6), random.Next(1, 6), random.Next(1, 6));

            int[] statsArray = new int[] { stat1, stat2, stat3, stat4, stat5, stat6 };
            int highestStat = statsArray.Max();
            int locationHighestStat = Array.IndexOf(statsArray, highestStat);

            List<int> currentList = new List<int>(statsArray);
            currentList.RemoveAt(locationHighestStat);
            int[] cutArray = currentList.ToArray();

            int secondHighestStat = cutArray.Max();
            int locationSecondHighestStat = Array.IndexOf(cutArray, secondHighestStat);

            List<int> finalList = new List<int>(cutArray);
            finalList.RemoveAt(locationSecondHighestStat);
            int[] finalArray = finalList.ToArray();

            strength = 0;
            dexterity = 0;
            constitution = 0;
            intelligence = 0;
            wisdom = 0;
            charisma = 0;
            if (newClass.assignedClass == "Barbarian" || newClass.assignedClass == "Fighter")
            {
                strength = highestStat;
                dexterity = finalArray[0];
                constitution = secondHighestStat;
                intelligence = finalArray[1];
                wisdom = finalArray[2];
                charisma = finalArray[3];
            }
            if (newClass.assignedClass == "Bard")
            {
                strength = finalArray[0];
                dexterity = secondHighestStat;
                constitution = finalArray[1];
                intelligence = finalArray[2];
                wisdom = finalArray[3];
                charisma = highestStat;
            }
            if (newClass.assignedClass == "Cleric")
            {
                strength = secondHighestStat;
                dexterity = finalArray[0];
                constitution = finalArray[1];
                intelligence = finalArray[2];
                wisdom = highestStat;
                charisma = finalArray[3];
            }
            if (newClass.assignedClass == "Druid")
            {
                strength = finalArray[0];
                dexterity = finalArray[1];
                constitution = secondHighestStat;
                intelligence = finalArray[3];
                wisdom = highestStat;
                charisma = finalArray[3];
            }
            if (newClass.assignedClass == "Monk" || newClass.assignedClass == "Ranger")
            {
                strength = finalArray[0];
                dexterity = highestStat;
                constitution = finalArray[1];
                intelligence = finalArray[2];
                wisdom = secondHighestStat;
                charisma = finalArray[3];
            }
            if (newClass.assignedClass == "Paladin")
            {
                strength = highestStat;
                dexterity = finalArray[0];
                constitution = finalArray[1];
                intelligence = finalArray[2];
                wisdom = finalArray[3];
                charisma = secondHighestStat;
            }
            if (newClass.assignedClass == "Rogue")
            {
                strength = finalArray[0];
                dexterity = highestStat;
                constitution = finalArray[1];
                intelligence = finalArray[2];
                wisdom = finalArray[3];
                charisma = secondHighestStat;
            }
            if (newClass.assignedClass == "Sorcerer" || newClass.assignedClass == "Warlock")
            {
                strength = finalArray[0];
                dexterity = finalArray[1];
                constitution = secondHighestStat;
                intelligence = finalArray[2];
                wisdom = finalArray[3];
                charisma = highestStat;
            }
            if (newClass.assignedClass == "Wizard")
            {
                strength = finalArray[0];
                dexterity = finalArray[1];
                constitution = secondHighestStat;
                intelligence = highestStat;
                wisdom = finalArray[2];
                charisma = finalArray[3];
            }
            if (newRace.assignedRace == "Dragonborn")
            {
                strength += 2;
                charisma += 1;
            }
            if (newRace.assignedRace == "Half-Elf")
            {
                charisma += 2;
                dexterity += 1;
            }
            if (newRace.assignedRace == "Half-Orc")
            {
                strength += 2;
                constitution += 1;
            }
            if (newRace.assignedRace == "Human")
            {
                strength += 1;
                dexterity += 1;
                constitution += 1;
                wisdom += 1;
                intelligence += 1;
                charisma += 1;
            }
            if (newRace.assignedRace == "Tiefling")
            {
                charisma += 2;
                intelligence += 1;
            }
            if (newRace.assignedRace == "Aasimar")
            {
                charisma += 2;
            }
            if (newRace.assignedRace == "Dwarf")
            {
                constitution += 2;
                if (newSubRace.assignedSubRace == "Mountain")
                {
                    strength += 2;
                }
                if (newSubRace.assignedSubRace == "Hill")
                {
                    wisdom += 1;
                }
            }
            if (newRace.assignedRace == "Elf")
            {
                dexterity += 2;
                if (newSubRace.assignedSubRace == "Wood")
                {
                    wisdom += 1;
                }
                if (newSubRace.assignedSubRace == "High")
                {
                    intelligence += 1;
                }
            }
            if (newRace.assignedRace == "Gnome")
            {
                intelligence += 2;
                if (newSubRace.assignedSubRace == "Forest")
                {
                    dexterity += 1;
                }
                if (newSubRace.assignedSubRace == "Rock")
                {
                    constitution += 1;
                }
            }
            if (newRace.assignedRace == "Halfling")
            {
                dexterity += 2;
                if (newSubRace.assignedSubRace == "Stout")
                {
                    constitution += 1;
                }
                if (newSubRace.assignedSubRace == "Lightfoot")
                {
                    charisma += 1;
                }
            }
            if (newRace.assignedRace == "Genasi")
            {
                constitution += 2;
                if (newSubRace.assignedSubRace == "Air")
                {
                    dexterity += 1;
                }
                if (newSubRace.assignedSubRace == "Water")
                {
                    wisdom += 1;
                }
                if (newSubRace.assignedSubRace == "Fire")
                {
                    intelligence += 1;
                }
                if (newSubRace.assignedSubRace == "Earth")
                {
                    strength += 1;
                }
            }
        }
    }
}
