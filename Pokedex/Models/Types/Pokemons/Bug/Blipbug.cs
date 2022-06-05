// https://www.pokemon.com/us/pokedex/824

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Blipbug : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Blipbug()); }
        }
        #endregion
        
        #region Constructors
        private Blipbug()
            : base(
                824,
                "Blipbug",
                "Larvadar",
                TypeBug.Instance,
                4,
                80,
                "Larva Pokémon",
                "Pokémon Larve",
                "Often found in gardens, this Pokémon has hairs on its body that it uses to assess its surroundings.",
                "On le voit souvent dans les champs. Les poils de son corps lui servent à capter ce qu’il se passe autour de lui.",
                25,
                20,
                20,
                25,
                45,
                45
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
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}