using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            prototypeSecond(args);
        }

        public static bool prototypeFirst(string[] input)
        {
            try
            {
                FileDetails objFileDetails = new FileDetails();
                switch (input[0])
                {
                    case "-v":
                        Console.WriteLine(objFileDetails.Version(input[1]));
                        break;
                    default:
                        Console.WriteLine("Please check the argument");
                        return false;
                }                
                //Console.WriteLine("Enter key to exit");
                //Console.ReadLine();
                return true;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception )
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                return false;
            }
        }
        public static bool prototypeSecond(string[] input)
        {
            try
            {
                FileDetails objFileDetails = new FileDetails();
                switch (input[0])
                {
                    case "-v":
                        Console.WriteLine(objFileDetails.Version(input[1]));
                        break;
                    case "--v":
                        Console.WriteLine(objFileDetails.Version(input[1]));
                        break;
                    case "/v":
                        Console.WriteLine(objFileDetails.Version(input[1]));
                        break;
                    case "--version":
                        Console.WriteLine(objFileDetails.Version(input[1]));
                        break;
                    case "-s":
                        Console.WriteLine(objFileDetails.Size(input[1]));
                        break;
                    case "--s":
                        Console.WriteLine(objFileDetails.Size(input[1]));
                        break;
                    case "/s":
                        Console.WriteLine(objFileDetails.Size(input[1]));
                        break;
                    case "--size":
                        Console.WriteLine(objFileDetails.Size(input[1]));
                        break;
                    default:
                        Console.WriteLine("Please check the argument");
                        return false;

                }
                //Console.WriteLine("Enter key to exit");
                //Console.ReadLine();
                return true;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception )
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                return false;
            }
        }
    }
}
