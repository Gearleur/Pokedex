using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class JawLock : PokeMove
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
            get { return _instance ?? (_instance = new JawLock()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private JawLock()
            : base(
                746,
                "Jaw Lock",
                "Croque Fort",
                "This move prevents the user and the target from switching out until either of them faints. The effect goes away if either of the Pokémon leaves the field.",
                "Le lanceur et sa cible ne peuvent plus quitter le terrain jusqu’à ce que l’un d’entre eux tombe K.O. L’effet est annulé si l’un des deux Pokémon disparaît.",
                80,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}