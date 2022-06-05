using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class Nuzzle : PokeMove
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
            get { return _instance ?? (_instance = new Nuzzle()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Nuzzle()
            : base(
                609,
                "Nuzzle",
                "Frotte-Frimousse",
                "The user attacks by nuzzling its electrified cheeks against the target. This also leaves the target with paralysis.",
                "Le lanceur attaque en frottant ses bajoues chargées d’électricité. Paralyse l’ennemi.",
                20,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}