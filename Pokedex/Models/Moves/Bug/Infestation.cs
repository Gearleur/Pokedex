using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class Infestation : PokeMove
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
            get { return _instance ?? (_instance = new Infestation()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Infestation()
            : base(
                611,
                "Infestation",
                "Harcèlement",
                "The target is infested and attacked for four to five turns. The target can’t flee during this time.",
                "Cette attaque perdure pendant quatre à cinq tours. L’ennemi ne peut pas fuir au cours de cette période.",
                20,
                100,
                DamageClass.Special,
                TypeBug.Instance
            ) { }
        #endregion
    }
}