using System;
using System.Collections.Generic;
using System.Text;

namespace BattleGame
{   
    /// <summary>
    /// This class manage the atributes and acction of players
    /// in the game.
    /// </summary>
    class Players
    {
        private string namePlayer;
        private int reserveForce, score;
        private string[] countriesDominated = new string[64];

        /// <summary>
        /// Create a new player with their initial features
        /// </summary>
        /// <param name="namePlayer">Nickname o real name of player</param>
        public Players(string namePlayer)
        {
            this.namePlayer = namePlayer;
            reserveForce = 0;
            score = 0;
        }
           
        /// <summary>
        /// Set the player's name
        /// </summary>
        /// <param name="namePlayer"> Player's name of game</param>
        public void setNamePlayer(string namePlayer)
        {
            this.namePlayer = namePlayer;
            Console.WriteLine("Nombre establecido.");
        }

        /// <summary>
        /// Return the player's name
        /// </summary>
        public string getNamePlayer() => namePlayer;

        /// <summary>
        /// Almacenate the player's troops to later place
        /// in your country
        /// </summary>
        /// <param name="troops">Troops to reserve</param>
        public void setReserveForce(int troops)
        {
            reserveForce += troops;
            Console.WriteLine("Reserva de tropas actualizada");
        }

        /// <summary>
        /// Return the number of troops of player
        /// </summary>
        /// <returns></returns>
        public int getReserveForce() => reserveForce;

        /// <summary>
        /// Add or substract player's score
        /// </summary>
        /// <param name="score"></param>
        public void setScore(int score) => this.score += score;

        /// <summary>
        /// Return the score that have the player
        /// in the game
        /// </summary>
        /// <returns></returns>
        public int getScore() => score;
    }
}
