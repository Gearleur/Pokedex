using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class KnockOff : PokeMove
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
            get { return _instance ?? (_instance = new KnockOff()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private KnockOff()
            : base(
                282,
                "Knock Off",
                "Sabotage",
                "The user slaps down the target’s held item, and that item can’t be used in that battle. The move does more damage if the target has a held item.",
                "Fait plus de dégâts aux cibles qui tiennent un objet. De plus, fait tomber cet objet et empêche la cible de l’utiliser jusqu’à la fin du combat.",
                65,
                100,
                DamageClass.Physical,
                TypeDark.Instance
            ) { }
        #endregion
    }
}