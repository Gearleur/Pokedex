using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class GravApple : PokeMove
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
            get { return _instance ?? (_instance = new GravApple()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private GravApple()
            : base(
                788,
                "Grav Apple",
                "Force G",
                "The user inflicts damage by dropping an apple from high above. This also lowers the target’s Defense stat.",
                "Le lanceur attaque son adversaire avec une pomme qu’il fait tomber de très haut. Baisse la Défense de la cible.",
                80,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}