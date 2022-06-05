// https://www.pokemon.com/us/pokedex/835

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Yamper : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Yamper()); }
        }
        #endregion
        
        #region Constructors
        private Yamper()
            : base(
                835,
                "Yamper",
                "Voltoutou",
                TypeElectric.Instance,
                3,
                135,
                "Puppy Pokémon",
                "Pokémon Chiot",
                "This gluttonous Pokémon only assists people with their work because it wants treats. As it runs, it crackles with electricity.",
                "Ce glouton assiste les humains dans leur travail en échange de friandises. Il court sans arrêt, le corps enveloppé d’électricité.",
                59,
                45,
                50,
                40,
                50,
                26
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
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Spark.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(Nuzzle.Instance);
            this._moveList.Add(RisingVoltage.Instance);
        }
        #endregion
    }
}