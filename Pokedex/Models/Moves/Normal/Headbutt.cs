using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Headbutt : PokeMove
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
            get { return _instance ?? (_instance = new Headbutt()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Headbutt()
            : base(
                29,
                "Headbutt",
                "Coup d’Boule",
                "The user sticks out its head and attacks by charging straight into the target. This may also make the target flinch.",
                "Le lanceur donne un coup de tête. Peut apeurer l’ennemi.",
                70,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}