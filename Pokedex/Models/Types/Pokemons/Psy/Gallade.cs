// https://www.pokemon.com/us/pokedex/475

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Gallade : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Gallade()); }
        }
        #endregion
        
        #region Constructors
        private Gallade()
            : base(
                475,
                "Gallade",
                "Gallame",
                TypePsy.Instance,
                TypeFighting.Instance,
                16,
                520,
                "Blade Pokémon",
                "Pokémon Lame",
                "Sharply attuned to others’ wishes for help, this Pokémon seeks out those in need and aids them in battle.",
                "Ses sens aiguisés lui indiquent lorsque quelqu’un est en danger. Il accourt alors à la rescousse.",
                68,
                125,
                65,
                65,
                115,
                80
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}