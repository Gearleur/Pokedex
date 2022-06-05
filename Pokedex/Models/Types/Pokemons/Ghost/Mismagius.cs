// https://www.pokemon.com/us/pokedex/429

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ghost
{
    internal class Mismagius : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Mismagius()); }
        }
        #endregion
        
        #region Constructors
        private Mismagius()
            : base(
                429,
                "Mismagius",
                "Magirêve",
                TypeGhost.Instance,
                9,
                44,
                "Magical Pokémon",
                "Pokémon Magique",
                "Its muttered curses can cause awful headaches or terrifying visions that torment others.",
                "Il susurre des malédictions pour tourmenter ses ennemis et leur infliger de terribles migraines ou des hallucinations terrifiantes.",
                60,
                60,
                60,
                105,
                105,
                105
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
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}