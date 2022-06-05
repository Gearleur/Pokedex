// https://www.pokemon.com/us/pokedex/201

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Unown : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Unown()); }
        }
        #endregion
        
        #region Constructors
        private Unown()
            : base(
                201,
                "Unown",
                "Zarbi",
                TypePsy.Instance,
                5,
                50,
                "Symbol Pokémon",
                "Pokémon Symbolique",
                "This Pokémon is shaped like ancient writing. It is a mystery as to which came first, the ancient writings or the various Unown. Research into this topic is ongoing but nothing is known.",
                "Ce Pokémon a la forme d’un caractère d’écriture antique. Personne ne sait si ces écritures antiques sont apparues avant les Zarbi ou le contraire. Des études sont en cours, mais aucun résultat n’a été annoncé.",
                48,
                72,
                48,
                72,
                48,
                48
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
            this._moveList.Add(HiddenPower.Instance);
        }
        #endregion
    }
}