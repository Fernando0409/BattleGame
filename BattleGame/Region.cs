using System;
using System.Collections.Generic;
using System.Text;

namespace BattleGame
{
    /// <summary>
    /// This class have the informacion of each region how
    /// Countries' name, Region's name, leader.
    /// </summary>
    class Region
    {
        /*
        // Countries' region
        private string[] asia = new string[13] {"Asia","Afganistan", "China", "India", "Irkutsk", "Japon", "Kamchatka", "Oriente Medio",
                                                "Mongolia", "Siam", "Siberia", "Ural", "Yakutsk"};

        private string[] northAmerica = new string[10] {"America del Norte","Alaska", "Alberta", "Mexico, America Central y el Caribe", 
                                                        "Estados Unidos del Este", "Groenlandia", "Territorio del Noroeste", 
                                                        "Ontario", "Quebec", "Estados Unidos del Oeste"};

        private string[] europe = new string[8] {"Europa", "Gran Bretaña", "Islandia", "Europa del Norte", "Escandinavia", "Europa del Sur", 
                                                    "Ucrania", "Europa Ocidental" };

        private string[] africa = new string[7] {"Africa", "Congo", "Africa Oriental", "Egipto", "Madagascar", "Africa del norte", "Sudafrica" };

        private string[] southAmerica = new string[5] {"America del Sur" ,"Argentina", "Brasil", "Peru", "Venezuela"};
        private string[] oceania = new string[5] { "Oceania", "Australia Oriental", "Indonesia", "Nueva Guinea", "Australia Occidental" };


        /// <summary>
        /// This method return the countries' number
        /// in the region
        /// </summary>
        /// <param name="region"> Region where search the number of countries</param>
        /// <returns></returns>
        public int getNumCountries(string region)
        {
            int numCountries = 0;

            if (asia[0].Equals(region))
                numCountries = asia.Length - 1;

            else if (northAmerica[0].Equals(region))
                numCountries = northAmerica.Length - 1;

            else if (europe[0].Equals(region))
                numCountries = europe.Length - 1;

            else if (africa[0].Equals(region))
                numCountries = europe.Length - 1;

            else if (southAmerica[0].Equals(region))
                numCountries = southAmerica.Length - 1;

            else if (oceania[0].Equals(region))
                numCountries = oceania.Length - 1;

            else
                numCountries = 0;

            return numCountries;
        }

       /* public string[] getCountriesRegion(string region)
        {
            if (asia[0].Equals(region))
                return asia;

            else if (northAmerica[0].Equals(region))
                return northAmerica;

            else if (europe[0].Equals(region))
                return europe;

            else if (africa[0].Equals(region))
                return africa;

            else if (southAmerica[0].Equals(region))
                return southAmerica;

            else if (oceania[0].Equals(region))
                return oceania;
        }*/
    }
}
