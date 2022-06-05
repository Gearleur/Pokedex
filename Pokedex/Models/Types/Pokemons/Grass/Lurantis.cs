// https://www.pokemon.com/us/pokedex/754

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Lurantis : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Lurantis()); }
        }
        #endregion
        
        #region Constructors
        private Lurantis()
            : base(
                754,
                "Lurantis",
                "Floramantis",
                TypeGrass.Instance,
                9,
                185,
                "Bloom Sickle Pokémon",
                "Pokémon Fauch’Fleur",
                "The petals on this Pokémon’s arms are thin and super sharp, and they can fire laser beams if Lurantis gathers light first.",
                "Les pétales sur ses deux bras sont fins, mais très tranchants. Ils peuvent également absorber la lumière pour la renvoyer sous forme de laser.",
                70,
                105,
                90,
                80,
                90,
                45
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}