using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class Psybeam : PokeMove
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
            get { return _instance ?? (_instance = new Psybeam()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Psybeam()
            : base(
                60,
                "Psybeam",
                "Rafale Psy",
                "The target is attacked with a peculiar ray. This may also leave the target confused.",
                "Un étrange rayon frappe l’ennemi. Peut aussi le rendre confus.",
                65,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}