﻿namespace TicTacToe.Models
{
    public enum PlayerType 
    {
        Normal,
        Ai
    }

    public interface IPlayer
    {
        /// <summary>
        /// Gets or sets the player identifier.
        /// </summary>
        /// <value>The player identifier.</value>
        int PlayerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it's this players turn.
        /// </summary>
        /// <value><c>true</c> if is player turn; otherwise, <c>false</c>.</value>
        bool IsPlayerTurn { get; set; }

        /// <summary>
        /// Gets or sets the type of the player.
        /// </summary>
        /// <value>The type of the player.</value>
        PlayerType PlayerType { get; set; }

        /// <summary>
        /// Gets or sets the player avatar. (Noughts/Crosses)
        /// </summary>
        /// <value>The player avatar.</value>
        int PlayerAvatar { get; set; }
        
        /// <summary>
        /// Gets or updates the amount of turns the player has taken.
        /// </summary>
        /// <value>Turns taken by player.</value>
        int TurnsTaken { get; set; }
    }
}