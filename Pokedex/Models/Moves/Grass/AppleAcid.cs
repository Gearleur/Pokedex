using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class AppleAcid : PokeMove
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
            get { return _instance ?? (_instance = new AppleAcid()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private AppleAcid()
            : base(
                787,
                "Apple Acid",
                "Acide Malique",
                "The user attacks the target with an acidic liquid created from tart apples. This also lowers the target’s Sp. Def stat.",
                "Le lanceur attaque son adversaire avec un liquide corrosif créé à partir d’une pomme acide. Baisse la Défense Spéciale de la cible.",
                80,
                100,
                DamageClass.Special,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}