// https://www.pokemon.com/us/pokedex/494

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Victini : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Victini()); }
        }
        #endregion
        
        #region Constructors
        private Victini()
            : base(
                494,
                "Victini",
                "Victini",
                TypePsy.Instance,
                TypeFire.Instance,
                4,
                40,
                "Victory Pokémon",
                "Pokémon Victoire",
                "When it shares the infinite energy it creates, that being’s entire body will be overflowing with power.",
                "L’énergie sans limites qu’il produit donne une force incroyable à ceux qui entrent en contact avec elle.",
                100,
                100,
                100,
                100,
                100,
                100
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
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Inferno.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(SearingShot.Instance);
            this._moveList.Add(VCreate.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}