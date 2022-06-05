// https://www.pokemon.com/us/pokedex/447

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Riolu : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Riolu()); }
        }
        #endregion
        
        #region Constructors
        private Riolu()
            : base(
                447,
                "Riolu",
                "Riolu",
                TypeFighting.Instance,
                7,
                202,
                "Emanation Pokémon",
                "Pokémon Émanation",
                "It can use waves called auras to gauge how others are feeling. These same waves can also tell this Pokémon about the state of the environment.",
                "Il perçoit sous forme d’aura non seulement les sentiments des autres, mais aussi l’état de la nature.",
                40,
                70,
                40,
                35,
                40,
                60
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
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(HighJumpKick.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(CrossChop.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(MeteorMash.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SkyUppercut.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(ForcePalm.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(BulletPunch.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(CircleThrow.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}