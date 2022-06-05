using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class FireSpin : PokeMove
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
            get { return _instance ?? (_instance = new FireSpin()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FireSpin()
            : base(
                83,
                "Fire Spin",
                "Danse Flammes",
                "The target becomes trapped within a fierce vortex of fire that rages for four to five turns.",
                "Un tourbillon de flammes emprisonne l’ennemi pendant quatre à cinq tours.",
                35,
                85,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}