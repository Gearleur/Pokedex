// https://www.pokemon.com/us/pokedex/856

using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Hatenna : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hatenna()); }
        }
        #endregion
        
        #region Constructors
        private Hatenna()
            : base(
                856,
                "Hatenna",
                "Bibichut",
                TypePsy.Instance,
                4,
                34,
                "Calm Pokémon",
                "Pokémon Calme",
                "If this Pokémon senses a strong emotion, it will run away as fast as it can. It prefers areas without people.",
                "Il aime les lieux inhabités. S’il perçoit des émotions trop fortes, il s’enfuit aussi vite que possible.",
                42,
                30,
                45,
                56,
                53,
                39
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
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Nuzzle.Instance);
            this._moveList.Add(ExpandingForce.Instance);
        }
        #endregion
    }
}