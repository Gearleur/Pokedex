// https://www.pokemon.com/us/pokedex/155

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class Cyndaquil : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cyndaquil()); }
        }
        #endregion
        
        #region Constructors
        private Cyndaquil()
            : base(
                155,
                "Cyndaquil",
                "Héricendre",
                TypeFire.Instance,
                5,
                79,
                "Fire Mouse Pokémon",
                "Pokémon Souris Feu",
                "Cyndaquil protects itself by flaring up the flames on its back. The flames are vigorous if the Pokémon is angry. However, if it is tired, the flames splutter fitfully with incomplete combustion.",
                "Héricendre se protège en faisant jaillir des flammes de son dos. Ces flammes peuvent être violentes si le Pokémon est en colère. Cependant, s’il est fatigué, seules quelques flammèches vacillent laborieusement.",
                39,
                52,
                43,
                60,
                50,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(FlameWheel.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Eruption.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(Extrasensory.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(LavaPlume.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Inferno.Instance);
            this._moveList.Add(FirePledge.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(BurnUp.Instance);
        }
        #endregion
    }
}