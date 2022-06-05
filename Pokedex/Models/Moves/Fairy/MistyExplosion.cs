using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fairy
{
    internal class MistyExplosion : PokeMove
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
            get { return _instance ?? (_instance = new MistyExplosion()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private MistyExplosion()
            : base(
                802,
                "Misty Explosion",
                "Explo-Brume",
                "The user attacks everything around it and faints upon using this move. This move’s power is increased on Misty Terrain.",
                "Le lanceur frappe tous les Pokémon autour de lui en explosant, ce qui le met K.O. La puissance de cette attaque augmente si un Champ Brumeux est actif.",
                100,
                100,
                DamageClass.Special,
                TypeFairy.Instance
            ) { }
        #endregion
    }
}