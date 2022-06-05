// https://www.pokemon.com/us/pokedex/790

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Cosmoem : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cosmoem()); }
        }
        #endregion
        
        #region Constructors
        private Cosmoem()
            : base(
                790,
                "Cosmoem",
                "Cosmovum",
                TypePsy.Instance,
                1,
                9999,
                "Protostar Pokémon",
                "Pokémon Proto-Étoile",
                "It sucks in dust from the air at an astounding rate, frantically building up energy within its core as preparation for evolution.",
                "Il aspire avec force la poussière de l’atmosphère et travaille sans relâche pour produire dans son noyau l’énergie nécessaire à son évolution.",
                43,
                29,
                131,
                29,
                131,
                37
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
        }
        #endregion
    }
}