// https://www.pokemon.com/us/pokedex/842

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Appletun : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Appletun()); }
        }
        #endregion
        
        #region Constructors
        private Appletun()
            : base(
                842,
                "Appletun",
                "Dratatin",
                TypeGrass.Instance,
                TypeDragon.Instance,
                4,
                130,
                "Apple Nectar Pokémon",
                "Pokémon Jus Pomme",
                "Its body is covered in sweet nectar, and the skin on its back is especially yummy. Children used to have it as a snack.",
                "Son corps est recouvert de nectar. La peau de son dos, particulièrement sucrée, constituait jadis le goûter des enfants.",
                110,
                85,
                80,
                100,
                80,
                30
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(AppleAcid.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}