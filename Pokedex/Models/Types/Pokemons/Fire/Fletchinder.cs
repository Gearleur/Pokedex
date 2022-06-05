// https://www.pokemon.com/us/pokedex/662

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Fletchinder : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Fletchinder()); }
        }
        #endregion
        
        #region Constructors
        private Fletchinder()
            : base(
                662,
                "Fletchinder",
                "Braisillon",
                TypeFire.Instance,
                TypeFlying.Instance,
                7,
                160,
                "Ember Pokémon",
                "Pokémon Braise",
                "Fletchinder are exceedingly territorial and aggressive. These Pokémon fight among themselves over feeding grounds.",
                "De nature belliqueuse, il dispose d’un fort instinct territorial. Quand il chasse, il se dispute régulièrement les proies avec ses congénères.",
                62,
                73,
                55,
                56,
                52,
                84
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}