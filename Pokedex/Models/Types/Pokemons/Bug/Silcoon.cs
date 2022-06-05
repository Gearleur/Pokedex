// https://www.pokemon.com/us/pokedex/266

using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Silcoon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Silcoon()); }
        }
        #endregion
        
        #region Constructors
        private Silcoon()
            : base(
                266,
                "Silcoon",
                "Armulys",
                TypeBug.Instance,
                6,
                100,
                "Cocoon Pokémon",
                "Pokémon Cocon",
                "Silcoon was thought to endure hunger and not consume anything before its evolution. However, it is now thought that this Pokémon slakes its thirst by drinking rainwater that collects on its silk.",
                "On pensait qu’Armulys pouvait résister à la faim et ne consommait rien avant son évolution. On sait maintenant que ce Pokémon étanche sa soif en récupérant l’eau de pluie déposée sur sa soie.",
                50,
                35,
                55,
                25,
                25,
                15
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