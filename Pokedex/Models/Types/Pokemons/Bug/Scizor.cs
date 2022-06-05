// https://www.pokemon.com/us/pokedex/212

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Scizor : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Scizor()); }
        }
        #endregion
        
        #region Constructors
        private Scizor()
            : base(
                212,
                "Scizor",
                "Cizayox",
                TypeBug.Instance,
                TypeSteel.Instance,
                18,
                1180,
                "Pincer Pokémon",
                "Pokémon Pince",
                "Though its body is slim, Scizor has tremendous attacking power. Even Scizor’s muscles are made of metal.",
                "Malgré son corps fin, sa puissance de frappe est prodigieuse, car même ses muscles sont composés de métal.",
                70,
                130,
                100,
                55,
                80,
                65
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(BulletPunch.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}