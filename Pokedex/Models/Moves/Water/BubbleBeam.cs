using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class BubbleBeam : PokeMove
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
            get { return _instance ?? (_instance = new BubbleBeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BubbleBeam()
            : base(
                61,
                "Bubble Beam",
                "Bulles d’O",
                "A spray of bubbles is forcefully ejected at the target. This may also lower the target’s Speed stat.",
                "Des bulles sont envoyées avec puissance sur l’ennemi. Peut aussi baisser sa Vitesse.",
                65,
                100,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}