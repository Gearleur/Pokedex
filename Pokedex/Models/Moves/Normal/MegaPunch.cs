using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class MegaPunch : PokeMove
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
            get { return _instance ?? (_instance = new MegaPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MegaPunch()
            : base(
                5,
                "Mega Punch",
                "Ultimapoing",
                "The target is slugged by a punch thrown with muscle-packed power.",
                "L’ennemi reçoit un coup de poing d’une puissance incroyable.",
                80,
                85,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}