// https://www.pokemon.com/us/pokedex/537

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Seismitoad : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Seismitoad()); }
        }
        #endregion
        
        #region Constructors
        private Seismitoad()
            : base(
                537,
                "Seismitoad",
                "Crapustule",
                TypeWater.Instance,
                TypeGround.Instance,
                15,
                620,
                "Vibration Pokémon",
                "Pokémon Vibration",
                "This Pokémon is popular among the elderly, who say the vibrations of its lumps are great for massages.",
                "Ce Pokémon est un excellent masseur grâce aux vibrations de ses pustules. Les personnes âgées l’apprécient particulièrement.",
                105,
                95,
                75,
                85,
                75,
                74
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}