// https://www.pokemon.com/us/pokedex/107

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Hitmonchan : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hitmonchan()); }
        }
        #endregion
        
        #region Constructors
        private Hitmonchan()
            : base(
                107,
                "Hitmonchan",
                "Tygnon",
                TypeFighting.Instance,
                14,
                502,
                "Punching Pokémon",
                "Pokémon Puncheur",
                "Its punches slice the air. However, it seems to need a short break after fighting for three minutes.",
                "Ses poings fendent l’air, mais il se fatigue au bout de trois minutes à enchaîner les coups.",
                50,
                105,
                79,
                35,
                110,
                76
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
            this._moveList.Add(CometPunch.Instance);
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(DizzyPunch.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MachPunch.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SkyUppercut.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(BulletPunch.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(ThroatChop.Instance);
        }
        #endregion
    }
}