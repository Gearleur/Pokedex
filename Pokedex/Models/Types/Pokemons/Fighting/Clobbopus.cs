// https://www.pokemon.com/us/pokedex/852

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Clobbopus : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Clobbopus()); }
        }
        #endregion
        
        #region Constructors
        private Clobbopus()
            : base(
                852,
                "Clobbopus",
                "Poulpaf",
                TypeFighting.Instance,
                6,
                40,
                "Tantrum Pokémon",
                "Pokémon Caprice",
                "Its tentacles tear off easily, but it isn’t alarmed when that happens—it knows they’ll grow back. It’s about as smart as a three-year-old.",
                "Il a l’intelligence d’un enfant de trois ans. Il perd souvent ses tentacules, mais comme ils repoussent, il ne s’en soucie guère.",
                50,
                68,
                60,
                50,
                50,
                32
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Submission.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(CircleThrow.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(Liquidation.Instance);
        }
        #endregion
    }
}