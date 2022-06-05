using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class Retaliate : PokeMove
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
            get { return _instance ?? (_instance = new Retaliate()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Retaliate()
            : base(
                514,
                "Retaliate",
                "Vengeance",
                "The user gets revenge for a fainted ally. If an ally fainted in the previous turn, this move’s power is increased.",
                "Venge un Pokémon de l’équipe mis K.O. Si un Pokémon de l’équipe a été mis K.O. au tour d’avant, l’effet augmente.",
                70,
                100,
                DamageClass.Physical,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}