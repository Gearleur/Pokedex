using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class QuickAttack : PokeMove
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
            get { return _instance ?? (_instance = new QuickAttack()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private QuickAttack()
            : base(
                98,
                "Quick Attack",
                "Vive-Attaque",
                "The user lunges at the target at a speed that makes it almost invisible. This move always goes first.",
                "Le lanceur fonce sur l’ennemi si rapidement qu’on parvient à peine à le discerner. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}