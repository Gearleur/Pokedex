// https://www.pokemon.com/us/pokedex/772

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class TypeNull : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new TypeNull()); }
        }
        #endregion
        
        #region Constructors
        private TypeNull()
            : base(
                772,
                "Type: Null",
                "Type:0",
                TypeNormal.Instance,
                19,
                1205,
                "Synthetic Pokémon",
                "Pokémon Multigénome",
                "It was modeled after a mighty Pokémon of myth. The mask placed upon it limits its power in order to keep it under control.",
                "Il a été créé artificiellement d’après un Pokémon mythique. Il est muni d’un masque afin de contenir sa puissance.",
                95,
                95,
                95,
                95,
                95,
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
            this._moveList.Add(RazorWind.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Rage.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IcyWind.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(CrushClaw.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}