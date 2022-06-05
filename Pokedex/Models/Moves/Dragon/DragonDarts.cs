using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DragonDarts : PokeMove
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
            get { return _instance ?? (_instance = new DragonDarts()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DragonDarts()
            : base(
                751,
                "Dragon Darts",
                "Draco-Flèches",
                "The user attacks twice using Dreepy. If there are two targets, this move hits each target once.",
                "Le lanceur attaque en propulsant deux Fantyrm. S’il y a deux adversaires, chacun d’entre eux est frappé par un Fantyrm.",
                50,
                100,
                DamageClass.Physical,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}