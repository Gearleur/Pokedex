// https://www.pokemon.com/us/pokedex/583

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Vanillish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vanillish()); }
        }
        #endregion
        
        #region Constructors
        private Vanillish()
            : base(
                583,
                "Vanillish",
                "Sorboul",
                TypeIce.Instance,
                11,
                410,
                "Icy Snow Pokémon",
                "Pokémon Grêle",
                "It blasts enemies with cold air reaching −148 degrees Fahrenheit, freezing them solid. But it spares their lives afterward—it’s a kind Pokémon.",
                "Bien qu’il gèle ses ennemis en soufflant de l’air à - 100 °C, sa gentillesse l’empêche de leur ôter la vie.",
                51,
                65,
                65,
                80,
                75,
                59
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
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(FrostBreath.Instance);
        }
        #endregion
    }
}