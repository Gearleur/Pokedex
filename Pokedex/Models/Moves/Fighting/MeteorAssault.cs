using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fighting
{
    internal class MeteorAssault : PokeMove
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
            get { return _instance ?? (_instance = new MeteorAssault()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MeteorAssault()
            : base(
                794,
                "Meteor Assault",
                "Joute Astrale",
                "The user attacks wildly with its thick leek. The user can’t move on the next turn, because the force of this move makes it stagger.",
                "Le lanceur attaque son adversaire avec son poireau. Toutefois, cette action le fait vaciller et il doit se reposer au tour suivant.",
                150,
                100,
                DamageClass.Physical,
                TypeFighting.Instance
            ) { }
        #endregion
    }
}