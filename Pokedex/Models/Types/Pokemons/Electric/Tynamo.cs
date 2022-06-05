// https://www.pokemon.com/us/pokedex/602

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Tynamo : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Tynamo()); }
        }
        #endregion
        
        #region Constructors
        private Tynamo()
            : base(
                602,
                "Tynamo",
                "Anchwatt",
                TypeElectric.Instance,
                2,
                3,
                "EleFish Pokémon",
                "Pokémon Électrophore",
                "One alone can emit only a trickle of electricity, so a group of them gathers to unleash a powerful electric shock.",
                "Tout seul, il ne dégage pas beaucoup d’électricité. Mais un banc d’Anchwatt produit des décharges surpuissantes.",
                35,
                55,
                40,
                45,
                40,
                60
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
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(ChargeBeam.Instance);
        }
        #endregion
    }
}