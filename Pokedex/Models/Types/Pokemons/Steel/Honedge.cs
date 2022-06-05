// https://www.pokemon.com/us/pokedex/679

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Steel
{
    internal class Honedge : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Honedge()); }
        }
        #endregion
        
        #region Constructors
        private Honedge()
            : base(
                679,
                "Honedge",
                "Monorpale",
                TypeSteel.Instance,
                TypeGhost.Instance,
                8,
                20,
                "Sword Pokémon",
                "Pokémon Glaive",
                "The blue eye on the sword’s handguard is the true body of Honedge. With its old cloth, it drains people’s lives away.",
                "L’œil bleu sur la garde de la lame est le véritable corps de Monorpale. Il aspire l’énergie vitale des gens avec son étoffe usée par le temps.",
                45,
                80,
                100,
                35,
                37,
                28
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ShadowSneak.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(FlashCannon.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(SacredSword.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(SteelBeam.Instance);
        }
        #endregion
    }
}