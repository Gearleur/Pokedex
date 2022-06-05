// https://www.pokemon.com/us/pokedex/39

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Jigglypuff : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Jigglypuff()); }
        }
        #endregion
        
        #region Constructors
        private Jigglypuff()
            : base(
                39,
                "Jigglypuff",
                "Rondoudou",
                TypeNormal.Instance,
                TypeFairy.Instance,
                5,
                55,
                "Balloon Pokémon",
                "Pokémon Bouboule",
                "By freely changing the wavelength of its voice, Jigglypuff sings a mysterious melody sure to make any listener sleepy.",
                "Il module librement la longueur d’onde de sa voix pour chanter une étrange mélodie qui endort à tous les coups celui qui l’écoute.",
                115,
                45,
                20,
                45,
                25,
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(WakeUpSlap.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}