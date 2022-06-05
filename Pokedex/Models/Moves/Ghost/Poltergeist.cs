using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class Poltergeist : PokeMove
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
            get { return _instance ?? (_instance = new Poltergeist()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Poltergeist()
            : base(
                809,
                "Poltergeist",
                "Esprit Frappeur",
                "The user attacks the target by controlling the target’s item. The move fails if the target doesn’t have an item.",
                "Le lanceur manipule l’objet tenu par l’ennemi pour l’attaquer. Échoue si la cible ne tient rien.",
                110,
                90,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}