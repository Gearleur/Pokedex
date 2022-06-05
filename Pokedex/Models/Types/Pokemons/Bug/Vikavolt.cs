// https://www.pokemon.com/us/pokedex/738

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Vikavolt : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vikavolt()); }
        }
        #endregion
        
        #region Constructors
        private Vikavolt()
            : base(
                738,
                "Vikavolt",
                "Lucanon",
                TypeBug.Instance,
                TypeElectric.Instance,
                15,
                450,
                "Stag Beetle Pokémon",
                "Pokémon Scarabée",
                "If it carries a Charjabug to use as a spare battery, a flying Vikavolt can rapidly fire high-powered beams of electricity.",
                "S’il emporte un Chrysapile en tant que batterie de secours, il peut tirer une salve de rayons électriques extrêmement puissants en plein vol.",
                77,
                70,
                90,
                145,
                75,
                43
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
            this._moveList.Add(ViceGrip.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(RisingVoltage.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}