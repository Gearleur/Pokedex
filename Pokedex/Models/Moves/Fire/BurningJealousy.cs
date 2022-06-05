using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class BurningJealousy : PokeMove
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
            get { return _instance ?? (_instance = new BurningJealousy()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BurningJealousy()
            : base(
                807,
                "Burning Jealousy",
                "Feu Envieux",
                "The user attacks with energy from jealousy. This leaves all opposing Pokémon that have had their stats boosted during the turn with a burn.",
                "Le lanceur attaque sa cible avec toute sa jalousie. Cette capacité brûle tout Pokémon dont les stats ont augmenté pendant ce tour.",
                70,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}