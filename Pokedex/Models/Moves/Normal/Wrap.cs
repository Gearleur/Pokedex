using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Wrap : PokeMove
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
            get { return _instance ?? (_instance = new Wrap()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Wrap()
            : base(
                35,
                "Wrap",
                "Ligotage",
                "A long body, vines, or the like are used to wrap and squeeze the target for four to five turns.",
                "Le lanceur ligote l’ennemi avec des lianes ou son corps pour l’écraser durant quatre à cinq tours.",
                15,
                90,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}