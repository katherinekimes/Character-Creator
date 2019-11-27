using System;
using System.Collections.Generic;
using System.Linq;
using CharacterGenerator.Classes;

namespace CharacterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Race newRace = new Race();
            newRace.RaceGenerator();
            newRace.RaceDescription();
            SubRace newSubRace = new SubRace(newRace);
            newSubRace.SubRaceGenerator();
            newSubRace.SubRaceDescription();
            Name playerName = new Name(newRace, newSubRace);
            playerName.GenerateName();
            PlayerClass newClass = new PlayerClass();
            newClass.ClassGenerator();
            Stats newStats = new Stats(newRace, newSubRace, newClass);
            newClass.ClassDescription();
            newStats.StatGenerator();
            Health newHealth = new Health(newRace, newSubRace, newClass, newStats);
            newHealth.HealthGenerator();
            Equipment newEquipment = new Equipment(newClass);
            newEquipment.Equip();


            Console.WriteLine("Welcome to my D&D 5e Character Generator!", 130);
            Console.WriteLine("========================================================================================================================", 130);
            Console.WriteLine();
            Console.WriteLine("This application will generate a first-level character based on the official 5th Edition Dungeons & Dragons rules,\nwith a randomized Race, Class, Name, Ability Scores, Health, and Starting Equipment.", 130);
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue to the next section.");
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();

            Console.WriteLine("Let's start with Race!");
            Console.ReadLine();
            Console.WriteLine($"Your Race is: {newSubRace.assignedSubRace} {newRace.assignedRace}.");
            Console.WriteLine($"{newRace.raceDescription} {newSubRace.subRaceDescription}");
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();

            Console.WriteLine("Now, what should your name be?");
            Console.WriteLine();
            Console.WriteLine($"Your name is: {playerName.assignedName}." +
                $"");
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();

            Console.WriteLine("Next, let's find your Class.");
            Console.ReadLine();
            Console.WriteLine($"Your Class is: {newClass.assignedClass}.");
            Console.WriteLine(newClass.classDescription);
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();


            Console.WriteLine("Now, let's generate your Ability Scores!");
            Console.ReadLine();
            Console.WriteLine($"Strenth: {newStats.strength}");
            Console.WriteLine("Strength represents your physical power and affects your ability to handle heavy weapons.");
            Console.ReadLine();
            Console.WriteLine($"Dexterity: {newStats.dexterity}");
            Console.WriteLine("Dexterity represents your agility and affects how difficult you are to hit in combat.");
            Console.ReadLine();
            Console.WriteLine($"Constitution: {newStats.constitution}");
            Console.WriteLine("Constitution represents your endurance and affects your ability to resist poisons and diseases.");
            Console.ReadLine();
            Console.WriteLine($"Intelligence: {newStats.intelligence}");
            Console.WriteLine("Intelligence represents your memory and reasoning skills, and affects your ability to solve complex puzzles.");
            Console.ReadLine();
            Console.WriteLine($"Wisdom: {newStats.wisdom}");
            Console.WriteLine("Wisdom represents your perception and insight and affects your ability to detect hidden objects or motives.");
            Console.ReadLine();
            Console.WriteLine($"Charisma: {newStats.charisma}");
            Console.WriteLine("Charisma represents the force of your personality and affects your abilitiy to influence others.");
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();
        

            Console.WriteLine("Let's determine your Hit Points!");
            Console.ReadLine();
            Console.WriteLine($"Your starting Hit Points (HP) equals: {newHealth.startingHP}");
            Console.WriteLine("If your HP falls to 0 in combat, you will fall unconscious.");
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();

            Console.WriteLine("Speaking of combat, let's see what kind of starting equipment and abilities you have!");
            Console.ReadLine();
            Console.WriteLine(newEquipment.startingEquipment);
            Console.WriteLine("========================================================================================================================", 130);
            Console.ReadLine();

            Console.WriteLine("Congratulations! You now have a fully playable character!");
            Console.ReadLine();
        }
    }
}