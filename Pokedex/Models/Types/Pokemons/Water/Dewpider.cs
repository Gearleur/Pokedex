// https://www.pokemon.com/us/pokedex/751

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
    internal class Dewpider : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dewpider()); }
        }
        #endregion
        
        #region Constructors
        private Dewpider()
            : base(
                751,
                "Dewpider",
                "Araqua",
                TypeWater.Instance,
                TypeBug.Instance,
                3,
                40,
                "Water Bubble Pokémon",
                "Pokémon Aquabulle",
                "Dewpider normally lives underwater. When it comes onto land in search of food, it takes water with it in the form of a bubble on its head.",
                "Il vit principalement dans l’eau, mais s’il a besoin de s’aventurer sur la terre ferme pour chasser ses proies, il protège sa tête avec une bulle d’eau.",
                38,
                40,
                52,
                40,
                72,
                27
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
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Facade.Instance);
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