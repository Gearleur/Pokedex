// https://www.pokemon.com/us/pokedex/374

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Beldum : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Beldum()); }
        }
        #endregion
        
        #region Constructors
        private Beldum()
            : base(
                374,
                "Beldum",
                "Terhal",
                TypeSteel.Instance,
                TypePsy.Instance,
                6,
                952,
                "Iron Ball Pokémon",
                "Pokémon Boulefer",
                "The cells in this Pokémon’s body are composed of magnetic material. Instead of blood, magnetic forces flow through Beldum’s body.",
                "Les cellules de son corps sont composées d’aimants. Une force magnétique coule dans ses veines à la place du sang.",
                40,
                55,
                80,
                35,
                60,
                30
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}