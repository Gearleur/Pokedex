using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class MagmaStorm : PokeMove
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
            get { return _instance ?? (_instance = new MagmaStorm()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MagmaStorm()
            : base(
                463,
                "Magma Storm",
                "Vortex Magma",
                "The target becomes trapped within a maelstrom of fire that rages for four to five turns.",
                "L’ennemi est pris dans un tourbillon de feu qui dure de quatre à cinq tours.",
                100,
                75,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}