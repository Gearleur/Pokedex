// https://www.pokemon.com/us/pokedex/366

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Clamperl : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Clamperl()); }
        }
        #endregion
        
        #region Constructors
        private Clamperl()
            : base(
                366,
                "Clamperl",
                "Coquiperl",
                TypeWater.Instance,
                4,
                525,
                "Bivalve Pokémon",
                "Pokémon Bivalve",
                "Clamperl’s pearls are exceedingly precious. They can be more than 10 times as costly as Shellder’s pearls.",
                "La perle de Coquiperl est tellement précieuse qu’elle peut valoir plus de dix fois la valeur de celle de Kokiyas.",
                35,
                64,
                85,
                74,
                55,
                32
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Clamp.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
        }
        #endregion
    }
}