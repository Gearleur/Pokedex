using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Grass
{
    internal class TropKick : PokeMove
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
            get { return _instance ?? (_instance = new TropKick()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private TropKick()
            : base(
                688,
                "Trop Kick",
                "Botte Sucrette",
                "The user lands an intense kick of tropical origins on the target. This also lowers the target’s Attack stat.",
                "Un coup de pied chaud comme les tropiques qui inflige des dégâts à la cible et baisse son Attaque.",
                70,
                100,
                DamageClass.Physical,
                TypeGrass.Instance
            ) { }
        #endregion
    }
}