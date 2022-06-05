// https://www.pokemon.com/us/pokedex/789

using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Cosmog : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cosmog()); }
        }
        #endregion
        
        #region Constructors
        private Cosmog()
            : base(
                789,
                "Cosmog",
                "Cosmog",
                TypePsy.Instance,
                2,
                1,
                "Nebula Pokémon",
                "Pokémon Nébuleuse",
                "Cosmog is very curious but not very cautious, often placing itself in danger. If things start to look dicey, it teleports away.",
                "De nature curieuse et peu méfiante, il se retrouve souvent dans des situations dangereuses. Il peut se téléporter en cas de danger.",
                43,
                29,
                31,
                29,
                31,
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