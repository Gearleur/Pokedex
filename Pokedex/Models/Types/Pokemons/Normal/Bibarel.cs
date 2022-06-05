// https://www.pokemon.com/us/pokedex/400

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Bibarel : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Bibarel()); }
        }
        #endregion
        
        #region Constructors
        private Bibarel()
            : base(
                400,
                "Bibarel",
                "Castorno",
                TypeNormal.Instance,
                TypeWater.Instance,
                10,
                315,
                "Beaver Pokémon",
                "Pokémon Castor",
                "It makes its nest by damming streams with bark and mud. It is known as an industrious worker.",
                "Il construit des barrages de boue et d’écorce le long des fleuves. C’est un ouvrier de renom.",
                79,
                85,
                60,
                55,
                60,
                71
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(HyperFang.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(RockClimb.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}