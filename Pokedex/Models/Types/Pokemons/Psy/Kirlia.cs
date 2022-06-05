// https://www.pokemon.com/us/pokedex/281

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Psy
{
    internal class Kirlia : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Kirlia()); }
        }
        #endregion
        
        #region Constructors
        private Kirlia()
            : base(
                281,
                "Kirlia",
                "Kirlia",
                TypePsy.Instance,
                TypeFairy.Instance,
                8,
                202,
                "Emotion Pokémon",
                "Pokémon Émotion",
                "It has a psychic power that enables it to distort the space around it and see into the future.",
                "Il peut distordre l’espace-temps grâce à ses pouvoirs psychiques et ainsi voir l’avenir.",
                38,
                35,
                35,
                65,
                55,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}