using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class SecretSword : PokeMove
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
            get { return _instance ?? (_instance = new SecretSword()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SecretSword()
            : base(
                548,
                "Secret Sword",
                "Lame Ointe",
                "The user cuts with its long horn. The odd power contained in the horn does physical damage to the target.",
                "L’ennemi est lacéré par une longue corne. Son pouvoir mystérieux inflige des dégâts physiques.",
                85,
                100,
                DamageClass.Special,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}