using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterGenerator.Classes
{
    public class Name
    {
        public string assignedName { get; set; }

        Race newRace;
        SubRace newSubRace;

        public Name(Race race, SubRace subRace)
        {
            newRace = race;
            newSubRace = subRace;
        }

        public string GenerateName()
        {
            if (newRace.assignedRace == "Dragonborn")
            {
                List<string> firstNames = new List<string>();
                firstNames.Add("Arjhan");
                firstNames.Add("Balasar");
                firstNames.Add("Bharash");
                firstNames.Add("Donaar");
                firstNames.Add("Ghesh");
                firstNames.Add("Heskan");
                firstNames.Add("Kriv");
                firstNames.Add("Medraash");
                firstNames.Add("Mehen");
                firstNames.Add("Nadarr");
                firstNames.Add("Pandjed");
                firstNames.Add("Patrin");
                firstNames.Add("Rhogar");
                firstNames.Add("Shamash");
                firstNames.Add("Shedinn");
                firstNames.Add("Tarhun");
                firstNames.Add("Torinn");
                firstNames.Add("Akra");
                firstNames.Add("Biri");
                firstNames.Add("Daar");
                firstNames.Add("Farideh");
                firstNames.Add("Harann");
                firstNames.Add("Havilar");
                firstNames.Add("Jheri");
                firstNames.Add("Kava");
                firstNames.Add("Korinn");
                firstNames.Add("Mishann");
                firstNames.Add("Nala");
                firstNames.Add("Perra");
                firstNames.Add("Raiann");
                firstNames.Add("Sora");
                firstNames.Add("Surina");
                firstNames.Add("Thava");
                firstNames.Add("Uadjit");

                List<string> lastNames = new List<string>();
                lastNames.Add("Clethtinthiallor");
                lastNames.Add("Daardendrian");
                lastNames.Add("Delmirev");
                lastNames.Add("Drachedandion");
                lastNames.Add("Fenkenkabradon");
                lastNames.Add("Kepeshkmolik");
                lastNames.Add("Kerrhylon");
                lastNames.Add("Kimbatuul");
                lastNames.Add("Linxakasendalor");
                lastNames.Add("Myastan");
                lastNames.Add("Nemmonis");
                lastNames.Add("Norixius");
                lastNames.Add("Ophinshtalajiir");
                lastNames.Add("Prexijandilin");
                lastNames.Add("Shestendeliath");
                lastNames.Add("Turnuroth");
                lastNames.Add("Verthisathurgiesh");
                lastNames.Add("Yarjerit");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");

            }
            if (newRace.assignedRace == "Dwarf")
            {
                List<string> firstNames = new List<string>();
                firstNames.Add("Adrik");
                firstNames.Add("Alberich");
                firstNames.Add("Baern");
                firstNames.Add("Barendd");
                firstNames.Add("Brottor");
                firstNames.Add("Bruenor");
                firstNames.Add("Dain");
                firstNames.Add("Darrak");
                firstNames.Add("Delg");
                firstNames.Add("Eberk");
                firstNames.Add("Einkil");
                firstNames.Add("Fargrim");
                firstNames.Add("Flint");
                firstNames.Add("Gardain");
                firstNames.Add("Harbek");
                firstNames.Add("Kildrak");
                firstNames.Add("Morgran");
                firstNames.Add("Orsik");
                firstNames.Add("Oskar");
                firstNames.Add("Rangrim");
                firstNames.Add("Rurik");
                firstNames.Add("Taklinn");
                firstNames.Add("Thoradin");
                firstNames.Add("Thorin");
                firstNames.Add("Tordek");
                firstNames.Add("Traubon");
                firstNames.Add("Travok");
                firstNames.Add("Ulfgar");
                firstNames.Add("Veit");
                firstNames.Add("Vondal");
                firstNames.Add("Amber");
                firstNames.Add("Artin");
                firstNames.Add("Audhild");
                firstNames.Add("Bardryn");
                firstNames.Add("Dagnal");
                firstNames.Add("Diesa");
                firstNames.Add("Eldeth");
                firstNames.Add("Falkrunn");
                firstNames.Add("Finellen");
                firstNames.Add("Gunnloda");
                firstNames.Add("Gurdis");
                firstNames.Add("Helja");
                firstNames.Add("Hlin");
                firstNames.Add("Kathra");
                firstNames.Add("Kristryd");
                firstNames.Add("Ilde");
                firstNames.Add("Liftrasa");
                firstNames.Add("Mardred");
                firstNames.Add("Riswynn");
                firstNames.Add("Sannl");
                firstNames.Add("Torbera");
                firstNames.Add("Torgga");
                firstNames.Add("Vistra");

                List<string> lastNames = new List<string>();
                lastNames.Add("Balderk");
                lastNames.Add("Battlehammer");
                lastNames.Add("Brawnanvil");
                lastNames.Add("Dankil");
                lastNames.Add("Fireforge");
                lastNames.Add("Frostbeard");
                lastNames.Add("Gorunn");
                lastNames.Add("Holderhek");
                lastNames.Add("Ironfist");
                lastNames.Add("Loderr");
                lastNames.Add("Lutgehr");
                lastNames.Add("Rumnaheim");
                lastNames.Add("Strakeln");
                lastNames.Add("Torunn");
                lastNames.Add("Ungart");
                lastNames.Add("Ironeater");
                lastNames.Add("Brickbuilder");
                lastNames.Add("Rockseeker");
                lastNames.Add("Stoneking");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Elf")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Ara");
                firstNames.Add("Bryn");
                firstNames.Add("Del");
                firstNames.Add("Eryn");
                firstNames.Add("Faen");
                firstNames.Add("Innil");
                firstNames.Add("Lael");
                firstNames.Add("Naill");
                firstNames.Add("Naeris");
                firstNames.Add("Phann");
                firstNames.Add("Rael");
                firstNames.Add("Rinn");
                firstNames.Add("Sai");
                firstNames.Add("Syllin");
                firstNames.Add("Thai");
                firstNames.Add("Vall");
                firstNames.Add("Adran");
                firstNames.Add("Aelar");
                firstNames.Add("Aramil");
                firstNames.Add("Arranis");
                firstNames.Add("Aust");
                firstNames.Add("Beiro");
                firstNames.Add("Berrian");
                firstNames.Add("Carric");
                firstNames.Add("Enialis");
                firstNames.Add("Erdan");
                firstNames.Add("Erevan");
                firstNames.Add("Galinndan");
                firstNames.Add("Hadarai");
                firstNames.Add("Heian");
                firstNames.Add("Himo");
                firstNames.Add("Immeral");
                firstNames.Add("Ivellios");
                firstNames.Add("Laucian");
                firstNames.Add("Mindartis");
                firstNames.Add("Paelias");
                firstNames.Add("Peren");
                firstNames.Add("Quarion");
                firstNames.Add("Rolen");
                firstNames.Add("Soveliss");
                firstNames.Add("Thamior");
                firstNames.Add("Tharivol");
                firstNames.Add("Theren");
                firstNames.Add("Varis");
                firstNames.Add("Adrie");
                firstNames.Add("Althaea");
                firstNames.Add("Anastrianna");
                firstNames.Add("Andraste");
                firstNames.Add("Antinua");
                firstNames.Add("Bethrynna");
                firstNames.Add("Birel");
                firstNames.Add("Caelynn");
                firstNames.Add("Drusilia");
                firstNames.Add("Enna");
                firstNames.Add("Felosial");
                firstNames.Add("Ielenia");
                firstNames.Add("Jelenneth");
                firstNames.Add("Keyleth");
                firstNames.Add("Leshanna");
                firstNames.Add("Lia");
                firstNames.Add("Meriele");
                firstNames.Add("Mailee");
                firstNames.Add("Naivara");
                firstNames.Add("Quelenna");
                firstNames.Add("Quillathe");
                firstNames.Add("Sariel");
                firstNames.Add("Shaniarra");
                firstNames.Add("Shava");
                firstNames.Add("Silaqui");
                firstNames.Add("Theirastra");
                firstNames.Add("Thia");
                firstNames.Add("Vadania");
                firstNames.Add("Valanthe");
                firstNames.Add("Xanaphia");
                firstNames.Add("Zenathra");

                List<string> lastNames = new List<string>();
                lastNames.Add("Amakiir (Gemflower)");
                lastNames.Add("Amastacia (Starflower)");
                lastNames.Add("Galanodel(Moonwhisper)");
                lastNames.Add("Holimion (Diamonddew)");
                lastNames.Add("Ilphelkiir (Gemblossom)");
                lastNames.Add("Liadon (Silverfrond)");
                lastNames.Add("Meliamne (Oakenheel)");
                lastNames.Add("Naïlo (Nightbreeze)");
                lastNames.Add("Siannodel (Moonbrook)");
                lastNames.Add("Xiloscient (Goldpetal)");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Gnome")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Alston");
                firstNames.Add("Alvyn");
                firstNames.Add("Boddynock");
                firstNames.Add("Brocc");
                firstNames.Add("Burgell");
                firstNames.Add("Dimble");
                firstNames.Add("Eldon");
                firstNames.Add("Erky");
                firstNames.Add("Fonkin");
                firstNames.Add("Frug");
                firstNames.Add("Gerbo");
                firstNames.Add("Gimble");
                firstNames.Add("Glim");
                firstNames.Add("Jebeddo");
                firstNames.Add("Kellen");
                firstNames.Add("Namfoodle");
                firstNames.Add("Orryn");
                firstNames.Add("Roondar");
                firstNames.Add("Seebo");
                firstNames.Add("Sindri");
                firstNames.Add("Warryn");
                firstNames.Add("Wrenn");
                firstNames.Add("Zook");
                firstNames.Add("Bimpnottin");
                firstNames.Add("Breena");
                firstNames.Add("Caramip");
                firstNames.Add("Carlin");
                firstNames.Add("Donella");
                firstNames.Add("Duvamil");
                firstNames.Add("Ella");
                firstNames.Add("Ellyjobell");
                firstNames.Add("Ellywick");
                firstNames.Add("Lilli");
                firstNames.Add("Loopmottin");
                firstNames.Add("Lorilla");
                firstNames.Add("Mardnab");
                firstNames.Add("Nissa");
                firstNames.Add("Nyx");
                firstNames.Add("Oda");
                firstNames.Add("Orla");
                firstNames.Add("Roywyn");
                firstNames.Add("Shamil");
                firstNames.Add("Tana");
                firstNames.Add("Waywocket");
                firstNames.Add("Zanna");
                firstNames.Add("Aleslosh");
                firstNames.Add("Ashhearth");
                firstNames.Add("Badger");
                firstNames.Add("Cloak");
                firstNames.Add("Doublelock");
                firstNames.Add("Filchbatter");
                firstNames.Add("Fnipper");
                firstNames.Add("Ku");
                firstNames.Add("Nim");
                firstNames.Add("Oneshoe");
                firstNames.Add("Pock");
                firstNames.Add("Sparklegem");
                firstNames.Add("Stumbleduck");

                List<string> lastNames = new List<string>();
                lastNames.Add("Beren");
                lastNames.Add("Daergel");
                lastNames.Add("Folkor");
                lastNames.Add("Garrick");
                lastNames.Add("Nackle");
                lastNames.Add("Murnig");
                lastNames.Add("Ningel");
                lastNames.Add("Raulnor");
                lastNames.Add("Scheppen");
                lastNames.Add("Timbers");
                lastNames.Add("Turen");
                lastNames.Add("Gleamsilver");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Half-Elf")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Athrun");
                firstNames.Add("Artemis");
                firstNames.Add("Ambrose");
                firstNames.Add("Avi");
                firstNames.Add("Abelas");
                firstNames.Add("Bastian");
                firstNames.Add("Belemy");
                firstNames.Add("Cyril");
                firstNames.Add("Cole");
                firstNames.Add("Davin");
                firstNames.Add("Emmett");
                firstNames.Add("Eben");
                firstNames.Add("Fox");
                firstNames.Add("Finn");
                firstNames.Add("Faeldrin");
                firstNames.Add("Fenris");
                firstNames.Add("Griffin");
                firstNames.Add("Gabriel");
                firstNames.Add("Hawke");
                firstNames.Add("Idris");
                firstNames.Add("Jett");
                firstNames.Add("Kaiden");
                firstNames.Add("Levi");
                firstNames.Add("Lazarus");
                firstNames.Add("Micah");
                firstNames.Add("Micah");
                firstNames.Add("Merrin");
                firstNames.Add("Naill");
                firstNames.Add("Orrin");
                firstNames.Add("Perrin");
                firstNames.Add("Pell");
                firstNames.Add("Quill");
                firstNames.Add("Rowan");
                firstNames.Add("Renn");
                firstNames.Add("Riorden");
                firstNames.Add("Saerin");
                firstNames.Add("Tobias");
                firstNames.Add("Tanner");
                firstNames.Add("Varric");
                firstNames.Add("Vale");
                firstNames.Add("Wade");
                firstNames.Add("Weylon");
                firstNames.Add("Xenon");
                firstNames.Add("Zevran");
                firstNames.Add("Aeryn");
                firstNames.Add("Aurora");
                firstNames.Add("Aedwyn");
                firstNames.Add("Arabel");
                firstNames.Add("Blake");
                firstNames.Add("Belle");
                firstNames.Add("Cass");
                firstNames.Add("Denali");
                firstNames.Add("Eowyn");
                firstNames.Add("Evvie");
                firstNames.Add("Faylinn");
                firstNames.Add("Farideh");
                firstNames.Add("Gwendelyn");
                firstNames.Add("Harper");
                firstNames.Add("Herra");
                firstNames.Add("Jordan");
                firstNames.Add("Jasmine");
                firstNames.Add("Kira");
                firstNames.Add("Luna");
                firstNames.Add("Lily");
                firstNames.Add("Merrill");
                firstNames.Add("Meera");
                firstNames.Add("Marley");
                firstNames.Add("Nissa");
                firstNames.Add("Nyx");
                firstNames.Add("Oswyn");
                firstNames.Add("Piper");
                firstNames.Add("Pella");
                firstNames.Add("River");
                firstNames.Add("Raynne");
                firstNames.Add("Rhys");
                firstNames.Add("Shea");
                firstNames.Add("Sabine");
                firstNames.Add("Seranni");
                firstNames.Add("Story");
                firstNames.Add("Teslyn");
                firstNames.Add("Tallis");
                firstNames.Add("Vashti");
                firstNames.Add("Valora");
                firstNames.Add("Willow");
                firstNames.Add("Worthy");

                List<string> lastNames = new List<string>();
                lastNames.Add("Alpencrest");
                lastNames.Add("Arrowood");
                lastNames.Add("Albright");
                lastNames.Add("Atwater");
                lastNames.Add("Adderly");
                lastNames.Add("Berry");
                lastNames.Add("Bowden");
                lastNames.Add("Bixby");
                lastNames.Add("Cleary");
                lastNames.Add("Crabtree");
                lastNames.Add("Day");
                lastNames.Add("Dryden");
                lastNames.Add("Eldridge");
                lastNames.Add("Elway");
                lastNames.Add("Eastwood");
                lastNames.Add("Fleetwood");
                lastNames.Add("Fairchild");
                lastNames.Add("Floris");
                lastNames.Add("Fullbright");
                lastNames.Add("Flynn");
                lastNames.Add("Gleason");
                lastNames.Add("Griffith");
                lastNames.Add("Hood");
                lastNames.Add("Halliwell");
                lastNames.Add("Hexley");
                lastNames.Add("Isilme");
                lastNames.Add("Ives");
                lastNames.Add("Ibara");
                lastNames.Add("Jovias");
                lastNames.Add("Jericho");
                lastNames.Add("Keats");
                lastNames.Add("Kincaid");
                lastNames.Add("Kicklighter");
                lastNames.Add("Lovecraft");
                lastNames.Add("Lacer");
                lastNames.Add("Moonswift");
                lastNames.Add("Murdock");
                lastNames.Add("Mercer");
                lastNames.Add("Nystrom");
                lastNames.Add("Niles");
                lastNames.Add("Oaks");
                lastNames.Add("Onassi");
                lastNames.Add("Paxton");
                lastNames.Add("Pearly");
                lastNames.Add("Quinlin");
                lastNames.Add("Ravenclaw");
                lastNames.Add("Rainwater");
                lastNames.Add("Rosen");
                lastNames.Add("Swift");
                lastNames.Add("Silver");
                lastNames.Add("Savage");
                lastNames.Add("Seaglass");
                lastNames.Add("Thorne");
                lastNames.Add("Tippett");
                lastNames.Add("Tanner");
                lastNames.Add("Ulett");
                lastNames.Add("Vandal");
                lastNames.Add("Wolfheart");
                lastNames.Add("Winthrop");
                lastNames.Add("Wilde");
                lastNames.Add("Xanders");
                lastNames.Add("Yearly");
                lastNames.Add("Youngblood");
                lastNames.Add("Zabik");
                lastNames.Add("Zephyr");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Halfling")
                {

                List<string> firstNames = new List<string>();
                firstNames.Add("Alton");
                firstNames.Add("Ander");
                firstNames.Add("Cade");
                firstNames.Add("Corrin");
                firstNames.Add("Eldon");
                firstNames.Add("Errich");
                firstNames.Add("Finnan");
                firstNames.Add("Garret");
                firstNames.Add("Lindal");
                firstNames.Add("Lyle");
                firstNames.Add("Merric");
                firstNames.Add("Milo");
                firstNames.Add("Osborn");
                firstNames.Add("Perrin");
                firstNames.Add("Reed");
                firstNames.Add("Roscoe");
                firstNames.Add("Wellby");
                firstNames.Add("Andry");
                firstNames.Add("Bree");
                firstNames.Add("Callie");
                firstNames.Add("Cora");
                firstNames.Add("Euphemia");
                firstNames.Add("Jillian");
                firstNames.Add("Kithri");
                firstNames.Add("Lavinia");
                firstNames.Add("Lidda");
                firstNames.Add("Merla");
                firstNames.Add("Nedda");
                firstNames.Add("Paela");
                firstNames.Add("Portia");
                firstNames.Add("Seraphina");
                firstNames.Add("Shaena");
                firstNames.Add("Trym");
                firstNames.Add("Vani");
                firstNames.Add("Verna");

                List<string> lastNames = new List<string>();
                lastNames.Add("Brushgather");
                lastNames.Add("Goodbarrel");
                lastNames.Add("Greenbottle");
                lastNames.Add("Highhill");
                lastNames.Add("Hilltopple");
                lastNames.Add("Leagallow");
                lastNames.Add("Tealeaf");
                lastNames.Add("Thorngage");
                lastNames.Add("Tosscobble");
                lastNames.Add("Underbough");
                lastNames.Add("Hobbs");
                lastNames.Add("Underhill");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Half-Orc")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Dench");
                firstNames.Add("Feng");
                firstNames.Add("Gell");
                firstNames.Add("Henk");
                firstNames.Add("Holg");
                firstNames.Add("Imsh");
                firstNames.Add("Keth");
                firstNames.Add("Krusk");
                firstNames.Add("Mhurren");
                firstNames.Add("Ront");
                firstNames.Add("Shump");
                firstNames.Add("Thokk");
                firstNames.Add("Baggi");
                firstNames.Add("Emen");
                firstNames.Add("Engong");
                firstNames.Add("Kansif");
                firstNames.Add("Myev");
                firstNames.Add("Neega");
                firstNames.Add("Ovak");
                firstNames.Add("Ownka");
                firstNames.Add("Shautha");
                firstNames.Add("Sutha");
                firstNames.Add("Vola");
                firstNames.Add("Volen");
                firstNames.Add("Yevelda");

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName}");
         }
                if (newRace.assignedRace == "Human")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Armen");
                firstNames.Add("Allister");
                firstNames.Add("Aiden");
                firstNames.Add("Arkyn");
                firstNames.Add("Arthuer");
                firstNames.Add("Barristen");
                firstNames.Add("Cedric");
                firstNames.Add("Cassian");
                firstNames.Add("Dorian");
                firstNames.Add("Darius");
                firstNames.Add("Eren");
                firstNames.Add("Eamon");
                firstNames.Add("Emeric");
                firstNames.Add("Fletcher");
                firstNames.Add("Florian");
                firstNames.Add("Garreth");
                firstNames.Add("Hue");
                firstNames.Add("Hurrin");
                firstNames.Add("Ishmael");
                firstNames.Add("Jareth");
                firstNames.Add("Julien");
                firstNames.Add("Kristoff");
                firstNames.Add("Logain");
                firstNames.Add("Liam");
                firstNames.Add("Milo");
                firstNames.Add("Maddox");
                firstNames.Add("Nemen");
                firstNames.Add("Nathaniel");
                firstNames.Add("Orsino");
                firstNames.Add("Otto");
                firstNames.Add("Pryce");
                firstNames.Add("Pippin");
                firstNames.Add("Quentin");
                firstNames.Add("Ronan");
                firstNames.Add("Rodrick");
                firstNames.Add("Severin");
                firstNames.Add("Shale");
                firstNames.Add("Trent");
                firstNames.Add("Theodrin");
                firstNames.Add("Uthgard");
                firstNames.Add("Vaylen");
                firstNames.Add("Wesley");
                firstNames.Add("Wilhelm");
                firstNames.Add("Xavier");
                firstNames.Add("Yavin");
                firstNames.Add("Astrid");
                firstNames.Add("Amalia");
                firstNames.Add("Ashlynn");
                firstNames.Add("Alexi");
                firstNames.Add("Belladonna");
                firstNames.Add("Breanne");
                firstNames.Add("Cora");
                firstNames.Add("Celene");
                firstNames.Add("Dagna");
                firstNames.Add("Devon");
                firstNames.Add("Elona");
                firstNames.Add("Evelyn");
                firstNames.Add("Elyssandra");
                firstNames.Add("Fleur");
                firstNames.Add("Genevieve");
                firstNames.Add("Helmi");
                firstNames.Add("Hale");
                firstNames.Add("Ilona");
                firstNames.Add("Isabelle");
                firstNames.Add("Isolde");
                firstNames.Add("Jacquelin");
                firstNames.Add("Jesse");
                firstNames.Add("Kathryn");
                firstNames.Add("Leia");
                firstNames.Add("Leliana");
                firstNames.Add("Lyra");
                firstNames.Add("Myrcella");
                firstNames.Add("Moiraine");
                firstNames.Add("Morrigan");
                firstNames.Add("Moira");
                firstNames.Add("Melora");
                firstNames.Add("Naomi");
                firstNames.Add("Natasha");
                firstNames.Add("Natalie");
                firstNames.Add("Osha");
                firstNames.Add("Pyrra");
                firstNames.Add("Petra");
                firstNames.Add("Rosalia");
                firstNames.Add("Rianna");
                firstNames.Add("Rose");
                firstNames.Add("Renne");
                firstNames.Add("Rosamund");
                firstNames.Add("Sarah");
                firstNames.Add("Setelle");
                firstNames.Add("Sloanne");
                firstNames.Add("Serana");
                firstNames.Add("Tamsin");
                firstNames.Add("Terra");
                firstNames.Add("Theo");
                firstNames.Add("Unna");
                firstNames.Add("Valeria");
                firstNames.Add("Vivienne");
                firstNames.Add("Victoria");
                firstNames.Add("Winter");
                firstNames.Add("Zora");

                List<string> lastNames = new List<string>();
                lastNames.Add("Abbott");
                lastNames.Add("Abernathy");
                lastNames.Add("Aldrich");
                lastNames.Add("Booker");
                lastNames.Add("Borden");
                lastNames.Add("Braddock");
                lastNames.Add("Bennett");
                lastNames.Add("Darcy");
                lastNames.Add("Castille");
                lastNames.Add("Carver");
                lastNames.Add("Copeland");
                lastNames.Add("Callahan");
                lastNames.Add("Davenport");
                lastNames.Add("Dempsey");
                lastNames.Add("Donahue");
                lastNames.Add("Elswell");
                lastNames.Add("Evert");
                lastNames.Add("Ekkart");
                lastNames.Add("Fairbanks");
                lastNames.Add("Fenton");
                lastNames.Add("Foster");
                lastNames.Add("Finch");
                lastNames.Add("Grady");
                lastNames.Add("Goodwin");
                lastNames.Add("Gallagher");
                lastNames.Add("Hildegard");
                lastNames.Add("Hightower");
                lastNames.Add("Hamilton");
                lastNames.Add("Idelson");
                lastNames.Add("Irons");
                lastNames.Add("Ingram");
                lastNames.Add("Jagger");
                lastNames.Add("Kerrigan");
                lastNames.Add("Keene");
                lastNames.Add("Ledger");
                lastNames.Add("Landis");
                lastNames.Add("Locke");
                lastNames.Add("Matthias");
                lastNames.Add("Martell");
                lastNames.Add("Mullinox");
                lastNames.Add("Merchant");
                lastNames.Add("Nolan");
                lastNames.Add("Novak");
                lastNames.Add("Nailor");
                lastNames.Add("Olsen");
                lastNames.Add("Nailor");
                lastNames.Add("Olsen");
                lastNames.Add("O'Leary");
                lastNames.Add("Prescott");
                lastNames.Add("Porter");
                lastNames.Add("Quaid");
                lastNames.Add("Quarters");
                lastNames.Add("Rhodes");
                lastNames.Add("Ripley");
                lastNames.Add("Redgrave");
                lastNames.Add("Rowland");
                lastNames.Add("Shields");
                lastNames.Add("Sinclair");
                lastNames.Add("Stroud");
                lastNames.Add("Steele");
                lastNames.Add("Templeton");
                lastNames.Add("Teague");
                lastNames.Add("Tairn");
                lastNames.Add("Umberhall");
                lastNames.Add("Vegas");
                lastNames.Add("Vacarro");
                lastNames.Add("Whalen");
                lastNames.Add("Wolfenstein");
                lastNames.Add("Winslow");
                lastNames.Add("Warrick");
                lastNames.Add("Xavier");
                lastNames.Add("Yaeger");
                lastNames.Add("Yanetta");
                lastNames.Add("Vivaldi");
                lastNames.Add("Zahn");
                lastNames.Add("Zeller");
                lastNames.Add("Zurich");

                Random lastName = new Random();
                int selectedLastName = lastName.Next(lastNames.Count);
                string assignedLastName = (lastNames[selectedLastName].ToString());

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName} {assignedLastName}");
            }
                if (newRace.assignedRace == "Tiefling")
                {
                List<string> firstNames = new List<string>();
                firstNames.Add("Akmenos");
                firstNames.Add("Amnon");
                firstNames.Add("Barakas");
                firstNames.Add("Damakos");
                firstNames.Add("Ekemon");
                firstNames.Add("Iados");
                firstNames.Add("Kairon");
                firstNames.Add("Leucis");
                firstNames.Add("Melech");
                firstNames.Add("Mordai");
                firstNames.Add("Morthos");
                firstNames.Add("Pelaios");
                firstNames.Add("Skamos");
                firstNames.Add("Therai");
                firstNames.Add("Akta");
                firstNames.Add("Anakis");
                firstNames.Add("Bryseis");
                firstNames.Add("Criella");
                firstNames.Add("Damaia");
                firstNames.Add("Kallista");
                firstNames.Add("Lerissa");
                firstNames.Add("Makaria");
                firstNames.Add("Nemeia");
                firstNames.Add("Orianna");
                firstNames.Add("Phelaia");
                firstNames.Add("Rieta");

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName}");
            }
                if (newRace.assignedRace == "Genasi")
                {
                    if (newSubRace.assignedSubRace == "Air")
                        {

                    List<string> firstNames = new List<string>();
                    firstNames.Add("Westin");
                    firstNames.Add("Stratos");
                    firstNames.Add("Avalon");
                    firstNames.Add("Imperos");
                    firstNames.Add("Galvan");
                    firstNames.Add("Sono");
                    firstNames.Add("Tropos");
                    firstNames.Add("Helios");
                    firstNames.Add("Aeris");
                    firstNames.Add("Shaye");
                    firstNames.Add("Shade");
                    firstNames.Add("Cloud");
                    firstNames.Add("Atmos");
                    firstNames.Add("Cerulle");
                    firstNames.Add("Zephyr");
                    firstNames.Add("Celeste");
                    firstNames.Add("Sura");
                    firstNames.Add("Stella");
                    firstNames.Add("Ohme");
                    firstNames.Add("Mistral");
                    firstNames.Add("Gale");
                    firstNames.Add("Skye");
                    firstNames.Add("Storm");
                    firstNames.Add("Sola");
                    firstNames.Add("Hala");
                    firstNames.Add("Fara");
                    firstNames.Add("Aurora");

                    Random firstName = new Random();
                    int selectedFirstName = firstName.Next(firstNames.Count);
                    string assignedFirstName = (firstNames[selectedFirstName].ToString());

                    assignedName = ($"{assignedFirstName}");

                }
                    if (newSubRace.assignedSubRace == "Water")
                        {

                    List<string> firstNames = new List<string>();
                    firstNames.Add("Rainn");
                    firstNames.Add("Cyclos");
                    firstNames.Add("Vivus");
                    firstNames.Add("Eros");
                    firstNames.Add("Typhos");
                    firstNames.Add("Azure");
                    firstNames.Add("Glacius");
                    firstNames.Add("Vapora");
                    firstNames.Add("Anae");
                    firstNames.Add("Crystal");
                    firstNames.Add("Hydra");
                    firstNames.Add("Rane");
                    firstNames.Add("Poole");
                    firstNames.Add("Flo");
                    firstNames.Add("River");
                    firstNames.Add("Ocea");
                    firstNames.Add("Aquira");
                    firstNames.Add("Tsuna");
                    firstNames.Add("Dew");
                    firstNames.Add("Brine");
                    firstNames.Add("Firn");
                    firstNames.Add("Clarity");
                    firstNames.Add("Rivule");
                    firstNames.Add("Salis");

                    Random firstName = new Random();
                    int selectedFirstName = firstName.Next(firstNames.Count);
                    string assignedFirstName = (firstNames[selectedFirstName].ToString());

                    assignedName = ($"{assignedFirstName}");

                }
                    if (newSubRace.assignedSubRace == "Earth")
                        {
                    List<string> firstNames = new List<string>();
                    firstNames.Add("Sal");
                    firstNames.Add("Umber");
                    firstNames.Add("Onyx");
                    firstNames.Add("Slate");
                    firstNames.Add("Dustin");
                    firstNames.Add("Crayg");
                    firstNames.Add("Magnos");
                    firstNames.Add("Oris");
                    firstNames.Add("Terberis");
                    firstNames.Add("Sod");
                    firstNames.Add("Granit");
                    firstNames.Add("Valance");
                    firstNames.Add("Rocc");
                    firstNames.Add("Opal");
                    firstNames.Add("Gaia");
                    firstNames.Add("Quary");
                    firstNames.Add("Slait");
                    firstNames.Add("Ignit");
                    firstNames.Add("Avala");
                    firstNames.Add("Oria");
                    firstNames.Add("Tera");
                    firstNames.Add("Terrance");
                    firstNames.Add("Basalt");

                    Random firstName = new Random();
                    int selectedFirstName = firstName.Next(firstNames.Count);
                    string assignedFirstName = (firstNames[selectedFirstName].ToString());

                    assignedName = ($"{assignedFirstName}");
                }
                    if (newSubRace.assignedSubRace == "Fire")
                        {
                    List<string> firstNames = new List<string>();
                    firstNames.Add("Pyrra");
                    firstNames.Add("Sear");
                    firstNames.Add("Fusilis");
                    firstNames.Add("Volcan");
                    firstNames.Add("Lavar");
                    firstNames.Add("Lavel");
                    firstNames.Add("Fumus");
                    firstNames.Add("Cole");
                    firstNames.Add("Tempris");
                    firstNames.Add("Ashe");
                    firstNames.Add("Spark");
                    firstNames.Add("Magmus");
                    firstNames.Add("Fuegis");
                    firstNames.Add("Nova");
                    firstNames.Add("Flarice");
                    firstNames.Add("Glo");
                    firstNames.Add("Flair");
                    firstNames.Add("Blaize");
                    firstNames.Add("Kindra");
                    firstNames.Add("Cala");
                    firstNames.Add("Ember");
                    firstNames.Add("Fye");
                    firstNames.Add("Fernis");
                    firstNames.Add("Blaise");
                    firstNames.Add("Igneous");
                    firstNames.Add("Ifrit");

                    Random firstName = new Random();
                    int selectedFirstName = firstName.Next(firstNames.Count);
                    string assignedFirstName = (firstNames[selectedFirstName].ToString());

                    assignedName = ($"{assignedFirstName}");
                }
                }
                if (newRace.assignedRace == "Aasimar")
                {

                List<string> firstNames = new List<string>();
                firstNames.Add("Aritian");
                firstNames.Add("Beltin");
                firstNames.Add("Cernan");
                firstNames.Add("Cronwier");
                firstNames.Add("Eran");
                firstNames.Add("Ilamin");
                firstNames.Add("Maudril");
                firstNames.Add("Okrin");
                firstNames.Add("Parant");
                firstNames.Add("Tural");
                firstNames.Add("Wyran");
                firstNames.Add("Zaigan");
                firstNames.Add("Arken");
                firstNames.Add("Arsinoe");
                firstNames.Add("Davina");
                firstNames.Add("Drinma");
                firstNames.Add("Imesah");
                firstNames.Add("Masozi");
                firstNames.Add("Nijena");
                firstNames.Add("Niramour");
                firstNames.Add("Ondrea");
                firstNames.Add("Rhialla");
                firstNames.Add("Valtyra");

                Random firstName = new Random();
                int selectedFirstName = firstName.Next(firstNames.Count);
                string assignedFirstName = (firstNames[selectedFirstName].ToString());

                assignedName = ($"{assignedFirstName}");
            }
                return assignedName;
            }
        }
    }
