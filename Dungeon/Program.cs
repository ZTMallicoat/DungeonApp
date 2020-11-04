using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon
{
    class Program
    {
        /* TODO FIX BUGS
         * Enemy Shaman stats do not run fun math
         * 
         * TODO BALANCING
         * Increase player hit chance
         */
        static void Main(string[] args)
        {
            #region Console Set Up
            Console.WriteLine("Welcome Anon!");
            Console.WriteLine("Please provide your responses with 2 steps:\n1. Press the corresponding number on the keyboard\n2. Pess enter");
            string consoleColor;
            Console.WriteLine("What Theme would you like?");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("(1)Option 1");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(2)Option 2");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("(3)Option 3");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("(4)Option 4");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("(5)Option 5");
            Console.ResetColor();
            do
            {
                consoleColor = Console.ReadLine().ToUpper();
                switch (consoleColor)
                {
                    case "1":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "3":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "4":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "5":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    default:
                        Console.WriteLine("Command not recognized, please submit just the number you would like to select.");
                        break;
                }
            } while (consoleColor != "1" && consoleColor != "2" && consoleColor != "3" && consoleColor != "4" && consoleColor != "5");
            Console.Clear();
            #endregion
            Console.WriteLine("Tears of Forgotten Worlds");
            #region Character Creator
            int PcConstitution = 100;
            int C = 1;
            int PcMagicProt = 10;
            int P = 1;
            int PcAvoidance = 10;
            int A = 1;
            int PcSlash = 10;
            int S = 1;
            int PcBlunt = 10;
            int B = 1;
            int PcMagic = 10;
            int M = 1;
            #region Race
            Console.WriteLine($"Please select your race:\n1. Human\n2. Elf\n3. Orc\n4. Half-Elf\n5. Half-Orc\n6. Orc-Elf\n7. Goblin\n8. Firbolg\n9. Tabaxi");
            string PcRace = "";
            string PcRcNbr;
            do
            {
                PcRcNbr = Console.ReadLine().ToUpper();
                switch (PcRcNbr)
                {
                    case "1":
                        PcRace = "Human";
                        C++;
                        P++;
                        A++;
                        break;
                    case "2":
                        PcRace = "Elf";
                        P++;
                        P++;
                        A++;
                        break;
                    case "3":
                        PcRace = "Orc";
                        C++;
                        C++;
                        P++;
                        break;
                    case "4":
                        PcRace = "Half-Elf";
                        C++;
                        P++;
                        P++;
                        break;
                    case "5":
                        PcRace = "Half-Orc";
                        C++;
                        C++;
                        A++;
                        break;
                    case "6":
                        PcRace = "Orc-Elf";
                        P++;
                        M++;
                        C++;
                        break;
                    case "7":
                        PcRace = "Goblin";
                        A++;
                        A++;
                        C++;
                        break;
                    case "8":
                        PcRace = "Firbolg";
                        P++;
                        P++;
                        C++;
                        break;
                    case "9":
                        PcRace = "Tabaxi";
                        A++;
                        A++;
                        A++;
                        break;
                    default:
                        Console.WriteLine("Command not recognized, please submit just the number you would like to select.");
                        break;
                }
            } while (PcRcNbr != "1" && PcRcNbr != "2" && PcRcNbr != "3" && PcRcNbr != "4" && PcRcNbr != "5" && PcRcNbr != "6" && PcRcNbr != "7" && PcRcNbr != "8" && PcRcNbr != "9");
            Console.Clear();
            Console.WriteLine($"you picked {PcRace}");
            #endregion
            #region Class
            Console.WriteLine($"Please select your class:\n1. Soldier\n2. Rogue\n3. Wizard\n4. Paladin\n5. Druid\n6. Duelist\n7. Monk\n8. Shaman\n9. Caster");
            string PcClass = "";
            string PcClNbr;
            do
            {
                PcClNbr = Console.ReadLine().ToUpper();
                switch (PcClNbr)
                {
                    case "1":
                        PcClass = "Soldier";
                        C++;
                        B++;
                        break;
                    case "2":
                        PcClass = "Rogue";
                        A++;
                        S++;
                        break;
                    case "3":
                        PcClass = "Wizard";
                        M++;
                        P++;
                        break;
                    case "4":
                        PcClass = "Paladin";
                        C++;
                        M++;
                        break;
                    case "5":
                        PcClass = "Druid";
                        P++;
                        B++;
                        break;
                    case "6":
                        PcClass = "Duelist";
                        C++;
                        S++;
                        break;
                    case "7":
                        PcClass = "Monk";
                        A++;
                        B++;
                        break;
                    case "8":
                        PcClass = "Shaman";
                        P++;
                        S++;
                        break;
                    case "9":
                        PcClass = "Caster";
                        A++;
                        M++;
                        break;
                    default:
                        Console.WriteLine("Command not recognized, please submit just the number you would like to select.");
                        break;
                }
            } while (PcClNbr != "1" && PcClNbr != "2" && PcClNbr != "3" && PcClNbr != "4" && PcClNbr != "5" && PcClNbr != "6" && PcClNbr != "7" && PcClNbr != "8" && PcClNbr != "9");
            Console.Clear();
            Console.WriteLine($"you picked {PcClass}");
            #endregion
            Console.WriteLine("What is your adventurer's name?");
            string PC = Console.ReadLine();
            Console.Clear();
            #region Fun Math PC
            int PcC = (C * C) - 1;
            int MultiplierC = PcConstitution;
            PcConstitution = PcConstitution + PcC * (MultiplierC / (C * C));
            Console.WriteLine($"{PC} has a constitution of: {PcConstitution}");
            int PcConstitutionMax = PcConstitution;
            int PcA = (A * A) - 1;
            int MultiplierA = PcAvoidance;
            PcAvoidance = PcAvoidance + PcA * (MultiplierA / (A * A));
            Console.WriteLine($"{PC} has an avoidance of: {PcAvoidance}");
            int PcMP = (P * P) - 1;
            int MultiplierP = PcMagicProt;
            PcMagicProt = PcMagicProt + PcMP * (MultiplierP / (P * P));
            Console.WriteLine($"{PC} has a magic resistance of: {PcMagicProt}");
            int PcS = (S * S) - 1;
            int MultiplierS = PcSlash;
            PcSlash = PcSlash + PcS * (MultiplierS / (S * S));
            Console.WriteLine($"{PC} has a slash attack value of: {PcSlash}");
            int PcB = (B * B) - 1;
            int MultiplierB = PcBlunt;
            PcBlunt = PcBlunt + PcB * (MultiplierB / (B * B));
            Console.WriteLine($"{PC} has a blunt attack value of: {PcBlunt}");
            int PcM = (M * M) - 1;
            int MultiplierM = PcMagic;
            PcMagic = PcMagic + PcM * (MultiplierM / (M * M));
            Console.WriteLine($"{PC} has a magic attack value of: {PcMagic}");
            #endregion
            #endregion
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::START GAME:::::::::::::::::::::::::::::::::::::::::::::::::::::::");
            Console.ReadLine();
            Console.Clear();
            bool exit = false;
            int score = 0;
            Console.WriteLine($"We join our mighty protagonist {PC}, the {PcRace} {PcClass}.");
            Console.WriteLine($"it is now time for you, our hero's guide, to step into their shoes and fulfill their destiny.\n\nAs you make your way through the woods, you find yourself upon a small, square, brick house\nIt can't be much larger than 10 feet on each side.\nDo you enter?\n1. Yes\n2. No");
            int YNSInt;
            string YNStart;
            do
            {
                string Correct1;
                string Correct2;
                Correct1 = "1";
                Correct2 = "2";

                YNStart = Console.ReadLine().ToUpper();
                if (YNStart == Correct1 || YNStart == Correct2)
                {
                    YNSInt = Convert.ToInt32(YNStart);
                }
                switch (YNStart)

                {
                    case "1":
                        break;
                    case "2":
                        Console.WriteLine("Its best not to be rude, you don't know anything about this place.\nSurely, whoever lives in it would appreciate their privacy.");
                        score++;
                        Console.WriteLine($"You earned a point for being considerate!\nScore: {score}");
                        Console.WriteLine("Unfortunately, you only now remember the 4-7 bears that were chasing you.\nYou risk being rude and enter the brick house,\nas being mauled by bears isn't everyone's idea of a good time.");
                        break;
                    default:
                        Console.WriteLine("please make a choice by typing the number you would like to select and hitting enter");
                        break;
                }
            } while (YNStart != "1" && YNStart != "2");
            #region Room
            string[] Rooms =
        {
                "The room is simple, but large.\nUnpainted Oakwood panelling lines the walls about 3 feet up, where the walls then turn to cobblestone.\nWooden crossbeams span the ceiling from wall to wall,\nwith 4 or 5 structural columns throughout the floorspace keeping the room standing.",
                "A damp, lime-ish taste hits your tongue as you wander into the unlit \"room\".\nCloser inspection reveals that you have entered a cave;\nonly about 5 feet wide, but with no end in sight on the far side from where you came in.",
                "You are greeted by a busy ballroom, where what else but a ball is in the happening.\n100 Dancers in silk, velvet, and satin dance daintily around each other.\nAs You get close enough to make out faces, you notice none of the attendees have faces.\nShocked, you gasp; this offends the faceless dancers, who promptly float towards the ceiling at an alarming rate.\nOnly now do you notice the gaping hole where the ceiling should be.\nAll the lights in the hall suddenly flicker out, as if a strong wind you cannot feel rushed by.",
                "Immediately, the stench of this room fills your lungs and causes you to feel like you're choking.  It is hard to see through the thick green plumes of smoke that fill the room.",
                "You find yourself in a grassy field atop a plateu.",
                "You stand on a shimmering night sky with no visual indication of solid ground.\nDispite this, the ground seems perfectly smooth and walkable.\nAbove you about 8 feet from the \"ground\" is a body of water spanning to the horizon on all sides.",
                "A room",
                "another room",
                "last legit room",
                "A plain, large boulder sits in the middle of a plain white room."
                };
            //Random rand = new Random();
            //int Index = rand.Next(Rooms.Length);
            //Console.WriteLine($"{Rooms[Index]}");
            do
            {
                int RoomNum = 1;
                #endregion
                #region Main Game loop
                bool reload = false;
                #region Enemy Creator
                int EnConstitution = 100;
                int EnC = 1;
                int EnMagicProt = 10;
                int EnP = 1;
                int EnAvoidance = 10;
                int EnA = 1;
                int EnSlash = 10;
                int EnS = 1;
                int EnBlunt = 10;
                int EnB = 1;
                int EnMagic = 10;
                int EnM = 1;
                #region Race
                Random Enrand = new Random();
                int EnRcNbr = Enrand.Next(1, 10);
                string EnRace = "";
                switch (EnRcNbr)
                {
                    case 1:
                        EnRace = "Human";
                        EnC++;
                        EnP++;
                        EnA++;
                        break;
                    case 2:
                        EnRace = "Elf";
                        EnP++;
                        EnP++;
                        EnA++;
                        break;
                    case 3:
                        EnRace = "Orc";
                        EnC++;
                        EnC++;
                        EnP++;
                        break;
                    case 4:
                        EnRace = "Half-Elf";
                        EnC++;
                        EnP++;
                        EnP++;
                        break;
                    case 5:
                        EnRace = "Half-Orc";
                        EnC++;
                        EnC++;
                        EnA++;
                        break;
                    case 6:
                        EnRace = "Orc-Elf";
                        EnP++;
                        EnM++;
                        EnC++;
                        break;
                    case 7:
                        EnRace = "Goblin";
                        EnA++;
                        EnA++;
                        EnC++;
                        break;
                    case 8:
                        EnRace = "Firbolg";
                        EnP++;
                        EnP++;
                        EnC++;
                        break;
                    case 9:
                        EnRace = "Tabaxi";
                        EnA++;
                        EnA++;
                        EnA++;
                        break;
                }
                #endregion
                #region Class
                Random Enrand0 = new Random();
                int EnClNbr = Enrand0.Next(1, 10);
                string EnClass = "";
                switch (EnClNbr)
                {
                    case 1:
                        EnClass = "Soldier";
                        EnC++;
                        EnB++;
                        break;
                    case 2:
                        EnClass = "Rogue";
                        EnA++;
                        EnS++;
                        break;
                    case 3:
                        EnClass = "Wizard";
                        EnM++;
                        EnP++;
                        break;
                    case 4:
                        EnClass = "Paladin";
                        EnC++;
                        EnM++;
                        break;
                    case 5:
                        EnClass = "Druid";
                        EnP++;
                        EnB++;
                        break;
                    case 6:
                        EnClass = "Duelist";
                        EnC++;
                        EnS++;
                        break;
                    case 7:
                        EnClass = "Monk";
                        EnA++;
                        EnB++;
                        break;
                    case 8:
                        EnClass = "Shaman";
                        EnP++;
                        EnS++;
                        break;
                    case 9:
                        EnClass = "Caster";
                        EnA++;
                        EnM++;
                        break;
                }
                Console.WriteLine($"The enemy is a {EnRace} {EnClass}");
                #endregion
                #region Fun Math EN
                int EnnC = (EnC * EnC) - 1;
                int EnMultiplierC = EnConstitution;
                EnConstitution = EnConstitution + EnnC * (EnMultiplierC / (EnC * EnC));
                Console.WriteLine($"Enemy has a constitution of: {EnConstitution}");
                int EnnA = (EnA * EnA) - 1;
                int EnMultiplierA = EnAvoidance;
                EnAvoidance = EnAvoidance + EnnA * (EnMultiplierA / (EnA * EnA));
                Console.WriteLine($"Enemy has an avoidance of: {EnAvoidance}");
                int EnMP = (EnP * EnP) - 1;
                int EnMultiplierP = EnMagicProt;
                EnMagicProt = EnMagicProt + EnMP * (EnMultiplierP / (EnP * EnP));
                Console.WriteLine($"Enemy has a magic resistance of: {EnMagicProt}");
                int EnnS = (EnS * EnS) - 1;
                int EnMultiplierS = EnSlash;
                EnSlash = EnSlash + EnnS * (EnMultiplierS / (EnS * EnS));
                Console.WriteLine($"Enemy has a slash attack value of: {EnSlash}");
                int EnnB = (EnB * EnB) - 1;
                int EnMultiplierB = EnBlunt;
                EnBlunt = EnBlunt + EnnB * (EnMultiplierB / (EnB * EnB));
                Console.WriteLine($"Enemy has a blunt attack value of: {EnBlunt}");
                int EnnM = (EnM * EnM) - 1;
                int EnMultiplierM = EnMagic;
                EnMagic = EnMagic + EnnM * (EnMultiplierM / (EnM * EnM));
                Console.WriteLine($"Enemy has a magic attack value of: {EnMagic}");
                #endregion
                #endregion
                string An = "";
                switch (EnRace)
                {
                    case "Orc":
                    case "elf":
                        An = "n";
                        break;
                    default:
                        break;
                }
                Random Rand1 = new Random();
                int RandInt1 = Rand1.Next(1, 3);
                int EnPickType = 0;
                switch (RandInt1)
                {
                    case 1:
                        EnPickType = EnClNbr;
                        break;
                    case 2:
                        EnPickType = EnRcNbr;
                        break;
                }
                switch (EnPickType)//TODO Make unique encounters for each room on turn random(11)
                {
                    case 1:
                        Console.WriteLine($"{Rooms[0]}");
                        break;
                    case 2:
                        Console.WriteLine($"{Rooms[1]}");
                        break;
                    case 3:
                        Console.WriteLine($"{Rooms[2]}");
                        break;
                    case 4:
                        //TODO Make room damage player upon entry and after each turn
                        Console.WriteLine($"{Rooms[3]}");
                        break;
                    case 5:
                        Console.WriteLine($"{Rooms[4]}");
                        break;
                    case 6:
                        Console.WriteLine($"{Rooms[5]}");
                        break;
                    case 7:
                        Console.WriteLine($"{Rooms[6]}");
                        break;
                    case 8:
                        Console.WriteLine($"{Rooms[7]}");
                        break;
                    case 9:
                        Console.WriteLine($"{Rooms[8]}");
                        break;
                    case 10:
                        Console.WriteLine("ROCK ENCOUNTER ROCK ENCOUNTER ROCK ENCOUNTER ROCK ENCOUNTER");
                        break;
                }
                if (RoomNum == 1) { Console.WriteLine($"Across from you stands a{An} {EnRace}.  They look just as confused as you.\nAs they open their mouth to speak to you,\na booming voice takes their attention, as well as your own.  \n\"Only one may leave.\"\nYou can:\n-Attack your opponent\n-Ready a powerful 2-turn attack that is negated if you take damage\n-Shunt an incoming magical attack, increasing the damage of the next magical attack you use.\n-Attempt to intimidate your opponent"); }
                else { Console.WriteLine($"Like the room you just left, there is now across from you another wayward soul; this time a {EnRace} {EnClass}.  You both seem to know what comes next..."); }
                bool OverCharge = false;
                bool CritStrike = false;
                do
                {
                    Console.WriteLine("What is your command?\n1. Attack\n2. Focus\n3. Shunt\n4. Intimidate");
                    string PlayerInput = Console.ReadLine().ToUpper();
                    if (PlayerInput == "1" || PlayerInput == "2" || PlayerInput == "3" || PlayerInput == "4")
                    {
                        int PlayerInputParsed = Int32.Parse(PlayerInput);
                        Console.Clear();
                        switch (PlayerInputParsed)
                        {
                            case 1:
                                #region Attack
                                Console.WriteLine("How would you like to strike your foe?\n1. Slash \n2. Blunt \n3. Magic ");
                                string PcAttack = Console.ReadLine().ToUpper();
                                do
                                {

                                    if (PcAttack == "1" || PcAttack == "2" || PcAttack == "3")
                                    {

                                        int PcAttackI = Int16.Parse(PcAttack);
                                        Random PcRanHitChance = new Random();
                                        int PcHitChance = PcRanHitChance.Next(31);
                                        if (PcAttackI == 1) { PcHitChance = (8 * PcHitChance) / 9; }
                                        if (PcHitChance <= EnAvoidance)
                                        {
                                            Console.WriteLine("But you missed!");
                                        }
                                        else
                                        {
                                            switch (PcAttackI)
                                            {
                                                case 1:
                                                    int PcSlashInitializer = PcSlash;
                                                    if (CritStrike == true)
                                                    {
                                                        PcSlash = PcSlash * 3;
                                                        CritStrike = false;
                                                    }
                                                    EnConstitution = EnConstitution - PcSlash * 2;
                                                    PcSlash = PcSlashInitializer;
                                                    break;
                                                case 2:
                                                    int PcBluntInitializer = PcBlunt;
                                                    if (CritStrike == true)
                                                    {
                                                        PcBlunt = PcBlunt * 3;
                                                        CritStrike = false;
                                                    }
                                                    EnConstitution = EnConstitution - PcBlunt * 2;
                                                    PcBlunt = PcBluntInitializer;
                                                    break;
                                                case 3:
                                                    int PcMagicInitializer = PcMagic;
                                                    if (CritStrike == true)
                                                    {
                                                        PcMagic = PcMagic * 3;
                                                        CritStrike = false;
                                                    }
                                                    if (OverCharge == true)
                                                    {
                                                        EnConstitution = EnConstitution - PcMagic * 6;
                                                        OverCharge = false;
                                                    }
                                                    else
                                                    {
                                                        EnConstitution = EnConstitution - PcMagic * 2;
                                                    }
                                                    PcMagic = PcMagicInitializer;
                                                    break;
                                            }
                                            if (EnConstitution > 0)
                                            {
                                                Console.WriteLine($"Your opponent's Health: {EnConstitution}");
                                            }
                                            else
                                            {
                                                Console.WriteLine("You land a killing blow!");
                                            }
                                        }
                                    }
                                } while (PcAttack != "1" && PcAttack != "2" && PcAttack != "3");
                                #endregion
                                break;
                            case 2:
                                Console.WriteLine("You scan your opponent, waiting for the perfect opportunity to strike!");
                                break;
                            case 3:
                                Console.WriteLine("You utter a counterspell to ward off magical damage!");
                                break;
                            case 4:
                                if (PcConstitution >= 2 * EnConstitution)
                                {
                                    Console.WriteLine($"Your foe cowers in terror, they know they are no match for you!\nUnfortunately for them, that is against the rules... A bolt of lightning streaks from directly above them.\nWhen the smoke clears, your opponent is nowhere in sight.");
                                }
                                else
                                {
                                    Console.WriteLine("Your opponent's brow flinches, but they do not faulter");
                                }
                                break;
                        }
                        Console.ReadLine();
                        Console.Clear();
                        if (EnConstitution > 0)
                        {
                            #region Enemy's turn
                            Random RanHitChance = new Random();
                            int EnHitChance = RanHitChance.Next(1, 41);
                            if (EnClNbr == 2 || EnClNbr == 6) { EnHitChance = (8 * EnHitChance) / 9; }
                            Console.WriteLine("your opponent attacks you!");
                            if (EnHitChance <= PcAvoidance)
                            {
                                Console.WriteLine("But They missed!");
                                if (PlayerInputParsed == 2)
                                {
                                    CritStrike = true;
                                }
                            }
                            else
                            {
                                switch (EnClNbr)
                                {
                                    case 2:
                                    case 6:
                                        if (PlayerInputParsed == 2)
                                        {
                                            PcConstitution = PcConstitution - ((5 / 4) * EnSlash);
                                        }
                                        else
                                        {
                                            PcConstitution = PcConstitution - ((5 / 4) * EnSlash * 3);
                                        }
                                        Console.WriteLine("your opponent swings their blade at you, leaving behind a nasty gash!");
                                        if (PcConstitution > 0)
                                        {
                                            Console.WriteLine($"Player Health: {PcConstitution}");
                                        }
                                        break;

                                    case 1:
                                    case 4:
                                    case 5:
                                    case 7:
                                        if (PlayerInputParsed == 2)
                                        {
                                            PcConstitution = PcConstitution - EnBlunt;
                                        }
                                        else
                                        {
                                            PcConstitution = PcConstitution - (EnBlunt * 2);
                                        }
                                        Console.WriteLine("your opponent bludgeons you!");
                                        if (PcConstitution > 0)
                                        {
                                            Console.WriteLine($"Player Health: {PcConstitution}");
                                        }
                                        break;
                                    case 3:
                                    case 8:
                                    case 9:
                                        Console.WriteLine("your opponent fires a magical attack at you!");
                                        if (PlayerInputParsed == 3)
                                        {
                                            Random Rand2 = new Random();
                                            int ShuntEff = Rand2.Next(1, 7);
                                            Console.WriteLine($"{PC} Shunted the attack\nBy absorbing some of the energy into yourself, your next magical attack will yield increased damage!");
                                            PcConstitution = PcConstitution - ((ShuntEff * EnMagic / 2) - PcMagicProt);
                                            OverCharge = true;
                                        }
                                        else
                                        {
                                            PcConstitution = PcConstitution - ((EnMagic * 3) - PcMagicProt);
                                        }
                                        if (PcConstitution > 0)
                                        {
                                            Console.WriteLine($"Player Health: {PcConstitution}");
                                        }
                                        break;
                                }
                                if (PlayerInputParsed == 2)
                                {
                                    Console.WriteLine("Your focus is broken!");
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            #region Victory
                            PcConstitution = PcConstitutionMax;
                            score = score++;
                            RoomNum = RoomNum++;
                            Console.WriteLine("You defeated your foe!\nChoose a prize:\n1. +Health\n2. +Avoidance\n3. +Magic Resistance");
                            string VictoryPrize = Console.ReadLine().ToUpper();
                            do
                            {
                                switch (VictoryPrize)
                                {
                                    case "1":
                                        PcConstitution = PcConstitution + 10;
                                        break;
                                    case "2":
                                        PcAvoidance = PcAvoidance++;
                                        break;
                                    case "3":
                                        PcMagicProt = PcMagicProt++;
                                        break;
                                }
                            } while (VictoryPrize != "1" && VictoryPrize != "2" && VictoryPrize != "3");
                            EnC = EnC++;
                            EnP = EnP++;
                            EnA = EnA++;
                            EnS = EnS++;
                            EnB = EnB++;
                            EnM = EnM++;
                            reload = true;
                            #endregion
                        }
                    }
                    else
                    {
                        Console.WriteLine("please make a choice by typing the number you would like to select and hitting enter");
                    }
                    if (PcConstitution <= 0)
                    {
                        Console.WriteLine($"{PC} has been killed...");
                        reload = true;
                        exit = true;
                    }
                }
                while (!reload);
                if (PcConstitution > 0) { Console.WriteLine("Your slain foe lays limp at your feet, the only way forward is the door your opponent came in through."); }
                if (RoomNum == 8)
                {
                    Console.WriteLine("As your opponent falls dead to the ground, a glowing doorway sparks into view from where your opponent came in.");
                    //TODO Final Boss Encounter
                }
            } while (!exit);
            #endregion
            Console.WriteLine("Game Over");
            Console.WriteLine($"Score: {score}");
        }
    }
}