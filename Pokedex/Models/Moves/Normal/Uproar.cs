using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Uproar : PokeMove
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
            get { return _instance ?? (_instance = new Uproar()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Uproar()
            : base(
                253,
                "Uproar",
                "Brouhaha",
                "The user attacks in an uproar for three turns. During that time, no Pokémon can fall asleep.",
                "Le lanceur attaque en rugissant durant trois tours. Pendant ce temps, aucun Pokémon ne peut s’endormir.",
                90,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}