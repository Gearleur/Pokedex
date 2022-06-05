using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class PsychoCut : PokeMove
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
            get { return _instance ?? (_instance = new PsychoCut()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PsychoCut()
            : base(
                427,
                "Psycho Cut",
                "Coupe Psycho",
                "The user tears at the target with blades formed by psychic power. Critical hits land more easily.",
                "Le lanceur entaille l’ennemi grâce à des lames faites d’énergie psychique. Taux de critiques élevé.",
                70,
                100,
                DamageClass.Physical,
                TypePsy.Instance
            ) { }
        #endregion
    }
}