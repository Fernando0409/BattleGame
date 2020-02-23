using System;
using System.Collections.Generic;
using System.Text;

namespace BattleGame
{
    /// <summary>
    /// Class control the atributes of each country 
    /// of game how troops & owner.
    /// </summary>
    class Country
    {
        private string nameCountry, owner, region;
        private int troops, reserveForce;

        /// <summary>
        /// Create a new Country with their initialize features
        /// </summary>
        /// <param name="nameCountry">Name of country</param>
        /// <param name="region">Region or continent of country</param>
        public Country(string nameCountry, string region)
        {
            this.nameCountry = nameCountry;
            this.region = region;
            troops = 0;
        }


        /// <summary>
        /// This method allow change the country
        /// of owner
        /// </summary>
        /// <param name="player"></param>
        /// <param name="nameCountry">Country dominated for the player</param>
        public void setOwner(string player)
        {
            owner = player;
            Console.WriteLine(this.nameCountry + " esta bajo el control de " + owner);
        }

        /// <summary>
        /// This method return who are the owner
        /// of country
        /// </summary>
        /// <returns></returns>
        public string getOwner() => owner;

        /// <summary>
        /// Return the country's name
        /// </summary>
        /// <returns></returns>
        public string getNameCountry() => nameCountry;

        /// <summary>
        /// Return the region where is the country
        /// </summary>
        /// <returns></returns>
        public string getRegion() => region;

        /// <summary>
        /// Add new troops to country in the map
        /// </summary>
        /// <param name="troops"></param>
        public void addTroops(int troops)
        {
            this.troops += troops;
            Console.WriteLine("Se añadieron " + this.troops + " a " + this.nameCountry);
        }

        /// <summary>
        /// Delete or reduce the troops in a country
        /// </summary>
        /// <param name="troops">Number of troops that reduce the force military
        /// in the country </param>
        public void subTroops(int troops)
        {
            if (this.troops - troops > 2)
            {
                this.troops -= troops;
                Console.WriteLine(this.nameCountry + "ahora tiene " + this.troops + "tropas");
            }
            else
                Console.WriteLine("Debe haber minimo 2 tropas por region");
        }

    }
}
