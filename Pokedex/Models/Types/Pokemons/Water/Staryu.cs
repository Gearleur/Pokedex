// https://www.pokemon.com/us/pokedex/120

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Staryu : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Staryu()); }
        }
        #endregion
        
        #region Constructors
        private Staryu()
            : base(
                120,
                "Staryu",
                "Stari",
                TypeWater.Instance,
                8,
                345,
                "Star Shape Pokémon",
                "Pokémon Étoile",
                "Fish Pokémon nibble at it, but Staryu isn’t bothered. Its body regenerates quickly, even if part of it is completely torn off.",
                "Il ne se soucie guère des Pokémon poissons qui viennent le grignoter, car même si son corps est déchiqueté, il se régénère aussitôt.",
                30,
                45,
                55,
                70,
                55,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}