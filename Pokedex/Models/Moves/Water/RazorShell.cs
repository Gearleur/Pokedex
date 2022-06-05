using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Water
{
    internal class RazorShell : PokeMove
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
            get { return _instance ?? (_instance = new RazorShell()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private RazorShell()
            : base(
                534,
                "Razor Shell",
                "Coqui-Lame",
                "The user cuts its target with sharp shells. This may also lower the target’s Defense stat.",
                "Un coquillage aiguisé lacère l’ennemi. Peut aussi baisser sa Défense.",
                75,
                95,
                DamageClass.Physical,
                TypeWater.Instance
            ) { }
        #endregion
    }
}