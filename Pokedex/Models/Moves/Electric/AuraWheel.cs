using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class AuraWheel : PokeMove
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
            get { return _instance ?? (_instance = new AuraWheel()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AuraWheel()
            : base(
                783,
                "Aura Wheel",
                "Roue Libre",
                "Morpeko attacks and raises its Speed with the energy stored in its cheeks. This move’s type changes depending on the user’s form.",
                "Morpeko libère l’énergie stockée dans ses joues pour attaquer et augmenter sa Vitesse. Le type de cette capacité change en fonction de la forme de Morpeko.",
                110,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}