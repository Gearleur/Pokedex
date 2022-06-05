// https://www.pokemon.com/us/pokedex/302

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Sableye : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sableye()); }
        }
        #endregion
        
        #region Constructors
        private Sableye()
            : base(
                302,
                "Sableye",
                "Ténéfix",
                TypeDark.Instance,
                TypeGhost.Instance,
                5,
                110,
                "Darkness Pokémon",
                "Pokémon Obscurité",
                "It feeds on gemstone crystals. In darkness, its eyes sparkle with the glitter of jewels.",
                "Ce Pokémon se nourrit de pierres précieuses. Dans les ténèbres, ses yeux brillent du reflet des joyaux.",
                50,
                75,
                75,
                65,
                65,
                50
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
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(LashOut.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}