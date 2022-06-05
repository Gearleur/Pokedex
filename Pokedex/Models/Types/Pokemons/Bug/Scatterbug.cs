// https://www.pokemon.com/us/pokedex/664

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Scatterbug : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Scatterbug()); }
        }
        #endregion
        
        #region Constructors
        private Scatterbug()
            : base(
                664,
                "Scatterbug",
                "Lépidonille",
                TypeBug.Instance,
                3,
                25,
                "Scatterdust Pokémon",
                "Pokémon Exhalécaille",
                "The powder that covers its body regulates its temperature, so it can live in any region or climate.",
                "La poudre qui recouvre son corps l’aide à réguler sa température. Il peut s’adapter à tous les climats.",
                38,
                35,
                40,
                27,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BugBite.Instance);
        }
        #endregion
    }
}