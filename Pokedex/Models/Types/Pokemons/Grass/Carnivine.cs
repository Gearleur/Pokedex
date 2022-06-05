// https://www.pokemon.com/us/pokedex/455

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Carnivine : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Carnivine()); }
        }
        #endregion
        
        #region Constructors
        private Carnivine()
            : base(
                455,
                "Carnivine",
                "Vortente",
                TypeGrass.Instance,
                14,
                270,
                "Bug Catcher Pokémon",
                "Pokémon Chopinsecte",
                "It binds itself to trees in marshes. It attracts prey with its sweet-smelling drool and gulps them down.",
                "Il s’accroche aux arbres des marais et attire ses proies avec sa salive à l’odeur enivrante.",
                74,
                100,
                72,
                90,
                72,
                46
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(VineWhip.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(LeafTornado.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(ThroatChop.Instance);
        }
        #endregion
    }
}