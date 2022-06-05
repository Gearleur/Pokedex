using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class FrostBreath : PokeMove
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
            get { return _instance ?? (_instance = new FrostBreath()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private FrostBreath()
            : base(
                524,
                "Frost Breath",
                "Souffle Glacé",
                "The user blows its cold breath on the target. This attack always results in a critical hit.",
                "Un souffle froid blesse l’ennemi. L’effet est toujours critique.",
                60,
                90,
                DamageClass.Special,
                TypeIce.Instance
            ) { }
        #endregion
    }
}