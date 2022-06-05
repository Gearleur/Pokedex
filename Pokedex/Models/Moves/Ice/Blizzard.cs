using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class Blizzard : PokeMove
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
            get { return _instance ?? (_instance = new Blizzard()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Blizzard()
            : base(
                59,
                "Blizzard",
                "Blizzard",
                "A howling blizzard is summoned to strike opposing Pokémon. This may also leave the opposing Pokémon frozen.",
                "Une violente tempête de neige s’abat sur l’ennemi. Peut aussi le geler.",
                110,
                70,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}