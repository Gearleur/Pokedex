// https://www.pokemon.com/us/pokedex/817

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Drizzile : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Drizzile()); }
        }
        #endregion
        
        #region Constructors
        private Drizzile()
            : base(
                817,
                "Drizzile",
                "Arrozard",
                TypeWater.Instance,
                7,
                115,
                "Water Lizard Pokémon",
                "Pokémon Lézard’Eau",
                "Highly intelligent but also very lazy, it keeps enemies out of its territory by laying traps everywhere.",
                "Paresseux, mais malin, il parsème son territoire de pièges pour empêcher ses ennemis d’y pénétrer.",
                65,
                60,
                55,
                95,
                55,
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
            this._moveList.Add(Round.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}