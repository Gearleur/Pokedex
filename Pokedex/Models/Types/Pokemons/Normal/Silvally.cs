// https://www.pokemon.com/us/pokedex/773

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Silvally : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Silvally()); }
        }
        #endregion
        
        #region Constructors
        private Silvally()
            : base(
                773,
                "Silvally",
                "Silvallié",
                TypeNormal.Instance,
                23,
                1005,
                "Synthetic Pokémon",
                "Pokémon Multigénome",
                "The final factor needed to release this Pokémon’s true power was a strong bond with a Trainer it trusts.",
                "La relation de confiance qui le lie à son Dresseur est le facteur décisif qui lui permet de libérer tout son potentiel.",
                95,
                95,
                95,
                95,
                95,
                95
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(MultiAttack.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}