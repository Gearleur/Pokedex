// https://www.pokemon.com/us/pokedex/499

using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Pignite : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pignite()); }
        }
        #endregion
        
        #region Constructors
        private Pignite()
            : base(
                499,
                "Pignite",
                "Grotichon",
                TypeFire.Instance,
                TypeFighting.Instance,
                10,
                555,
                "Fire Pig Pokémon",
                "Pokémon Cochon Feu",
                "When its internal fire flares up, its movements grow sharper and faster. When in trouble, it emits smoke.",
                "Quand le feu dans son corps s’embrase, sa vitesse et son agilité augmentent. En cas d’urgence, il crache de la fumée.",
                90,
                93,
                55,
                70,
                55,
                55
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
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Smog.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(ArmThrust.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}