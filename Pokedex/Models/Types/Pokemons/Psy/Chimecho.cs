// https://www.pokemon.com/us/pokedex/358

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Chimecho : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Chimecho()); }
        }
        #endregion
        
        #region Constructors
        private Chimecho()
            : base(
                358,
                "Chimecho",
                "Éoko",
                TypePsy.Instance,
                6,
                10,
                "Wind Chime Pokémon",
                "Pokémon Carillon",
                "In high winds, Chimecho cries as it hangs from a tree branch or the eaves of a building using a suction cup on its head. This Pokémon plucks berries with its long tail and eats them.",
                "Lorsqu’il y a beaucoup de vent, Éoko pousse des cris, accroché à une branche ou à un auvent par une ventouse placée sur sa tête. Ce Pokémon attrape des Baies avec sa longue queue pour les manger.",
                75,
                50,
                80,
                95,
                90,
                65
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Synchronoise.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}