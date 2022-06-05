// https://www.pokemon.com/us/pokedex/604

using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Electric
{
    internal class Eelektross : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Eelektross()); }
        }
        #endregion
        
        #region Constructors
        private Eelektross()
            : base(
                604,
                "Eelektross",
                "Ohmassacre",
                TypeElectric.Instance,
                21,
                805,
                "EleFish Pokémon",
                "Pokémon Électrophore",
                "They crawl out of the ocean using their arms. They will attack prey on shore and immediately drag it into the ocean.",
                "Il peut sortir de l’eau à la force de ses bras pour attraper des proies sur la rive. Il retourne à l’eau en un instant.",
                85,
                115,
                80,
                105,
                80,
                50
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
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Discharge.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(ThroatChop.Instance);
        }
        #endregion
    }
}