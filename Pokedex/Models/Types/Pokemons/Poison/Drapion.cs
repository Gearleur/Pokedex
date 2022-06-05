// https://www.pokemon.com/us/pokedex/452

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Drapion : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Drapion()); }
        }
        #endregion
        
        #region Constructors
        private Drapion()
            : base(
                452,
                "Drapion",
                "Drascore",
                TypePoison.Instance,
                TypeDark.Instance,
                13,
                615,
                "Ogre Scorpion Pokémon",
                "Pokémon Scorpogre",
                "It’s so vicious that it’s called the Sand Demon. Yet when confronted by Hippowdon, Drapion keeps a low profile and will never pick a fight.",
                "Sa férocité lui a valu le surnom de « démon du désert », mais face à un Hippodocus, il est parfaitement docile et évite de le provoquer.",
                70,
                90,
                110,
                60,
                75,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}