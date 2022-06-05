// https://www.pokemon.com/us/pokedex/132

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Ditto : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Ditto()); }
        }
        #endregion
        
        #region Constructors
        private Ditto()
            : base(
                132,
                "Ditto",
                "Métamorph",
                TypeNormal.Instance,
                3,
                40,
                "Transform Pokémon",
                "Pokémon Morphing",
                "When it encounters another Ditto, it will move faster than normal to duplicate that opponent exactly.",
                "Quand il rencontre l’un de ses semblables, il s’agite avec plus de vivacité que d’habitude pour adopter exactement la même forme que lui.",
                48,
                48,
                48,
                48,
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
        }
        #endregion
    }
}