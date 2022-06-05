// https://www.pokemon.com/us/pokedex/752

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Araquanid : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Araquanid()); }
        }
        #endregion
        
        #region Constructors
        private Araquanid()
            : base(
                752,
                "Araquanid",
                "Tarenbulle",
                TypeWater.Instance,
                TypeBug.Instance,
                18,
                820,
                "Water Bubble Pokémon",
                "Pokémon Aquabulle",
                "It acts as a caretaker for Dewpider, putting them inside its bubble and letting them eat any leftover food.",
                "Il prend soin de petits Araqua en les abritant dans sa bulle et en les laissant grignoter les restes de ses repas.",
                68,
                70,
                92,
                50,
                132,
                42
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Lunge.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}