using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Dark
{
    internal class NightDaze : PokeMove
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
            get { return _instance ?? (_instance = new NightDaze()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private NightDaze()
            : base(
                539,
                "Night Daze",
                "Explonuit",
                "The user lets loose a pitch-black shock wave at its target. This may also lower the target’s accuracy.",
                "Le lanceur attaque l’ennemi avec une onde de choc ténébreuse. Peut aussi baisser sa Précision.",
                85,
                95,
                DamageClass.Special,
                TypeDark.Instance
            ) { }
        #endregion
    }
}