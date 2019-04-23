using System;
using System.Collections.Generic;
using System.Text;

namespace FortuneTellerPractice
{

    class Teller
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        int BirthMonth { get; set; }
        string FavoriteColor { get; set; }
        int NumberOfSiblings { get; set; }


        public Teller()
        {

        }

        public int RetirementAge()
        {

            int retirementYears;
            if ((this.Age % 2) == 0)
            {
                retirementYears = 11;
            }
            else
            {
                retirementYears = 15;
            }

            return retirementYears;
        }

        public string VacationHomeLocation()
        {
               
            string location = "";

            switch (NumberOfSiblings)
            {
                case 0:

                    Console.WriteLine("Phoenix");

                    break;

                case 1:

                    Console.WriteLine("Miami");

                    break;

                case 2:

                    Console.WriteLine("Houston");

                    break;

                case 3:

                    Console.WriteLine("Portland");

                    break;

                case 4:

                    Console.WriteLine("Seattle");

                    break;

                default:

                    break;

            }

            return location;
        }

        public void ModeofTransport()
        { 
            switch (ModeOfTransportation)
            {
                case "Red":

                    Console.WriteLine("Lamborghini");

                    break;

                case "Orange":

                    Console.WriteLine("BMW");

                    break;

                case "Yellow":

                    Console.WriteLine("Porsche");

                    break;

                case "Green":

                    Console.WriteLine("Ducati");

                    break;

                case "Blue":

                    Console.WriteLine("Honda");

                    break;

                case "Indigo":

                    Console.WriteLine("Chevy");

                    break;

                case "Purple":

                    Console.WriteLine("Ford");

                    break;                    
            }

        }
        

        

    }
}
