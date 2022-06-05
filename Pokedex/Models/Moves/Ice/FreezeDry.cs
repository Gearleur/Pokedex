using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class FreezeDry : PokeMove
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
            get { return _instance ?? (_instance = new FreezeDry()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FreezeDry()
            : base(
                573,
                "Freeze-Dry",
                "Lyophilisation",
                "The user rapidly cools the target. This may also leave the target frozen. This move is super effective on Water types.",
                "Refroidit violemment l’ennemi et peut le geler. Super efficace sur les Pokémon de type Eau.",
                70,
                100,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}