using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding_ID_number
{
    internal class Program
    {
            static void Main()
            {
            Console.WriteLine("Enter ID number");
            string ID = Console.ReadLine();

            string BirthDate = ID.Substring(0, 6);
            string genderDigits= ID.Substring(6, 1);

            string citizenshipStatus = ID.Substring(10, 1);
            
            string gender = (int.Parse(genderDigits)<4) ? "Female" : "Male";

            string citizenship = (citizenshipStatus == "0") ? "SA Citizen" : "Permanent";

            Console.WriteLine("Birth Date: " + BirthDate);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Citizenship Status: " + citizenship);
            Console.ReadLine();

                }
            }

                }



