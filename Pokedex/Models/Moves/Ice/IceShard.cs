using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Ice
{
    internal class IceShard : PokeMove
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
            get { return _instance ?? (_instance = new IceShard()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private IceShard()
            : base(
                420,
                "Ice Shard",
                "Éclats Glace",
                "The user flash-freezes chunks of ice and hurls them at the target. This move always goes first.",
                "Le lanceur crée des éclats de glace qu’il envoie sur l’ennemi. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeIce.Instance
            ) { }
        #endregion
    }
}