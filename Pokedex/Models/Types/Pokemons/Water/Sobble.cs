// https://www.pokemon.com/us/pokedex/816

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Sobble : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sobble()); }
        }
        #endregion
        
        #region Constructors
        private Sobble()
            : base(
                816,
                "Sobble",
                "Larméléon",
                TypeWater.Instance,
                3,
                40,
                "Water Lizard Pokémon",
                "Pokémon Lézard’Eau",
                "When it gets wet, its skin changes color, and this Pokémon becomes invisible as if it were camouflaged.",
                "Sa peau change de couleur et le rend invisible quand elle est mouillée, comme un camouflage.",
                50,
                40,
                40,
                70,
                40,
                70
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}