using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class Octazooka : PokeMove
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
            get { return _instance ?? (_instance = new Octazooka()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Octazooka()
            : base(
                190,
                "Octazooka",
                "Octazooka",
                "The user attacks by spraying ink in the target’s face or eyes. This may also lower the target’s accuracy.",
                "Le lanceur attaque en projetant de l’encre au visage de l’ennemi. Peut aussi baisser sa Précision.",
                65,
                85,
                DamageClass.Special,
                TypeWater.Instance
            ) { }
        #endregion
    }
}