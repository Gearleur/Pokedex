using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class TerrainPulse : PokeMove
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
            get { return _instance ?? (_instance = new TerrainPulse()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TerrainPulse()
            : base(
                805,
                "Terrain Pulse",
                "Champlification",
                "The user utilizes the power of the terrain to attack. This move’s type and power changes depending on the terrain when it’s used.",
                "Une attaque qui tire sa force des champs. Son type et sa puissance varient selon le champ actif.",
                50,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}