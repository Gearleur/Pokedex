// https://www.pokemon.com/us/pokedex/129

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Magikarp : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magikarp()); }
        }
        #endregion
        
        #region Constructors
        private Magikarp()
            : base(
                129,
                "Magikarp",
                "Magicarpe",
                TypeWater.Instance,
                9,
                100,
                "Fish Pokémon",
                "Pokémon Poisson",
                "This weak and pathetic Pokémon gets easily pushed along rivers when there are strong currents.",
                "Ce Pokémon est si faible que, dans les eaux à forts courants, il se contente de se laisser porter lamentablement.",
                20,
                10,
                55,
                15,
                20,
                80
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Bounce.Instance);
        }
        #endregion
    }
}