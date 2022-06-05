// https://www.pokemon.com/us/pokedex/668

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Pyroar : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pyroar()); }
        }
        #endregion
        
        #region Constructors
        private Pyroar()
            : base(
                668,
                "Pyroar",
                "Némélios",
                TypeFire.Instance,
                TypeNormal.Instance,
                15,
                815,
                "Royal Pokémon",
                "Pokémon Royal",
                "The temperature of its breath is over 10,000 degrees Fahrenheit, but Pyroar doesn’t use it on its prey. This Pokémon prefers to eat raw meat.",
                "Son souffle enflammé atteint les 6 000 °C, mais il ne l’utilise jamais contre ses proies. Il préfère en effet la viande crue.",
                86,
                68,
                72,
                109,
                66,
                106
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
        }
        #endregion
    }
}