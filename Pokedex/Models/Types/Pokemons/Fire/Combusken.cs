// https://www.pokemon.com/us/pokedex/256

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Combusken : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Combusken()); }
        }
        #endregion
        
        #region Constructors
        private Combusken()
            : base(
                256,
                "Combusken",
                "Galifeu",
                TypeFire.Instance,
                TypeFighting.Instance,
                9,
                195,
                "Young Fowl Pokémon",
                "Pokémon Poulet",
                "Combusken battles with the intensely hot flames it spews from its beak and with outstandingly destructive kicks. This Pokémon’s cry is very loud and distracting.",
                "Galifeu combat grâce aux flammes ardentes qu’il crache de son bec et à ses coups de pied destructeurs. Le cri de ce Pokémon est très puissant et très gênant pour l’adversaire.",
                60,
                85,
                60,
                85,
                60,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SkyUppercut.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}