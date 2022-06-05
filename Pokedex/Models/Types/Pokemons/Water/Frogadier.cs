// https://www.pokemon.com/us/pokedex/657

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Frogadier : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Frogadier()); }
        }
        #endregion
        
        #region Constructors
        private Frogadier()
            : base(
                657,
                "Frogadier",
                "Croâporal",
                TypeWater.Instance,
                6,
                109,
                "Bubble Frog Pokémon",
                "Pokémon Crapobulle",
                "Its swiftness is unparalleled. It can scale a tower of more than 2,000 feet in a minute’s time.",
                "Son agilité est incomparable. Il peut gravir une tour de 600 m de haut en moins d’une minute.",
                54,
                63,
                52,
                83,
                56,
                97
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Lick.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}