// https://www.pokemon.com/us/pokedex/240

using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Magby : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magby()); }
        }
        #endregion
        
        #region Constructors
        private Magby()
            : base(
                240,
                "Magby",
                "Magby",
                TypeFire.Instance,
                7,
                214,
                "Live Coal Pokémon",
                "Pokémon Charbon",
                "This Pokémon makes its home near volcanoes. At the end of the day, Magby soaks in magma, resting and recovering from the day’s fatigue.",
                "Il vit près des volcans. À la fin de la journée, il se détend dans un bon bain de magma.",
                45,
                75,
                37,
                70,
                55,
                83
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
            this._moveList.Add(KarateChop.Instance);
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Smog.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MachPunch.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(CrossChop.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(LavaPlume.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}