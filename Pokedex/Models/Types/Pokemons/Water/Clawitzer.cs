// https://www.pokemon.com/us/pokedex/693

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Clawitzer : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Clawitzer()); }
        }
        #endregion
        
        #region Constructors
        private Clawitzer()
            : base(
                693,
                "Clawitzer",
                "Gamblast",
                TypeWater.Instance,
                13,
                353,
                "Howitzer Pokémon",
                "Pokémon Blaster",
                "Clawitzer’s right arm is a cannon that launches projectiles made of seawater. Shots from a Clawitzer’s cannon arm can sink a tanker.",
                "Sa pince droite est un canon pouvant projeter des obus d’eau assez puissants pour couler un navire-citerne.",
                71,
                73,
                88,
                120,
                89,
                59
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
            this._moveList.Add(ViceGrip.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Crabhammer.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(TerrainPulse.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}