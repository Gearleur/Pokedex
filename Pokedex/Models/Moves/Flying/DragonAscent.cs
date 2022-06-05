using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class DragonAscent : PokeMove
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
            get { return _instance ?? (_instance = new DragonAscent()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonAscent()
            : base(
                620,
                "Dragon Ascent",
                "Draco-Ascension",
                "After soaring upward, the user attacks its target by dropping out of the sky at high speeds. But it lowers its own Defense and Sp. Def stats in the process.",
                "Le Pokémon s’abat à toute vitesse sur la cible depuis les hautes couches de l’atmosphère. Baisse la Défense et la Défense Spéciale du lanceur.",
                120,
                100,
                DamageClass.Physical,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}