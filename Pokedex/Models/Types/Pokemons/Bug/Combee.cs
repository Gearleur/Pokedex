// https://www.pokemon.com/us/pokedex/415

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Combee : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Combee()); }
        }
        #endregion
        
        #region Constructors
        private Combee()
            : base(
                415,
                "Combee",
                "Apitrini",
                TypeBug.Instance,
                TypeFlying.Instance,
                3,
                55,
                "Tiny Bee Pokémon",
                "Pokémon Miniabeille",
                "It ceaselessly gathers nectar from sunrise to sundown, all for the sake of Vespiquen and the swarm.",
                "Du lever du soleil à la tombée de la nuit, il récolte du nectar pour Apireine et sa colonie.",
                30,
                30,
                42,
                30,
                42,
                70
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
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}