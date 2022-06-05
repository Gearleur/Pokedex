using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class RockBlast : PokeMove
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static PokeMove? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static PokeMove Instance
        {
            get { return _instance ?? (_instance = new RockBlast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RockBlast()
            : base(
                350,
                "Rock Blast",
                "Boule Roc",
                "The user hurls hard rocks at the target. Two to five rocks are launched in a row.",
                "Le lanceur projette un rocher sur l’ennemi de deux à cinq fois d’affilée.",
                25,
                90,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}