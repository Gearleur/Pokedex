// https://www.pokemon.com/us/pokedex/769

using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Sandygast : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sandygast()); }
        }
        #endregion
        
        #region Constructors
        private Sandygast()
            : base(
                769,
                "Sandygast",
                "Bacabouh",
                TypeGhost.Instance,
                TypeGround.Instance,
                5,
                700,
                "Sand Heap Pokémon",
                "Pokémon Pâtéd’Sable",
                "Sandygast mainly inhabits beaches. It takes control of anyone who puts their hand into its mouth, forcing them to make its body bigger.",
                "Il vit principalement sur les plages de sable et peut agrandir son corps en prenant le contrôle des gens qui mettent la main dans sa gueule.",
                55,
                55,
                80,
                70,
                45,
                15
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
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Poltergeist.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}