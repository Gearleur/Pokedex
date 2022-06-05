using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class BoltStrike : PokeMove
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
            get { return _instance ?? (_instance = new BoltStrike()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BoltStrike()
            : base(
                550,
                "Bolt Strike",
                "Charge Foudre",
                "The user surrounds itself with a great amount of electricity and charges its target. This may also leave the target with paralysis.",
                "Le lanceur s’enveloppe d’une charge électrique surpuissante et se jette sur l’ennemi. Peut aussi le paralyser.",
                130,
                85,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}