using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IP_Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
        MAINMENU:
            try
            {
                // IP (Internet Protocol) Address Octets
                byte firstOctet = 0;
                byte secondOctet = 0;
                byte thirdOctet = 0;
                byte fourthOctet = 0;

                // IP (Internet Protocol) Strings
                string firstOctetS = "";
                string secondOctetS = "";
                string thirdOctetS = "";
                string fourthOctetS = "";

                // IP (Internet Protocol) Bytes
                string firstByte = "";
                string secondByte = "";
                string thirdByte = "";
                string fourthByte = "";

                // IP (Internet Protocol) Properties
                string iPClass = "";
                string subnetMask = "";
                string numericNetValue = "";
                string numericHostValue = "";

                // User Input
                string ipInput;
                int valueRef = 0;

                // Binary (8) Values
                byte firstBinaryValue = 1;
                byte secondBinaryValue = 2;
                byte thirdBinaryValue = 4;
                byte fourthBinaryValue = 8;
                byte fifthBinaryValue = 16;
                byte sixthBinaryValue = 32;
                byte seventhBinaryValue = 64;
                byte eighthBinaryValue = 128;

                // Hexadecimal Convertion Strings  
                string firstByteFirstFourBit = "";
                string firstByteSecondFourBit = "";
                string secondByteFirstFourBit = "";
                string secondByteSecondFourBit = "";
                string thirdByteFirstFourBit = "";
                string thirdByteSecondFourBit = "";
                string fourthByteFirstFourBit = "";
                string fourthByteSecondFourBit = "";
                int readControl = 0;

                // Menu Controls
                char againOrExit;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|----------------------------------|");
                Console.WriteLine("| IP (Internet Protocol) Converter |");
                Console.WriteLine("|----------------------------------|");
                Console.WriteLine(" ");

                Console.Write("IP (Internet Protocol) Address: ");
                ipInput = Console.ReadLine();

                for (int i = 0; i < ipInput.Length; i++)
                {
                    if (valueRef == 0)
                    {
                        if (ipInput[i].ToString() == ".")
                        {
                            valueRef++;
                        }
                        else
                        {
                            firstOctetS = firstOctetS + ipInput[i];
                            firstOctet = Convert.ToByte(firstOctetS);
                        }
                    }
                    else if (valueRef == 1)
                    {
                        if (ipInput[i].ToString() == ".")
                        {
                            valueRef++;
                        }
                        else
                        {
                            secondOctetS = secondOctetS + ipInput[i];
                            secondOctet = Convert.ToByte(secondOctetS);
                        }
                    }
                    else if (valueRef == 2)
                    {
                        if (ipInput[i].ToString() == ".")
                        {
                            valueRef++;
                        }
                        else
                        {
                            thirdOctetS = thirdOctetS + ipInput[i];
                            thirdOctet = Convert.ToByte(thirdOctetS);
                        }
                    }
                    else if (valueRef == 3)
                    {
                        if (ipInput[i].ToString() == ".")
                        {
                            valueRef++;
                        }
                        else
                        {
                            fourthOctetS = fourthOctetS + ipInput[i];
                            fourthOctet = Convert.ToByte(fourthOctetS);
                        }
                    }
                }

                Console.WriteLine(" ");

                ipInput = firstOctet + "." + secondOctet + "." + thirdOctet + "." + fourthOctet;

                if (firstOctet == 127)
                {
                    iPClass = "IP Type: Localhost";
                }
                else if (firstOctet >= 1 && firstOctet <= 126)
                {
                    iPClass = "A";
                    subnetMask = "255.0.0.0";
                    numericNetValue = "126";
                    numericHostValue = "16.777.214";
                }
                else if (firstOctet >= 128 && firstOctet <= 191)
                {
                    iPClass = "B";
                    subnetMask = "255.255.0.0";
                    numericNetValue = "16.384";
                    numericHostValue = "65.534";
                }
                else if (firstOctet >= 192 && firstOctet <= 223)
                {
                    iPClass = "C";
                    subnetMask = "255.255.255.0";
                    numericNetValue = "2.097.152";
                    numericHostValue = "254";
                }
                else if (firstOctet >= 224 && firstOctet <= 239)
                {
                    iPClass = "D";
                    subnetMask = "255.255.255.255";
                    numericNetValue = "4.294.967.296";
                    numericHostValue = "1";
                }
                else
                {
                    iPClass = "IP Type: Undefined";
                }

                Console.WriteLine("|------------------------------------------|");
                Console.WriteLine("| Encrypted IP (Internet Protocol) Address |");
                Console.WriteLine("|------------------------------------------|");

                // First Octet Encrypt
                if (firstOctet - 128 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - eighthBinaryValue);
                    firstByte += "1";
                }
                else
                {
                    firstByte += "0";
                }

                if (firstOctet - 64 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - seventhBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 32 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - sixthBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 16 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - fifthBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 8 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - fourthBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 4 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - thirdBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 2 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - secondBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }
                if (firstOctet - 1 >= 0)
                {
                    firstOctet = Convert.ToByte(firstOctet - firstBinaryValue);
                    firstByte += " 1";
                }
                else
                {
                    firstByte += " 0";
                }

                //Third Byte Encrypt
                if (secondOctet - 128 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - eighthBinaryValue);
                    secondByte += "1";
                }
                else
                {
                    secondByte += "0";
                }

                if (secondOctet - 64 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - seventhBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 32 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - sixthBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 16 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - fifthBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 8 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - fourthBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 4 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - thirdBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 2 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - secondBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }
                if (secondOctet - 1 >= 0)
                {
                    secondOctet = Convert.ToByte(secondOctet - firstBinaryValue);
                    secondByte += " 1";
                }
                else
                {
                    secondByte += " 0";
                }

                //Third Byte Encrypt
                if (thirdOctet - 128 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - eighthBinaryValue);
                    thirdByte += "1";
                }
                else
                {
                    thirdByte += "0";
                }

                if (thirdOctet - 64 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - seventhBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 32 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - sixthBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 16 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - fifthBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 8 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - fourthBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 4 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - thirdBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 2 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - secondBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }
                if (thirdOctet - 1 >= 0)
                {
                    thirdOctet = Convert.ToByte(thirdOctet - firstBinaryValue);
                    thirdByte += " 1";
                }
                else
                {
                    thirdByte += " 0";
                }

                //Fourth Byte Encrypt
                if (fourthOctet - 128 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - eighthBinaryValue);
                    fourthByte += "1";
                }
                else
                {
                    fourthByte += "0";
                }

                if (fourthOctet - 64 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - seventhBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 32 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - sixthBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 16 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - fifthBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 8 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - fourthBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 4 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - thirdBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 2 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - secondBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }
                if (fourthOctet - 1 >= 0)
                {
                    fourthOctet = Convert.ToByte(fourthOctet - firstBinaryValue);
                    fourthByte += " 1";
                }
                else
                {
                    fourthByte += " 0";
                }

                Console.WriteLine(firstByteFirstFourBit);
                Console.WriteLine($"First Byte: {firstByte}");
                Console.WriteLine($"Second Byte: {secondByte}");
                Console.WriteLine($"Third Byte: {thirdByte}");
                Console.WriteLine($"Fourth Byte: {fourthByte}");
                Console.WriteLine(" ");

                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine("| IP (Internet Protocol) Properties |");
                Console.WriteLine("|-----------------------------------|");
                Console.WriteLine(" ");

                Console.WriteLine("IP Type: " + iPClass);
                Console.WriteLine("Subnet Mask: " + subnetMask);
                Console.WriteLine("Numeric Net Value: " + numericNetValue);
                Console.WriteLine("Numeric Host Value: " + numericHostValue);
                Console.WriteLine("IP Address: " + ipInput);
                Console.WriteLine(" ");

                Console.WriteLine("New Process --> |1|");
                Console.WriteLine("Exit Program --> |0|");

                Console.WriteLine(" ");

                ANSWERAGAIN: 
                Console.Write("Answer: ");
                againOrExit = Convert.ToChar(Console.ReadLine());

                Console.WriteLine(" ");

                if (againOrExit == '1')
                {
                    Console.Clear();
                    goto MAINMENU;
                }
                else if (againOrExit == '0')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("|----------------|");
                    Console.WriteLine("| Invalid Choice |");
                    Console.WriteLine("|----------------|");
                    Console.WriteLine(" ");
                    goto ANSWERAGAIN;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("|-------------------|");
                Console.WriteLine("| Exception Handled |");
                Console.WriteLine("|-------------------|");
                Console.WriteLine(" ");
                Console.WriteLine($"Exception: {exception.ToString()}");
                Console.WriteLine(" ");
                goto MAINMENU;
            }
            Console.ReadLine();
        }
    }
}