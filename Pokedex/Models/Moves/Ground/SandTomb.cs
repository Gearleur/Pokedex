using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class SandTomb : PokeMove
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
            get { return _instance ?? (_instance = new SandTomb()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SandTomb()
            : base(
                328,
                "Sand Tomb",
                "Tourbi-Sable",
                "The user traps the target inside a harshly raging sandstorm for four to five turns.",
                "Le lanceur emprisonne l’ennemi dans une tempête de sable terrifiante qui dure de quatre à cinq tours.",
                35,
                85,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}