// https://www.pokemon.com/us/pokedex/808

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Meltan : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Meltan()); }
        }
        #endregion
        
        #region Constructors
        private Meltan()
            : base(
                808,
                "Meltan",
                "Meltan",
                TypeSteel.Instance,
                2,
                80,
                "Hex Nut Pokémon",
                "Pokémon Écrou",
                "They live as a group, but when the time comes, one strong Meltan will absorb all the others and evolve.",
                "Les Meltan vivent en groupe. Quand l’heure de l’évolution a sonné, le plus fort d’entre eux absorbe ses camarades pour changer de forme.",
                46,
                65,
                65,
                55,
                35,
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(ThunderShock.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}