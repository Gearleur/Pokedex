using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class IronTail : PokeMove
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
            get { return _instance ?? (_instance = new IronTail()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IronTail()
            : base(
                231,
                "Iron Tail",
                "Queue de Fer",
                "The target is slammed with a steel-hard tail. This may also lower the target’s Defense stat.",
                "Attaque l’ennemi avec une queue de fer. Peut aussi baisser sa Défense.",
                100,
                75,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}