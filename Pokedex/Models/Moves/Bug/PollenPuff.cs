using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class PollenPuff : PokeMove
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
            get { return _instance ?? (_instance = new PollenPuff()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private PollenPuff()
            : base(
                676,
                "Pollen Puff",
                "Boule Pollen",
                "The user attacks the enemy with a pollen puff that explodes. If the target is an ally, it gives the ally a pollen puff that restores its HP instead.",
                "Utilisée sur l’ennemi, envoie une boule explosive qui fait des dégâts ; sur un allié, donne du bon pollen nutritif qui fait récupérer des PV.",
                90,
                100,
                DamageClass.Special,
                TypeBug.Instance
            ) { }
        #endregion
    }
}