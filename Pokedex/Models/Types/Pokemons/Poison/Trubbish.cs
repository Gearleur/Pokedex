// https://www.pokemon.com/us/pokedex/568

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Trubbish : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Trubbish()); }
        }
        #endregion
        
        #region Constructors
        private Trubbish()
            : base(
                568,
                "Trubbish",
                "Miamiasme",
                TypePoison.Instance,
                6,
                310,
                "Trash Bag Pokémon",
                "Pokémon Sac Poubelle",
                "This Pokémon was born from a bag stuffed with trash. Galarian Weezing relish the fumes belched by Trubbish.",
                "Il est né d’un sac poubelle rempli d’ordures. Le gaz empoisonné qu’il exhale est très apprécié des Smogogo de Galar.",
                50,
                50,
                62,
                40,
                62,
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
            this._moveList.Add(Pound.Instance);
            this._moveList.Add(DoubleSlap.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Sludge.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(Infestation.Instance);
        }
        #endregion
    }
}