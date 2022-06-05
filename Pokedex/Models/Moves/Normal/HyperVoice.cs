using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Normal
{
    internal class HyperVoice : PokeMove
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
            get { return _instance ?? (_instance = new HyperVoice()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private HyperVoice()
            : base(
                304,
                "Hyper Voice",
                "Mégaphone",
                "The user lets loose a horribly echoing shout with the power to inflict damage.",
                "Le lanceur pousse un cri dont l’écho terrifiant a le pouvoir d’infliger des dégâts à l’ennemi.",
                90,
                100,
                DamageClass.Special,
                TypeNormal.Instance
            ) { }
        #endregion
    }
}