using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ground
{
    internal class Earthquake : PokeMove
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
            get { return _instance ?? (_instance = new Earthquake()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Earthquake()
            : base(
                89,
                "Earthquake",
                "Séisme",
                "The user sets off an earthquake that strikes every Pokémon around it.",
                "Le lanceur provoque un tremblement de terre touchant tous les Pokémon autour de lui.",
                100,
                100,
                DamageClass.Physical,
                TypeGround.Instance
            ) { }
        #endregion
    }
}