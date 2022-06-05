// https://www.pokemon.com/us/pokedex/651

using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Quilladin : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Quilladin()); }
        }
        #endregion
        
        #region Constructors
        private Quilladin()
            : base(
                651,
                "Quilladin",
                "Boguérisse",
                TypeGrass.Instance,
                7,
                290,
                "Spiny Armor Pokémon",
                "Pokémon Épinarmure",
                "They strengthen their lower bodies by running into one another. They are very kind and won’t start fights.",
                "Il renforce ses membres inférieurs en se ruant violemment sur ses congénères. Naturellement paisible, il ne provoque jamais un combat.",
                61,
                78,
                95,
                56,
                58,
                57
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
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(NeedleArm.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}