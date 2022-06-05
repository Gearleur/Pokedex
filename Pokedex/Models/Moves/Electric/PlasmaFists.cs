using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class PlasmaFists : PokeMove
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
            get { return _instance ?? (_instance = new PlasmaFists()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PlasmaFists()
            : base(
                721,
                "Plasma Fists",
                "Plasma Punch",
                "The user attacks with electrically charged fists. This move changes Normal-type moves to Electric-type moves.",
                "Le lanceur attaque en projetant de l’électricité avec ses poings. Convertit les capacités de type Normal en type Électrik.",
                100,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}