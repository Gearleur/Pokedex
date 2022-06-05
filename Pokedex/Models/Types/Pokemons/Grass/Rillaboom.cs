// https://www.pokemon.com/us/pokedex/812

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Rillaboom : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rillaboom()); }
        }
        #endregion
        
        #region Constructors
        private Rillaboom()
            : base(
                812,
                "Rillaboom",
                "Gorythmic",
                TypeGrass.Instance,
                21,
                900,
                "Drummer Pokémon",
                "Pokémon Batteur",
                "The one with the best drumming techniques becomes the boss of the troop. It has a gentle disposition and values harmony among its group.",
                "Celui qui possède les meilleures techniques de percussion devient le chef. De nature calme, il privilégie l’harmonie du groupe.",
                100,
                125,
                90,
                60,
                70,
                85
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(FrenzyPlant.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(Boomburst.Instance);
            this._moveList.Add(DarkestLariat.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(DrumBeating.Instance);
            this._moveList.Add(BranchPoke.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}