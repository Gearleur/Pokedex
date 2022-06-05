// https://www.pokemon.com/us/pokedex/771

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Pyukumuku : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pyukumuku()); }
        }
        #endregion
        
        #region Constructors
        private Pyukumuku()
            : base(
                771,
                "Pyukumuku",
                "Concombaffe",
                TypeWater.Instance,
                3,
                12,
                "Sea Cucumber Pokémon",
                "Pokémon Holothurie",
                "It’s covered in a slime that keeps its skin moist, allowing it to stay on land for days without drying up.",
                "Le fluide visqueux qui le recouvre garde sa peau bien hydratée, ce qui lui permet de vivre plusieurs jours sur la terre ferme sans se dessécher.",
                55,
                60,
                130,
                30,
                130,
                5
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