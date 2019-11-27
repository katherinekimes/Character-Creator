using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class PlayerClass
    {
        public string assignedClass { get; set; }
        public string classDescription { get; set; }

        public string ClassGenerator()
        {
            List<string> classOptions = new List<string>();
            classOptions.Add("Barbarian");
            classOptions.Add("Bard");
            classOptions.Add("Cleric");
            classOptions.Add("Druid");
            classOptions.Add("Monk");
            classOptions.Add("Paladin");
            classOptions.Add("Ranger");
            classOptions.Add("Rogue");
            classOptions.Add("Sorcerer");
            classOptions.Add("Warlock");
            classOptions.Add("Wizard");

            Random playerClass = new Random();
            int c = playerClass.Next(classOptions.Count);
            assignedClass = (classOptions[c].ToString());
            return assignedClass;
        }
        public string ClassDescription()
        {
            if (assignedClass == "Barbarian")
            {
                classDescription = "Barbarians are fierce warriors of primitive background who can enter into a battle rage!";
            }
            if (assignedClass == "Bard")
            {
                classDescription = "Bards are inspiring magicians whose power echoes the music of creation.";
            }
            if (assignedClass == "Cleric")
            {
                classDescription = "Clerics are priestly champions who wield divine magic in service of a higher power.";
            }
            if (assignedClass == "Druid")
            {
                classDescription = "Druids wield the power of nature to befriend animals, or even adopt animal forms.";
            }
            if (assignedClass == "Fighter")
            {
                classDescription = "Fighers are combat experts skilled with a variety of weapons and armor.";
            }
            if (assignedClass == "Monk")
            {
                classDescription = "Monks are masters of martials arts, harnessing the power of the body in pursuit of physical and spiritual perfection.";
            }
            if (assignedClass == "Paladin")
            {
                classDescription = "Paladins are holy warriors bound to sacred oaths of Justice or Vengeance.";
            }
            if (assignedClass == "Ranger")
            {
                classDescription = "Rangers are adventurers who combat threats on the edge of civilization ... or beyond.";
            }
            if (assignedClass == "Rogue")
            {
                classDescription = "Rogues are scoundrels who use stealth and guile to overcome obstacles and enemies.";
            }
            if (assignedClass == "Sorcerer")
            {
                classDescription = "Sorcerers are spellcasters who draw on the often-unpredictable inherent magic in their bloodlines.";
            }
            if (assignedClass == "Warlock")
            {
                classDescription = "Warlocks are wielders of magic gifted to them by powerful and fickle magical beings.";
            }
            if (assignedClass == "Wizard")
            {
                classDescription = "Wizards are scholarly magic-users capable of manipulating the structures of reality.";
            }
            return classDescription;
        }
        
    }
}
