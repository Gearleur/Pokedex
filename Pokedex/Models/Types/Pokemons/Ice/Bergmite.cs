// https://www.pokemon.com/us/pokedex/712

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Bergmite : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bergmite()); }
        }
        #endregion
        
        #region Constructors
        private Bergmite()
            : base(
                712,
                "Bergmite",
                "Grelaçon",
                TypeIce.Instance,
                10,
                995,
                "Ice Chunk Pokémon",
                "Pokémon Glaçon",
                "This Pokémon lives in areas of frigid cold. It secures itself to the back of an Avalugg by freezing its feet in place.",
                "Il vit dans les régions les plus froides, agrippé aux Séracrawl. Il gèle ses pattes sur leur dos pour se maintenir en place.",
                55,
                69,
                85,
                32,
                35,
                28
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(IceBall.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(FrostBreath.Instance);
        }
        #endregion
    }
}