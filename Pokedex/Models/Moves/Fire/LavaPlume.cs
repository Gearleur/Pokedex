using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class LavaPlume : PokeMove
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
            get { return _instance ?? (_instance = new LavaPlume()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private LavaPlume()
            : base(
                436,
                "Lava Plume",
                "Ébullilave",
                "The user torches everything around it in an inferno of scarlet flames. This may also leave those it hits with a burn.",
                "Des boules de feu s’abattent sur tous les Pokémon autour du lanceur. Peut aussi les brûler.",
                80,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}