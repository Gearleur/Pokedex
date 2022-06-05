using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FireLash : PokeMove
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
            get { return _instance ?? (_instance = new FireLash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FireLash()
            : base(
                680,
                "Fire Lash",
                "Fouet de Feu",
                "The user strikes the target with a burning lash. This also lowers the target’s Defense stat.",
                "Frappe la cible avec un fouet incandescent et baisse sa Défense.",
                80,
                100,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}