using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class GrassyGlide : PokeMove
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
            get { return _instance ?? (_instance = new GrassyGlide()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GrassyGlide()
            : base(
                803,
                "Grassy Glide",
                "Gliss’Herbe",
                "Gliding on the ground, the user attacks the target. This move always goes first on Grassy Terrain.",
                "Le lanceur attaque l’ennemi en glissant sur le terrain. Frappe toujours en priorité si un Champ Herbu est actif.",
                70,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}