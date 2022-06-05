using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class MultiAttack : PokeMove
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
            get { return _instance ?? (_instance = new MultiAttack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MultiAttack()
            : base(
                718,
                "Multi-Attack",
                "Coup Varia-Type",
                "Cloaking itself in high energy, the user slams into the target. The memory held determines the move’s type.",
                "Le Pokémon s’entoure d’une puissante énergie avant de foncer sur sa cible. Le type de la capacité dépend de la ROM installée.",
                120,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}