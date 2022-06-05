// https://www.pokemon.com/us/pokedex/717

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Yveltal : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Yveltal()); }
        }
        #endregion
        
        #region Constructors
        private Yveltal()
            : base(
                717,
                "Yveltal",
                "Yveltal",
                TypeDark.Instance,
                TypeFlying.Instance,
                58,
                2030,
                "Destruction Pokémon",
                "Pokémon Annihilation",
                "When its life comes to an end, it absorbs the life energy of every living thing and turns into a cocoon once more.",
                "Quand il sent que la fin de sa vie est proche, il aspire la force vitale des êtres vivants et retourne à l’état de cocon.",
                126,
                131,
                95,
                131,
                98,
                99
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(SkyDrop.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(OblivionWing.Instance);
            this._moveList.Add(LashOut.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}