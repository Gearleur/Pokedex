// https://www.pokemon.com/us/pokedex/416

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Vespiquen : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Vespiquen()); }
        }
        #endregion
        
        #region Constructors
        private Vespiquen()
            : base(
                416,
                "Vespiquen",
                "Apireine",
                TypeBug.Instance,
                TypeFlying.Instance,
                12,
                385,
                "Beehive Pokémon",
                "Pokémon Ruche",
                "Vespiquen that give off more pheromones have larger swarms of Combee attendants.",
                "Plus la quantité de phéromones qu’il libère est élevée, plus le nombre d’Apitrini qu’il peut diriger est grand.",
                70,
                80,
                102,
                80,
                102,
                40
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
            this._moveList.Add(Gust.Instance);
            this._moveList.Add(PoisonSting.Instance);
            this._moveList.Add(PinMissile.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(FurySwipes.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(AirCutter.Instance);
            this._moveList.Add(SilverWind.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(BugBite.Instance);
            this._moveList.Add(AttackOrder.Instance);
            this._moveList.Add(OminousWind.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(FellStinger.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}