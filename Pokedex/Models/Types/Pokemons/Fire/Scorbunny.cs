// https://www.pokemon.com/us/pokedex/813

using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Scorbunny : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Scorbunny()); }
        }
        #endregion
        
        #region Constructors
        private Scorbunny()
            : base(
                813,
                "Scorbunny",
                "Flambino",
                TypeFire.Instance,
                3,
                45,
                "Rabbit Pokémon",
                "Pokémon Lapin",
                "It has special pads on the backs of its feet, and one on its nose. Once it’s raring to fight, these pads radiate tremendous heat.",
                "Quand il est prêt à se battre, la partie qui surmonte son museau ainsi que les coussinets de ses pattes postérieures émettent de la chaleur.",
                50,
                71,
                40,
                40,
                40,
                69
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
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(HighJumpKick.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BlazeKick.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(FirePledge.Instance);
        }
        #endregion
    }
}