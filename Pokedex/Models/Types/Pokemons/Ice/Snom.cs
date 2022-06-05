// https://www.pokemon.com/us/pokedex/872

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Snom : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Snom()); }
        }
        #endregion
        
        #region Constructors
        private Snom()
            : base(
                872,
                "Snom",
                "Frissonille",
                TypeIce.Instance,
                TypeBug.Instance,
                3,
                38,
                "Worm Pokémon",
                "Pokémon Ver",
                "It eats snow that piles up on the ground. The more snow it eats, the bigger and more impressive the spikes on its back grow.",
                "Il se nourrit de la neige entassée sur le sol. Plus il en mange, plus les épines sur son dos grandissent.",
                30,
                25,
                35,
                45,
                30,
                20
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
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}