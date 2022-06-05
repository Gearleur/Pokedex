// https://www.pokemon.com/us/pokedex/235

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Smeargle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Smeargle()); }
        }
        #endregion
        
        #region Constructors
        private Smeargle()
            : base(
                235,
                "Smeargle",
                "Queulorior",
                TypeNormal.Instance,
                12,
                580,
                "Painter Pokémon",
                "Pokémon Peintre",
                "The fluid of Smeargle’s tail secretions changes in the intensity of its hue as the Pokémon’s emotions change.",
                "Il se sert du liquide qui sort de sa queue pour dessiner sa marque. Ses fans s’arrachent ses plus beaux tracés à prix d’or.",
                55,
                20,
                35,
                20,
                45,
                75
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