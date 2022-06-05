// https://www.pokemon.com/us/pokedex/189

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Jumpluff : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Jumpluff()); }
        }
        #endregion
        
        #region Constructors
        private Jumpluff()
            : base(
                189,
                "Jumpluff",
                "Cotovol",
                TypeGrass.Instance,
                TypeFlying.Instance,
                8,
                30,
                "Cottonweed Pokémon",
                "Pokémon Pissenlit",
                "Jumpluff rides warm southern winds to cross the sea and fly to foreign lands. The Pokémon descends to the ground when it encounters cold air while it is floating.",
                "Cotovol traverse la mer, porté par les vents, pour découvrir de nouveaux territoires. Ce Pokémon se rapproche du sol quand le vent est trop froid.",
                75,
                55,
                70,
                55,
                95,
                110
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Absorb.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(FairyWind.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}