// https://www.pokemon.com/us/pokedex/876

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class IndeedeeMale : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new IndeedeeMale()); }
        }
        #endregion
        
        #region Constructors
        private IndeedeeMale()
            : base(
                876,
                "Indeedee",
                "Wimessir",
                TypePsy.Instance,
                TypeNormal.Instance,
                9,
                280,
                "Emotion Pokémon",
                "Pokémon Émotion",
                "Through its horns, it can pick up on the emotions of creatures around it. Positive emotions are the source of its strength.",
                "Avec ses cornes, il peut percevoir les émotions des êtres vivants alentour. Celles qui sont positives lui servent de source d’énergie.",
                60,
                65,
                55,
                105,
                95,
                95
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
            this._moveList.Add(PayDay.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}