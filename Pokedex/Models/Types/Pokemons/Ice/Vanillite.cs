// https://www.pokemon.com/us/pokedex/582

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Vanillite : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vanillite()); }
        }
        #endregion
        
        #region Constructors
        private Vanillite()
            : base(
                582,
                "Vanillite",
                "Sorbébé",
                TypeIce.Instance,
                4,
                57,
                "Fresh Snow Pokémon",
                "Pokémon Poudreuse",
                "Supposedly, this Pokémon was born from an icicle. It spews out freezing air at −58 degrees Fahrenheit to make itself more comfortable.",
                "On raconte qu’il est né de stalactites. Il gèle les alentours en soufflant de l’air à - 50 °C pour améliorer son confort.",
                36,
                50,
                50,
                65,
                60,
                44
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
            this._moveList.Add(PowderSnow.Instance);
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
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(IcicleCrash.Instance);
        }
        #endregion
    }
}