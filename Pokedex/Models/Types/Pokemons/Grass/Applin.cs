// https://www.pokemon.com/us/pokedex/840

using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Applin : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Applin()); }
        }
        #endregion
        
        #region Constructors
        private Applin()
            : base(
                840,
                "Applin",
                "Verpom",
                TypeGrass.Instance,
                TypeDragon.Instance,
                2,
                5,
                "Apple Core Pokémon",
                "Pokémon Nid Pomme",
                "As soon as it’s born, it burrows into an apple. Not only does the apple serve as its food source, but the flavor of the fruit determines its evolution.",
                "À la naissance, il s’installe dans une pomme et grandit en se nourrissant de sa chair. Son évolution dépend de la saveur du fruit.",
                40,
                40,
                80,
                40,
                40,
                20
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
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}