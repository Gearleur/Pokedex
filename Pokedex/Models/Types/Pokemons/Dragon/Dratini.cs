// https://www.pokemon.com/us/pokedex/147

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Dratini : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dratini()); }
        }
        #endregion
        
        #region Constructors
        private Dratini()
            : base(
                147,
                "Dratini",
                "Minidraco",
                TypeDragon.Instance,
                18,
                33,
                "Dragon Pokémon",
                "Pokémon Dragon",
                "This Pokémon was long considered to be no more than a myth. The small lump on a Dratini’s forehead is actually a horn that’s still coming in.",
                "On a longtemps douté de l’existence de ce Pokémon. La petite bosse sur son front est en fait sa corne en pleine croissance.",
                41,
                64,
                45,
                50,
                50,
                50
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(FireSpin.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(ZapCannon.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(ExtremeSpeed.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
        }
        #endregion
    }
}