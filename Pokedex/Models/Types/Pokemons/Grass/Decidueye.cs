// https://www.pokemon.com/us/pokedex/724

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Decidueye : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Decidueye()); }
        }
        #endregion
        
        #region Constructors
        private Decidueye()
            : base(
                724,
                "Decidueye",
                "Archéduc",
                TypeGrass.Instance,
                TypeGhost.Instance,
                16,
                366,
                "Arrow Quill Pokémon",
                "Pokémon Plumeflèche",
                "In a tenth of a second, it can nock and fire an arrow quill, piercing an opponent’s weak point before they notice what’s happening.",
                "Il décoche ses plumes acérées en un dixième de seconde. Sa victime n’a pas le temps de le voir agir qu’elle est déjà grièvement touchée.",
                78,
                107,
                75,
                100,
                100,
                70
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(FrenzyPlant.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(SpiritShackle.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(Poltergeist.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}