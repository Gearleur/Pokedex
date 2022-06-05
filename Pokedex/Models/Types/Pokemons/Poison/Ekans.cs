// https://www.pokemon.com/us/pokedex/23

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Ekans : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Ekans()); }
        }
        #endregion
        
        #region Constructors
        private Ekans()
            : base(
                23,
                "Ekans",
                "Abo",
                TypePoison.Instance,
                20,
                69,
                "Snake Pokémon",
                "Pokémon Serpent",
                "The older it gets, the longer it grows. At night, it wraps its long body around tree branches to rest.",
                "Plus il est âgé, plus son corps est long. La nuit, il s’enroule autour de branches d’arbres pour se reposer.",
                35,
                60,
                44,
                40,
                54,
                55
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(MudBomb.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}