// https://www.pokemon.com/us/pokedex/202

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Wobbuffet : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wobbuffet()); }
        }
        #endregion
        
        #region Constructors
        private Wobbuffet()
            : base(
                202,
                "Wobbuffet",
                "Qulbutoké",
                TypePsy.Instance,
                13,
                285,
                "Patient Pokémon",
                "Pokémon Patient",
                "To keep its pitch-black tail hidden, it lives quietly in the darkness. It is never first to attack.",
                "Il vit discrètement dans l’obscurité pour cacher sa queue noire. Il n’attaque jamais en premier.",
                190,
                33,
                58,
                33,
                58,
                33
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