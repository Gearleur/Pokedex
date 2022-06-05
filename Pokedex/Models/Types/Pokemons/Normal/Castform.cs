// https://www.pokemon.com/us/pokedex/351

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Castform : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Castform()); }
        }
        #endregion
        
        #region Constructors
        private Castform()
            : base(
                351,
                "Castform",
                "Morphéo",
                TypeNormal.Instance,
                3,
                8,
                "Weather Pokémon",
                "Pokémon Climat",
                "Its form changes depending on the weather. The rougher conditions get, the rougher Castform’s disposition!",
                "Il n’y a pas que son apparence qui change en fonction de la météo : son tempérament aussi ! Plus il y a de vent, plus il se montre agressif.",
                70,
                70,
                70,
                70,
                70,
                70
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(PowderSnow.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WeatherBall.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(Avalanche.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Hurricane.Instance);
        }
        #endregion
    }
}