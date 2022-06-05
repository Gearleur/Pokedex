// https://www.pokemon.com/us/pokedex/748

using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Toxapex : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Toxapex()); }
        }
        #endregion
        
        #region Constructors
        private Toxapex()
            : base(
                748,
                "Toxapex",
                "Prédastérie",
                TypePoison.Instance,
                TypeWater.Instance,
                7,
                145,
                "Brutal Star Pokémon",
                "Pokémon Cruel",
                "Within the poison sac in its body is a poison so toxic that Pokémon as large as Wailord will still be suffering three days after it first takes effect.",
                "Sa poche à venin interne regorge d’un poison si violent que même un Wailord en souffrirait pendant trois jours entiers.",
                50,
                63,
                152,
                53,
                142,
                35
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
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(SpikeCannon.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}