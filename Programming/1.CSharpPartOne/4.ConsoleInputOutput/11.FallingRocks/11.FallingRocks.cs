using System;
using System.Threading;


    class FallingRocks
    {
        static readonly byte screenWidth = (byte)Console.WindowWidth;
        static readonly byte screenHeight = (byte)Console.WindowHeight;
        static string dwarf;
        static byte dwarfPosition;
        static byte dwarfLength;
        static readonly byte rockColours = 15;
        static readonly byte rockSymbols = 12;
        static uint score = 0;
        static byte lives = 3;

        static readonly Random randColours = new Random();
        static readonly Random randSymbols = new Random();
        static readonly Random randXOffset = new Random();
        static readonly Random randYOffset = new Random();

        private struct Rock
        {
            public byte Colour;
            public byte Charachter;
            public byte XPosition;
            public short YPosition;
        }

        

        static void RemoveScrollBars()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static string DifficultyLevel()
        {
            
            string dwarfAppearance = "(0)";
           
            return dwarfAppearance;
        }

        static void InitializeRocks(Rock[] debris)
        {
            
            short aggregator = -1;
            for (int i = 0; i < debris.Length; i++)
            {
                debris[i].Colour = (byte)randColours.Next(0, rockColours);
                debris[i].Charachter = (byte)randSymbols.Next(0, rockSymbols);
                debris[i].XPosition = (byte)randXOffset.Next(0, screenWidth);
                debris[i].YPosition = aggregator;
                short x = ((short)randYOffset.Next(0, 4));
                aggregator -= x;
            }
        }

        static void DrawRocks(Rock[] debris)
        {
            for (int i = 0; i < debris.Length; i++)
            {
                if (debris[i].YPosition > 0)
                {
                    char rockSymbol = '*';
                    Console.SetCursorPosition(debris[i].XPosition, debris[i].YPosition);

                    switch (debris[i].Colour)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 13:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 14:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        default:
                            Environment.Exit(1);
                            break;
                    }

                    switch (debris[i].Charachter)
                    {
                        case 0:
                            rockSymbol = '^';
                            break;
                        case 1:
                            rockSymbol = '@';
                            break;
                        case 2:
                            rockSymbol = '*';
                            break;
                        case 3:
                            rockSymbol = '&';
                            break;
                        case 4:
                            rockSymbol = '+';
                            break;
                        case 5:
                            rockSymbol = '%';
                            break;
                        case 6:
                            rockSymbol = '$';
                            break;
                        case 7:
                            rockSymbol = '#';
                            break;
                        case 8:
                            rockSymbol = '!';
                            break;
                        case 9:
                            rockSymbol = '.';
                            break;
                        case 10:
                            rockSymbol = ';';
                            break;
                        case 11:
                            rockSymbol = '-';
                            break;
                        default:
                            Environment.Exit(2);
                            break;
                    }

                    Console.Write(rockSymbol);
                }
            }
        }

        static bool RefreshRocks(Rock[] debris)
        {
            bool collision = false;
            for (int i = 0; i < debris.Length; i++)
            {
                if (debris[i].YPosition < (screenHeight - 1))
                {
                    debris[i].YPosition++;
                }
                else
                {
                    if ((debris[i].XPosition >= dwarfPosition) && (debris[i].XPosition <= (dwarfPosition + dwarfLength)))
                    {
                        lives--;
                        System.Media.SystemSounds.Beep.Play();
                        collision = true;
                    }
                    else
                    {
                        score++;
                    }
                    debris[i].Colour = (byte)randColours.Next(0, rockColours);
                    debris[i].Charachter = (byte)randSymbols.Next(0, rockSymbols);
                    debris[i].XPosition = (byte)randXOffset.Next(0, screenWidth);
                    debris[i].YPosition = (short)(debris[LastRockYPosition(debris)].YPosition - (short)randYOffset.Next(0, 4));
                }
            }
            return collision;
        }

        static byte LastRockYPosition(Rock[] debris)
        {
            byte position = 0;
            short lastYPosition = debris[0].YPosition;

            for (byte i = 0; i < debris.Length; i++)
            {
                if (debris[i].YPosition < lastYPosition)
                {
                    lastYPosition = debris[i].YPosition;
                    position = i;
                }
            }
            return position;
        }

        static void DrawDwarf(byte x, string str)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(x, screenHeight - 1);
            Console.Write(str);
        }

        static void MoveDwarfLeft()
        {
            if (dwarfPosition > 0)
            {
                dwarfPosition--;
            }
        }

        static void MoveDwarfRight()
        {
            if ((dwarfPosition + dwarfLength) < (screenWidth - 1))
            {
                dwarfPosition++;
            }
        }

        static void SetDwarfAtCenter()
        {
            int temp = (screenWidth - dwarf.Length) / 2;
            dwarfPosition = (byte)temp;
        }

        static void PrintResult(uint result, byte livesLeft) 
        {
            byte x;
            string strResult = Convert.ToString(result);
            x = (byte)((screenWidth - strResult.Length) / 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.Write("Lives: " + livesLeft);
            Console.SetCursorPosition(x, 0);
            Console.Write(strResult);
        }

        static void ExitScreen(uint result)
        {
            int xScore, xText;
            string strText = "Your score:";
            string strResult = Convert.ToString(result);
            xScore = (screenWidth - strResult.Length) / 2;
            xText = (screenWidth - strText.Length) / 2;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(xText, (screenHeight / 2) - 1);
            Console.Write(strText);
            Console.SetCursorPosition(xScore, screenHeight / 2);
            Console.Write(strResult);
            Console.ReadKey();
            Console.SetCursorPosition(0, screenHeight - 1);
        }

        
        

        static void Main(string[] args)
        {
            bool gameRunning = true;
            bool dwarfHit = false;
            Rock[] rocks = new Rock[screenHeight];

            RemoveScrollBars();
            dwarf = DifficultyLevel();
            dwarfLength = (byte)dwarf.Length;

            SetDwarfAtCenter();
            InitializeRocks(rocks);

            while (gameRunning)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            MoveDwarfLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            MoveDwarfRight();
                            break;
                        case ConsoleKey.Escape:
                            gameRunning = false;
                            break;
                        
                        default:
                            break;
                    }

                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }
                dwarfHit = RefreshRocks(rocks);

                if (lives == 0)
                {
                    gameRunning = false;
                }
                if (dwarfHit == true)
                {
                    SetDwarfAtCenter();
                    InitializeRocks(rocks);
                }
                Console.Clear();
                DrawDwarf(dwarfPosition, dwarf);
                DrawRocks(rocks);
                PrintResult(score, lives);
                Thread.Sleep(150);
            }
            ExitScreen(score);
        }
    }
