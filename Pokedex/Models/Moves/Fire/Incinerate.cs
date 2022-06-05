using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Fire
{
    internal class Incinerate : PokeMove
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
            get { return _instance ?? (_instance = new Incinerate()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private Incinerate()
            : base(
                510,
                "Incinerate",
                "Calcination",
                "The user attacks opposing Pokémon with fire. If a Pokémon is holding a certain item, such as a Berry, the item becomes burned up and unusable.",
                "Des flammes calcinent l’ennemi. S’il tient un objet, une Baie par exemple, celui-ci est brûlé et devient inutilisable.",
                60,
                100,
                DamageClass.Special,
                TypeFire.Instance
            ) { }
        #endregion
    }
}