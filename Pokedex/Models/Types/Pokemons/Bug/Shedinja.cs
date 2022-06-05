// https://www.pokemon.com/us/pokedex/292

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Shedinja : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Shedinja()); }
        }
        #endregion
        
        #region Constructors
        private Shedinja()
            : base(
                292,
                "Shedinja",
                "Munja",
                TypeBug.Instance,
                TypeGhost.Instance,
                8,
                12,
                "Shed Pokémon",
                "Pokémon Exuvie",
                "A strange Pokémon—it flies without moving its wings, has a hollow shell for a body, and does not breathe.",
                "Cet étrange Pokémon, dont le corps est comme une coquille vide, ne respire pas et peut voler sans battre des ailes.",
                1,
                90,
                45,
                30,
                30,
                40
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(SkitterSmack.Instance);
            this._moveList.Add(Poltergeist.Instance);
        }
        #endregion
    }
}