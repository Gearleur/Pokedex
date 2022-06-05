// https://www.pokemon.com/us/pokedex/174

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Igglybuff : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Igglybuff()); }
        }
        #endregion
        
        #region Constructors
        private Igglybuff()
            : base(
                174,
                "Igglybuff",
                "Toudoudou",
                TypeNormal.Instance,
                TypeFairy.Instance,
                3,
                10,
                "Balloon Pokémon",
                "Pokémon Bouboule",
                "Taking advantage of the softness of its body, Igglybuff moves as if bouncing. Its body turns a deep pink when its temperature rises.",
                "Il se déplace en faisant rebondir son corps tout mou. Lorsque sa température corporelle augmente, il devient rose foncé.",
                90,
                30,
                15,
                40,
                20,
                15
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
        }
        #endregion
    }
}