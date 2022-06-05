// https://www.pokemon.com/us/pokedex/868

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Milcery : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Milcery()); }
        }
        #endregion
        
        #region Constructors
        private Milcery()
            : base(
                868,
                "Milcery",
                "Crèmy",
                TypeFairy.Instance,
                2,
                3,
                "Cream Pokémon",
                "Pokémon Crème",
                "They say that any patisserie visited by Milcery is guaranteed success and good fortune.",
                "Les pâtissiers connaissent tous ce vieil adage : Quand Crèmy apparaît, le succès est assuré.",
                45,
                40,
                40,
                50,
                61,
                34
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}