// https://www.pokemon.com/us/pokedex/741

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fire
{
    internal class OricorioBaile : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new OricorioBaile()); }
        }
        #endregion
        
        #region Constructors
        private OricorioBaile()
            : base(
                741,
                "Oricorio",
                "Plumeline",
                TypeFire.Instance,
                TypeFlying.Instance,
                6,
                34,
                "Dancing Pokémon",
                "Pokémon Danse",
                "This Oricorio has drunk red nectar. If its Trainer gives the wrong order, this passionate Pokémon becomes fiercely angry.",
                "Un Plumeline ayant bu du Nectar Rouge. D’un naturel passionné, il brûle de rage quand son Dresseur se trompe d’ordre.",
                75,
                70,
                70,
                98,
                70,
                93
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
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Hurricane.Instance);
            this._moveList.Add(RevelationDance.Instance);
        }
        #endregion
    }
}