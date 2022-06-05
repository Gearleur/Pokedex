using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Eruption : PokeMove
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
            get { return _instance ?? (_instance = new Eruption()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Eruption()
            : base(
                284,
                "Eruption",
                "Éruption",
                "The user attacks opposing Pokémon with explosive fury. The lower the user’s HP, the lower the move’s power.",
                "Le lanceur laisse exploser sa colère. Plus ses PV sont bas, moins l’attaque est puissante.",
                150,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}