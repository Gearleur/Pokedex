// https://www.pokemon.com/us/pokedex/556

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Maractus : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Maractus()); }
        }
        #endregion
        
        #region Constructors
        private Maractus()
            : base(
                556,
                "Maractus",
                "Maracachi",
                TypeGrass.Instance,
                10,
                280,
                "Cactus Pokémon",
                "Pokémon Cactus",
                "Once each year, this Pokémon scatters its seeds. They’re jam-packed with nutrients, making them a precious food source out in the desert.",
                "Il sème les graines de ses fleurs une fois par an. Celles-ci abondent en nutriments et représentent une denrée précieuse dans le désert.",
                75,
                86,
                67,
                106,
                67,
                60
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
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(NeedleArm.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}