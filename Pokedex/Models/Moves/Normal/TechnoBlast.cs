using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class TechnoBlast : PokeMove
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
            get { return _instance ?? (_instance = new TechnoBlast()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TechnoBlast()
            : base(
                546,
                "Techno Blast",
                "Techno-Buster",
                "The user fires a beam of light at its target. The move’s type changes depending on the Drive the user holds.",
                "Le lanceur projette un rayon lumineux sur l’ennemi. Le type varie selon le Module que tient le lanceur.",
                120,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}