using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class FreezeShock : PokeMove
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
            get { return _instance ?? (_instance = new FreezeShock()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FreezeShock()
            : base(
                553,
                "Freeze Shock",
                "Éclair Gelé",
                "On the second turn, the user hits the target with electrically charged ice. This may also leave the target with paralysis.",
                "Projette un bloc de glace électrifié sur l’ennemi au second tour. Peut aussi le paralyser.",
                140,
                90,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}