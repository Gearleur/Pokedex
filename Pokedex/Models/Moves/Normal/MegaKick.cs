using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class MegaKick : PokeMove
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
            get { return _instance ?? (_instance = new MegaKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MegaKick()
            : base(
                25,
                "Mega Kick",
                "Ultimawashi",
                "The target is attacked by a kick launched with muscle-packed power.",
                "Un coup de pied surpuissant qui frappe l’ennemi.",
                120,
                75,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}