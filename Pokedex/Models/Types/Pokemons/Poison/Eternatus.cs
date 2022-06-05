// https://www.pokemon.com/us/pokedex/890

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Eternatus : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Eternatus()); }
        }
        #endregion
        
        #region Constructors
        private Eternatus()
            : base(
                890,
                "Eternatus",
                "Éthernatos",
                TypePoison.Instance,
                TypeDragon.Instance,
                200,
                9500,
                "Gigantic Pokémon",
                "Pokémon Giga",
                "It was inside a meteorite that fell 20,000 years ago. There seems to be a connection between this Pokémon and the Dynamax phenomenon.",
                "Il se trouvait dans une météorite qui s’est écrasée il y a 20 000 ans. Il semble y avoir un lien entre ce Pokémon et le phénomène Dynamax.",
                140,
                85,
                95,
                145,
                95,
                130
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(PoisonTail.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(DynamaxCannon.Instance);
            this._moveList.Add(Eternabeam.Instance);
            this._moveList.Add(MeteorBeam.Instance);
        }
        #endregion
    }
}