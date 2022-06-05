// https://www.pokemon.com/us/pokedex/803

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Poipole : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Poipole()); }
        }
        #endregion
        
        #region Constructors
        private Poipole()
            : base(
                803,
                "Poipole",
                "Vémini",
                TypePoison.Instance,
                6,
                18,
                "Poison Pin Pokémon",
                "Pokémon Vénépic",
                "An Ultra Beast that lives in a different world, it cackles wildly as it sprays its opponents with poison from the needles on its head.",
                "Cette Ultra-Chimère venue d’un autre monde ricane lorsqu’elle asperge ses proies de venin grâce au dard qu’elle a sur la tête.",
                67,
                73,
                67,
                73,
                67,
                73
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(FellStinger.Instance);
        }
        #endregion
    }
}