using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Steel
{
    internal class BulletPunch : PokeMove
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
            get { return _instance ?? (_instance = new BulletPunch()); }
        }
        #endregion
        
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        private BulletPunch()
            : base(
                418,
                "Bullet Punch",
                "Pisto-Poing",
                "The user strikes the target with tough punches as fast as bullets. This move always goes first.",
                "Le lanceur envoie des coups de poing aussi rapides que des balles de revolver. Frappe en priorité.",
                40,
                100,
                DamageClass.Physical,
                TypeSteel.Instance
            ) { }
        #endregion
    }
}