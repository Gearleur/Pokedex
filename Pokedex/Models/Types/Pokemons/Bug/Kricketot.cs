// https://www.pokemon.com/us/pokedex/401

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Kricketot : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Kricketot()); }
        }
        #endregion
        
        #region Constructors
        private Kricketot()
            : base(
                401,
                "Kricketot",
                "Crikzik",
                TypeBug.Instance,
                3,
                22,
                "Cricket Pokémon",
                "Pokémon Criquet",
                "When its antennae hit each other, it sounds like the music of a xylophone.",
                "Quand ses antennes s’entrechoquent, elles laissent échapper un bruit de xylophone.",
                37,
                25,
                41,
                25,
                41,
                25
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
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(StruggleBug.Instance);
        }
        #endregion
    }
}