// https://www.pokemon.com/us/pokedex/846

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Arrokuda : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Arrokuda()); }
        }
        #endregion
        
        #region Constructors
        private Arrokuda()
            : base(
                846,
                "Arrokuda",
                "Embrochet",
                TypeWater.Instance,
                5,
                10,
                "Rush Pokémon",
                "Pokémon Fonceur",
                "After it’s eaten its fill, its movements become extremely sluggish. That’s when Cramorant swallows it up.",
                "Lorsqu’il a le ventre plein, il a beaucoup plus de mal à se déplacer, et c’est à ce moment précis qu’il se fait gober par les Nigosier.",
                41,
                63,
                40,
                40,
                30,
                66
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
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(ScaleShot.Instance);
        }
        #endregion
    }
}