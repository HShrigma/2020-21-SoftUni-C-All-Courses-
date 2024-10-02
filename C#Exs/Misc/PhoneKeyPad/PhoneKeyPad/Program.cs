using System;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPresses = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOfPresses; i++)
            {
                string keyPad = Console.ReadLine();
                char[] interpreter = keyPad.ToCharArray();
                int keyPresses = interpreter.Length;
                switch (interpreter[0])
                {
                    case '2':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("a");
                                break;
                            case 2:
                                Console.Write("b");
                                break;
                            case 3:
                                Console.Write("c");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '3':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("d");
                                break;
                            case 2:
                                Console.Write("e");
                                break;
                            case 3:
                                Console.Write("f");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '4':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("g");
                                break;
                            case 2:
                                Console.Write("h");
                                break;
                            case 3:
                                Console.Write("i");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '5':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("j");
                                break;
                            case 2:
                                Console.Write("k");
                                break;
                            case 3:
                                Console.Write("l");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '6':
                      switch (keyPresses)
                        {
                            case 1:
                                Console.Write("m");
                                break;
                            case 2:
                                Console.Write("n");
                                break;
                            case 3:
                                Console.Write("o");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '7':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("p");
                                break;
                            case 2:
                                Console.Write("q");
                                break;
                            case 3:
                                Console.Write("r");
                                break;
                            case 4:
                                Console.Write("s");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '8':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("t");
                                break;
                            case 2:
                                Console.Write("u");
                                break;
                            case 3:
                                Console.Write("v");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '9':
                        switch (keyPresses)
                        {
                            case 1:
                                Console.Write("w");
                                break;
                            case 2:
                                Console.Write("x");
                                break;
                            case 3:
                                Console.Write("y");
                                break;
                            case 4:
                                Console.Write("z");
                                break;
                            default:
                                Console.WriteLine("Error!");
                                break;
                        }
                        break;
                    case '0':
                        Console.Write(" ");
                        break;

                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

        }
    }
}