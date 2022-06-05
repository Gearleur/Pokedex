// https://www.pokemon.com/us/pokedex/801

using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Magearna : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Magearna()); }
        }
        #endregion
        
        #region Constructors
        private Magearna()
            : base(
                801,
                "Magearna",
                "Magearna",
                TypeSteel.Instance,
                TypeFairy.Instance,
                10,
                805,
                "Artificial Pokémon",
                "Pokémon Artificiel",
                "Built roughly 500 years ago by a scientist, the part called the Soul-Heart is the actual life-form.",
                "Il a été créé par un scientifique il y a environ 500 ans de cela. Sa véritable essence est un organe nommé Animacœur.",
                80,
                95,
                115,
                130,
                115,
                65
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
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(MirrorShot.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Synchronoise.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(VoltSwitch.Instance);
            this._moveList.Add(Electroweb.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(FleurCannon.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(SteelRoller.Instance);
            this._moveList.Add(MistyExplosion.Instance);
        }
        #endregion
    }
}