// https://www.pokemon.com/us/pokedex/492

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class ShayminLand : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new ShayminLand()); }
        }
        #endregion
        
        #region Constructors
        private ShayminLand()
            : base(
                492,
                "Shaymin",
                "Shaymin",
                TypeGrass.Instance,
                2,
                21,
                "Gratitude Pokémon",
                "Pokémon Gratitude",
                "The blooming of Gracidea flowers confers the power of flight upon it. Feelings of gratitude are the message it delivers.",
                "Il prend son essor pour répandre la gratitude lorsque les Gracidées fleurissent.",
                100,
                100,
                100,
                100,
                100,
                100
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(SeedFlare.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}