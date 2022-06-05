using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class MeteorMash : PokeMove
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
            get { return _instance ?? (_instance = new MeteorMash()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MeteorMash()
            : base(
                309,
                "Meteor Mash",
                "Poing Météore",
                "The target is hit with a hard punch fired like a meteor. This may also raise the user’s Attack stat.",
                "Un coup de poing lancé à la vitesse d’un météore. Peut aussi augmenter l’Attaque du lanceur.",
                90,
                90,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}