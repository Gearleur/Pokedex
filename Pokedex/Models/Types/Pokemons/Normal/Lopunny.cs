// https://www.pokemon.com/us/pokedex/428

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Lopunny : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Lopunny()); }
        }
        #endregion
        
        #region Constructors
        private Lopunny()
            : base(
                428,
                "Lopunny",
                "Lockpin",
                TypeNormal.Instance,
                12,
                333,
                "Rabbit Pokémon",
                "Pokémon Lapin",
                "Once hot seasons are over, Lopunny’s coat will be replaced with fur that holds a lot of insulating air in preparation for colder weather.",
                "À la fin de la saison chaude, il mue et se recouvre d’une fourrure épaisse et légère pour se préparer à affronter le froid hivernal.",
                65,
                76,
                84,
                54,
                96,
                105
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(JumpKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(HighJumpKick.Instance);
            this._moveList.Add(DizzyPunch.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}