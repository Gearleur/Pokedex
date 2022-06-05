// https://www.pokemon.com/us/pokedex/770

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
    internal class Palossand : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Palossand()); }
        }
        #endregion
        
        #region Constructors
        private Palossand()
            : base(
                770,
                "Palossand",
                "Trépassable",
                TypeGhost.Instance,
                TypeGround.Instance,
                13,
                2500,
                "Sand Castle Pokémon",
                "Pokémon Châtod’Sable",
                "This Pokémon lives on beaches, but it hates water. Palossand can’t maintain its castle-like shape if it gets drenched by a heavy rain.",
                "Bien qu’il déteste l’eau, il vit sur les plages. Quand la pluie s’abat sur lui, il est incapable de conserver sa forme de château de sable.",
                85,
                75,
                110,
                100,
                75,
                35
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
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(TerrainPulse.Instance);
            this._moveList.Add(Poltergeist.Instance);
            this._moveList.Add(ScorchingSands.Instance);
        }
        #endregion
    }
}