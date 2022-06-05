// https://www.pokemon.com/us/pokedex/615

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ice
{
    internal class Cryogonal : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Cryogonal()); }
        }
        #endregion
        
        #region Constructors
        private Cryogonal()
            : base(
                615,
                "Cryogonal",
                "Hexagel",
                TypeIce.Instance,
                11,
                1480,
                "Crystallizing Pokémon",
                "Pokémon Cristal",
                "When the weather gets hot, these Pokémon turn into water vapor. Cryogonal are almost never seen during summer.",
                "Lorsqu’il fait trop chaud, il s’évapore, ce qui explique pourquoi on ne le voit presque pas en été.",
                80,
                50,
                50,
                95,
                135,
                105
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
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(AuroraBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(IcicleSpear.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(IceShard.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(FrostBreath.Instance);
            this._moveList.Add(FreezeDry.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}