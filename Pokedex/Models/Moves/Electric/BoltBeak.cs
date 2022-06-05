using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Electric
{
    internal class BoltBeak : PokeMove
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
            get { return _instance ?? (_instance = new BoltBeak()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BoltBeak()
            : base(
                754,
                "Bolt Beak",
                "Prise de Bec",
                "The user stabs the target with its electrified beak. If the user attacks before the target, the power of this move is doubled.",
                "Le lanceur transperce sa cible avec son bec chargé d’électricité. Si cette attaque est lancée avant que la cible n’attaque, elle infligera deux fois plus de dégâts.",
                85,
                100,
                DamageClass.Physical,
                TypeElectric.Instance
            ) { }
        #endregion
    }
}