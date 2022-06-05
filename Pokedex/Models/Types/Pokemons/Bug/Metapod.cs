// https://www.pokemon.com/us/pokedex/11

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Metapod : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Metapod()); }
        }
        #endregion
        
        #region Constructors
        private Metapod()
            : base(
                11,
                "Metapod",
                "Chrysacier",
                TypeBug.Instance,
                7,
                99,
                "Cocoon Pokémon",
                "Pokémon Cocon",
                "Even though it is encased in a sturdy shell, the body inside is tender. It can’t withstand a harsh attack.",
                "Bien que son corps soit entouré d’une carapace solide, l’intérieur est si mou qu’il ne résisterait pas à une attaque violente.",
                50,
                20,
                55,
                25,
                25,
                30
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