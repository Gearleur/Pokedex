using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ghost
{
    internal class ShadowBone : PokeMove
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
            get { return _instance ?? (_instance = new ShadowBone()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ShadowBone()
            : base(
                708,
                "Shadow Bone",
                "Os Ombre",
                "The user attacks by beating the target with a bone that contains a spirit. This may also lower the target’s Defense stat.",
                "Le lanceur frappe avec un os possédé par l’âme d’un défunt. Peut aussi baisser la Défense de la cible.",
                85,
                100,
                DamageClass.Physical,
                TypeGhost.Instance
            ) { }
        #endregion
    }
}