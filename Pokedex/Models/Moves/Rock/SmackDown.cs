using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Rock
{
    internal class SmackDown : PokeMove
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
            get { return _instance ?? (_instance = new SmackDown()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private SmackDown()
            : base(
                479,
                "Smack Down",
                "Anti-Air",
                "The user throws a stone or similar projectile to attack the target. A flying Pokémon will fall to the ground when it’s hit.",
                "Le lanceur jette toutes sortes de projectiles à un ennemi. Si ce dernier vole, il tombe au sol.",
                50,
                100,
                DamageClass.Physical,
                TypeRock.Instance
            ) { }
        #endregion
    }
}