using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Psy
{
    internal class ExpandingForce : PokeMove
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
            get { return _instance ?? (_instance = new ExpandingForce()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private ExpandingForce()
            : base(
                797,
                "Expanding Force",
                "Vaste Pouvoir",
                "The user attacks the target with its psychic power. This move’s power goes up and damages all opposing Pokémon on Psychic Terrain.",
                "Le lanceur attaque la cible avec ses pouvoirs psychiques. Si un Champ Psychique est actif, la puissance de cette capacité augmente et elle touche tous les ennemis.",
                80,
                100,
                DamageClass.Special,
                TypePsy.Instance
            ) { }
        #endregion
    }
}