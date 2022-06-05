// https://www.pokemon.com/us/pokedex/691

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Dragalge : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dragalge()); }
        }
        #endregion
        
        #region Constructors
        private Dragalge()
            : base(
                691,
                "Dragalge",
                "Kravarech",
                TypePoison.Instance,
                TypeDragon.Instance,
                18,
                815,
                "Mock Kelp Pokémon",
                "Pokémon Simulalgue",
                "Dragalge generates dragon energy by sticking the plume on its head out above the ocean’s surface and bathing it in sunlight.",
                "Il sort la crête sur sa tête à la surface de l’eau et l’expose à la lumière du soleil pour produire de l’énergie draconique.",
                65,
                75,
                90,
                97,
                123,
                44
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
            this._moveList.Add(Acid.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Bubble.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(WaterPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(FlipTurn.Instance);
        }
        #endregion
    }
}