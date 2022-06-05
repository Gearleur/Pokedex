using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class DynamaxCannon : PokeMove
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
            get { return _instance ?? (_instance = new DynamaxCannon()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private DynamaxCannon()
            : base(
                744,
                "Dynamax Cannon",
                "Canon Dynamax",
                "The user unleashes a strong beam from its core. This move deals twice the damage if the target is Dynamaxed.",
                "Le lanceur attaque en émettant un laser depuis son noyau. Cette capacité inflige deux fois plus de dégâts si l’adversaire est un Pokémon Dynamax.",
                100,
                100,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}