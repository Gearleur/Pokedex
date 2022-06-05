using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class Accelerock : PokeMove
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
            get { return _instance ?? (_instance = new Accelerock()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Accelerock()
            : base(
                709,
                "Accelerock",
                "Vif Roc",
                "The user smashes into the target at high speed. This move always goes first.",
                "Le lanceur charge l’ennemi à toute vitesse. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}