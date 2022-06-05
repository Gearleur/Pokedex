// https://www.pokemon.com/us/pokedex/175

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fairy
{
    internal class Togepi : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Togepi()); }
        }
        #endregion
        
        #region Constructors
        private Togepi()
            : base(
                175,
                "Togepi",
                "Togepi",
                TypeFairy.Instance,
                3,
                15,
                "Spike Ball Pokémon",
                "Pokémon Balle Pic",
                "It is considered to be a symbol of good luck. Its shell is said to be filled with happiness.",
                "C’est un symbole de chance. On dit que sa coquille est remplie de joie.",
                35,
                20,
                65,
                40,
                65,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
        }
        #endregion
    }
}