// https://www.pokemon.com/us/pokedex/845

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Flying
{
    internal class Cramorant : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cramorant()); }
        }
        #endregion
        
        #region Constructors
        private Cramorant()
            : base(
                845,
                "Cramorant",
                "Nigosier",
                TypeFlying.Instance,
                TypeWater.Instance,
                8,
                180,
                "Gulp Pokémon",
                "Pokémon Avaltouron",
                "This hungry Pokémon swallows Arrokuda whole. Occasionally, it makes a mistake and tries to swallow a Pokémon other than its preferred prey.",
                "Très glouton, il avale les Embrochet d’une seule bouchée, mais il lui arrive de se tromper et de tenter de gober un autre Pokémon.",
                70,
                85,
                55,
                85,
                95,
                85
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(DrillPeck.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}