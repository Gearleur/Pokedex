using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class AuroraBeam : PokeMove
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
            get { return _instance ?? (_instance = new AuroraBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AuroraBeam()
            : base(
                62,
                "Aurora Beam",
                "Onde Boréale",
                "The target is hit with a rainbow-colored beam. This may also lower the target’s Attack stat.",
                "Envoie un rayon arc-en-ciel sur l’ennemi. Peut aussi baisser son Attaque.",
                65,
                100,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}