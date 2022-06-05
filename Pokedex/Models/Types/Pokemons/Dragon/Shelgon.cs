// https://www.pokemon.com/us/pokedex/372

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Shelgon : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Shelgon()); }
        }
        #endregion
        
        #region Constructors
        private Shelgon()
            : base(
                372,
                "Shelgon",
                "Drackhaus",
                TypeDragon.Instance,
                11,
                1105,
                "Endurance Pokémon",
                "Pokémon Endurant",
                "This Pokémon has covered its body in a hard shell that has the same composition as bone. Shelgon stores energy for evolution.",
                "Il se prive de nourriture, résistant à la faim. On dit que son évolution commence lorsque ses réserves d’énergie sont épuisées.",
                65,
                95,
                100,
                60,
                50,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
        }
        #endregion
    }
}