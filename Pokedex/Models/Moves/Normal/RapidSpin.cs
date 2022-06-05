using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class RapidSpin : PokeMove
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
            get { return _instance ?? (_instance = new RapidSpin()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RapidSpin()
            : base(
                229,
                "Rapid Spin",
                "Tour Rapide",
                "A spin attack that can also eliminate such moves as Bind, Wrap, and Leech Seed. This also raises the user’s Speed stat.",
                "Une attaque tournoyante pouvant aussi annuler, par exemple, Étreinte, Ligotage ou Vampigraine. Augmente également la Vitesse du lanceur.",
                50,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}