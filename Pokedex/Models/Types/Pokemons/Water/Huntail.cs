// https://www.pokemon.com/us/pokedex/367

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Huntail : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Huntail()); }
        }
        #endregion
        
        #region Constructors
        private Huntail()
            : base(
                367,
                "Huntail",
                "Serpang",
                TypeWater.Instance,
                17,
                270,
                "Deep Sea Pokémon",
                "Pokémon Abysse",
                "Deep seas are their habitat. According to tradition, when Huntail wash up onshore, something unfortunate will happen.",
                "Il habite dans les profondeurs de l’océan. Un Serpang trouvé sur la plage serait un mauvais présage.",
                55,
                104,
                105,
                94,
                75,
                52
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}