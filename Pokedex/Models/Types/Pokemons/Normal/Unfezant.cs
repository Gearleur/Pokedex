// https://www.pokemon.com/us/pokedex/521

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Unfezant : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Unfezant()); }
        }
        #endregion
        
        #region Constructors
        private Unfezant()
            : base(
                521,
                "Unfezant",
                "Déflaisan",
                TypeNormal.Instance,
                TypeFlying.Instance,
                12,
                290,
                "Proud Pokémon",
                "Pokémon Fier",
                "This Pokémon is intelligent and intensely proud. People will sit up and take notice if you become the Trainer of one.",
                "Ce Pokémon est aussi intelligent qu’il est arrogant. Les Dresseurs de Déflaisan sont tenus en haute estime.",
                80,
                115,
                80,
                65,
                55,
                93
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}