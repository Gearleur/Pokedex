using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Flying
{
    internal class Gust : PokeMove
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
            get { return _instance ?? (_instance = new Gust()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Gust()
            : base(
                16,
                "Gust",
                "Tornade",
                "A gust of wind is whipped up by wings and launched at the target to inflict damage.",
                "Le lanceur bat des ailes pour générer une bourrasque qui blesse l’ennemi.",
                40,
                100,
                DamageClass.Special,
                TypeFlying.Instance
            ) { }
        #endregion
    }
}