// https://www.pokemon.com/us/pokedex/14

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Kakuna : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Kakuna()); }
        }
        #endregion
        
        #region Constructors
        private Kakuna()
            : base(
                14,
                "Kakuna",
                "Coconfort",
                TypeBug.Instance,
                TypePoison.Instance,
                6,
                100,
                "Cocoon Pokémon",
                "Pokémon Cocon",
                "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy.",
                "Il peut à peine bouger. Quand il est menacé, il sort parfois son aiguillon pour empoisonner ses ennemis.",
                45,
                25,
                50,
                25,
                25,
                35
            )
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="Pokemon.InitMoveList"/>
        public override void InitMoveList()
        {
            this._moveList = new List<PokeMove>();
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}