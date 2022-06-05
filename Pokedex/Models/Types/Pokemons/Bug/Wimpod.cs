// https://www.pokemon.com/us/pokedex/767

using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Bug
{
    internal class Wimpod : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Wimpod()); }
        }
        #endregion
        
        #region Constructors
        private Wimpod()
            : base(
                767,
                "Wimpod",
                "Sovkipou",
                TypeBug.Instance,
                TypeWater.Instance,
                5,
                120,
                "Turn Tail Pokémon",
                "Pokémon Cavaleur",
                "Wimpod gather in swarms, constantly on the lookout for danger. They scatter the moment they detect an enemy’s presence.",
                "Ils se déplacent en groupe, toujours en alerte. Dès qu’ils détectent une présence ennemie, ils s’enfuient dans toutes les directions.",
                25,
                35,
                40,
                20,
                30,
                80
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
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(BugBuzz.Instance);
            this._moveList.Add(AquaJet.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(StruggleBug.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}