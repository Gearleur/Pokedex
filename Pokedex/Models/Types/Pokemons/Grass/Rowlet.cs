// https://www.pokemon.com/us/pokedex/722

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Rowlet : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Rowlet()); }
        }
        #endregion
        
        #region Constructors
        private Rowlet()
            : base(
                722,
                "Rowlet",
                "Brindibou",
                TypeGrass.Instance,
                TypeFlying.Instance,
                3,
                15,
                "Grass Quill Pokémon",
                "Pokémon Plumefeuille",
                "During the day, it builds up energy via photosynthesis. At night, it flies silently through the sky, on the prowl for prey.",
                "Pendant la journée, il emmagasine de l’énergie par photosynthèse. La nuit, il plane silencieusement à la recherche de proies.",
                68,
                55,
                55,
                50,
                50,
                42
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
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(GrassPledge.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}