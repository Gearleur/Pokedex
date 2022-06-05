// https://www.pokemon.com/us/pokedex/283

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Surskit : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Surskit()); }
        }
        #endregion
        
        #region Constructors
        private Surskit()
            : base(
                283,
                "Surskit",
                "Arakdo",
                TypeBug.Instance,
                TypeWater.Instance,
                5,
                17,
                "Pond Skater Pokémon",
                "Pokémon Maresurfeur",
                "It lives in ponds and marshes that feature lots of plant life. It often fights with Dewpider, whose habitat and diet are similar.",
                "Il vit dans les lacs ou les marais où prospèrent les plantes hydrophiles. Il se dispute souvent proies et territoire avec son voisin, Araqua.",
                40,
                30,
                32,
                50,
                52,
                65
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
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(BubbleBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(Lunge.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}