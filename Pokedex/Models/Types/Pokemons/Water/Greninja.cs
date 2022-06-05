// https://www.pokemon.com/us/pokedex/658

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Greninja : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Greninja()); }
        }
        #endregion
        
        #region Constructors
        private Greninja()
            : base(
                658,
                "Greninja",
                "Amphinobi",
                TypeWater.Instance,
                TypeDark.Instance,
                15,
                400,
                "Ninja Pokémon",
                "Pokémon Ninja",
                "It appears and vanishes with a ninja’s grace. It toys with its enemies using swift movements, while slicing them with throwing stars of sharpest water.",
                "Aussi insaisissable qu’un ninja, il se joue de ses ennemis grâce à sa célérité, et les tranche de ses Sheauriken.",
                72,
                95,
                67,
                103,
                71,
                122
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
            this._moveList.Add(HyperBeam.Instance);
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
            this._moveList.Add(HydroCannon.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(WaterPledge.Instance);
            this._moveList.Add(WaterShuriken.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}