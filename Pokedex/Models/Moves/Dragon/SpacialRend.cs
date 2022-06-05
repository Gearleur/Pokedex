using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dragon
{
    internal class SpacialRend : PokeMove
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
            get { return _instance ?? (_instance = new SpacialRend()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SpacialRend()
            : base(
                460,
                "Spacial Rend",
                "Spatio-Rift",
                "The user tears the target along with the space around it. Critical hits land more easily.",
                "Le lanceur déchire l’ennemi et l’espace autour de lui. Taux de critiques élevé.",
                100,
                95,
                DamageClass.Special,
                TypeDragon.Instance
            ) { }
        #endregion
    }
}