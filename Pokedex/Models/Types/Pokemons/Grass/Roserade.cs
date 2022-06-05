// https://www.pokemon.com/us/pokedex/407

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Roserade : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Roserade()); }
        }
        #endregion
        
        #region Constructors
        private Roserade()
            : base(
                407,
                "Roserade",
                "Roserade",
                TypeGrass.Instance,
                TypePoison.Instance,
                9,
                145,
                "Bouquet Pokémon",
                "Pokémon Bouquet",
                "The poison in its right hand is quick acting. The poison in its left hand is slow acting. Both are life threatening.",
                "Sa main gauche administre un poison lent, et la droite, un poison foudroyant. Les deux peuvent être fatals.",
                60,
                70,
                65,
                125,
                105,
                90
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(PetalDance.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(LeafStorm.Instance);
            this._moveList.Add(PowerWhip.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(PetalBlizzard.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(GrassyGlide.Instance);
        }
        #endregion
    }
}