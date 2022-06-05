// https://www.pokemon.com/us/pokedex/169

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Crobat : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Crobat()); }
        }
        #endregion
        
        #region Constructors
        private Crobat()
            : base(
                169,
                "Crobat",
                "Nostenfer",
                TypePoison.Instance,
                TypeFlying.Instance,
                18,
                750,
                "Bat Pokémon",
                "Pokémon Chovsouris",
                "This Pokémon flaps its four wings skillfully. Crobat can fly through cramped caves without needing to slow down.",
                "Il vole en contrôlant librement ses quatre ailes et peut se déplacer sans avoir besoin de ralentir, même dans les grottes étroites.",
                85,
                90,
                80,
                70,
                80,
                130
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
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}