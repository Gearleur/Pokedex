using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Bug
{
    internal class XScissor : PokeMove
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
            get { return _instance ?? (_instance = new XScissor()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private XScissor()
            : base(
                404,
                "X-Scissor",
                "Plaie Croix",
                "The user slashes at the target by crossing its scythes or claws as if they were a pair of scissors.",
                "Le lanceur taillade l’ennemi en utilisant ses faux ou ses griffes comme une paire de ciseaux.",
                80,
                100,
                DamageClass.Physical,
                TypeBug.Instance
            ) { }
        #endregion
    }
}