// https://www.pokemon.com/us/pokedex/665

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Spewpa : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Spewpa()); }
        }
        #endregion
        
        #region Constructors
        private Spewpa()
            : base(
                665,
                "Spewpa",
                "Pérégrain",
                TypeBug.Instance,
                3,
                84,
                "Scatterdust Pokémon",
                "Pokémon Exhalécaille",
                "The beaks of bird Pokémon can’t begin to scratch its stalwart body. To defend itself, it spews powder.",
                "Même les becs acérés des Pokémon Oiseaux ne parviennent pas à meurtrir son corps très dur. Il se défend en crachant de la poudre.",
                45,
                22,
                60,
                27,
                30,
                29
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
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Electroweb.Instance);
        }
        #endregion
    }
}