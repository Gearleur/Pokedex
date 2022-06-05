// https://www.pokemon.com/us/pokedex/388

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Grotle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Grotle()); }
        }
        #endregion
        
        #region Constructors
        private Grotle()
            : base(
                388,
                "Grotle",
                "Boskara",
                TypeGrass.Instance,
                11,
                970,
                "Grove Pokémon",
                "Pokémon Bosquet",
                "It knows where pure water wells up. It carries fellow Pokémon there on its back.",
                "Il sait d’instinct où trouver une source d’eau pure. Il y transporte d’autres Pokémon sur son dos.",
                75,
                89,
                85,
                55,
                65,
                36
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(RazorLeaf.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(GrassPledge.Instance);
        }
        #endregion
    }
}