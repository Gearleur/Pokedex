// https://www.pokemon.com/us/pokedex/661

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Fletchling : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Fletchling()); }
        }
        #endregion
        
        #region Constructors
        private Fletchling()
            : base(
                661,
                "Fletchling",
                "Passerouge",
                TypeNormal.Instance,
                TypeFlying.Instance,
                3,
                17,
                "Tiny Robin Pokémon",
                "Pokémon Rougegorge",
                "When this Pokémon gets excited, its body temperature increases sharply. If you touch a Fletchling with bare hands, you might get burned.",
                "Quand il est surexcité, sa température corporelle augmente d’un coup, à tel point qu’il est possible de se brûler en le touchant à mains nues.",
                45,
                50,
                43,
                40,
                38,
                62
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
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}