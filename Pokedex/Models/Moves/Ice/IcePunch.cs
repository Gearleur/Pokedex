using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IcePunch : PokeMove
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
            get { return _instance ?? (_instance = new IcePunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IcePunch()
            : base(
                8,
                "Ice Punch",
                "Poing Glace",
                "The target is punched with an icy fist. This may also leave the target frozen.",
                "Un coup de poing glacé vient frapper l’ennemi. Peut le geler.",
                75,
                100,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}