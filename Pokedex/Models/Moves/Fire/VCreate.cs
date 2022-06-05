using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class VCreate : PokeMove
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
            get { return _instance ?? (_instance = new VCreate()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private VCreate()
            : base(
                557,
                "V-create",
                "Coup Victoire",
                "With a hot flame on its forehead, the user hurls itself at its target. This lowers the user’s Defense, Sp. Def, and Speed stats.",
                "Le lanceur projette une flamme ardente de son front et se jette sur l’ennemi. Baisse la Défense, la Défense Spéciale et la Vitesse.",
                180,
                95,
                DamageClass.Physical,
                TypeFire.Instance
            ) { }
        #endregion
    }
}