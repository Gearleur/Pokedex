using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class AquaJet : PokeMove
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
            get { return _instance ?? (_instance = new AquaJet()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AquaJet()
            : base(
                453,
                "Aqua Jet",
                "Aqua-Jet",
                "The user lunges at the target at a speed that makes it almost invisible. This move always goes first.",
                "Le lanceur fonce sur l’ennemi si rapidement qu’on parvient à peine à le discerner. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}