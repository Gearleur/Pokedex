using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Boomburst : PokeMove
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
            get { return _instance ?? (_instance = new Boomburst()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Boomburst()
            : base(
                586,
                "Boomburst",
                "Bang Sonique",
                "The user attacks everything around it with the destructive power of a terrible, explosive sound.",
                "Attaque les Pokémon alentour grâce à une onde sonore assourdissante qui détruit tout sur son passage.",
                140,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}