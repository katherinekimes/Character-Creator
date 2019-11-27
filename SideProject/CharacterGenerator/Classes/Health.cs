using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class Health
    {
        public int conBonus { get; set; }
        public int startingHP { get; set; }

        Race newRace;
        SubRace newSubRace;
        PlayerClass newClass;
        Stats newStats;

        public Health(Race race, SubRace subRace, PlayerClass playerClass, Stats stats)
        {
            newRace = race;
            newSubRace = subRace;
            newClass = playerClass;
            newStats = stats;
        }


        public int HealthGenerator()
        {
            if (newStats.constitution >= 20)
            {
                conBonus = 5;
            }
            if (newStats.constitution == 18 || newStats.constitution == 19)
            {
                conBonus = 4;
            }
            if (newStats.constitution == 16 || newStats.constitution == 17)
            {
                conBonus = 3;
            }
            if (newStats.constitution == 14 || newStats.constitution == 15)
            {
                conBonus = 2;
            }
            if (newStats.constitution == 12 || newStats.constitution == 13)
            {
                conBonus = 1;
            }
            if (newStats.constitution == 10 || newStats.constitution == 11)
            {
                conBonus = 0;
            }
            if (newStats.constitution == 8 || newStats.constitution == 9)
            {
                conBonus = -1;
            }
            if (newStats.constitution == 6 || newStats.constitution == 7)
            {
                conBonus = -2;
            }
            if (newStats.constitution == 4 || newStats.constitution == 5)
            {
                conBonus = -3;
            }
            if (newStats.constitution == 3)
            {
                conBonus = -2;
            }

            if (newClass.assignedClass == "Sorcerer" || newClass.assignedClass == "Wizard")
            {
                startingHP = 6 + conBonus;
            }
            if (newClass.assignedClass == "Bard" || newClass.assignedClass == "Cleric" || newClass.assignedClass == "Fighter" || newClass.assignedClass == "Monk" || newClass.assignedClass == "Rogue" || newClass.assignedClass == "Warlock")
            {
                startingHP = 8 + conBonus;
            }
            if (newClass.assignedClass == "Druid" || newClass.assignedClass == "Paladin" || newClass.assignedClass == "Ranger")
            {
                startingHP = 10 + conBonus;
            }
            if (newClass.assignedClass == "Barbarian")
            {
                startingHP = 12 + conBonus;
            }
            return startingHP;
        }
    }
}
