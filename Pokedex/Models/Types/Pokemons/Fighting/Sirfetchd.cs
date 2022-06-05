// https://www.pokemon.com/us/pokedex/865

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Sirfetchd : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Sirfetchd()); }
        }
        #endregion
        
        #region Constructors
        private Sirfetchd()
            : base(
                865,
                "Sirfetch’d",
                "Palarticho",
                TypeFighting.Instance,
                8,
                1170,
                "Wild Duck Pokémon",
                "Pokémon Canard Fou",
                "After deflecting attacks with its hard leaf shield, it strikes back with its sharp leek stalk. The leek stalk is both weapon and food.",
                "Il pare les attaques avec le tranchant de son solide poireau, et contre-attaque avec la pointe de la tige. Son arme est également comestible.",
                62,
                135,
                95,
                68,
                82,
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(LeafBlade.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(BraveBird.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(FirstImpression.Instance);
            this._moveList.Add(SolarBlade.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(MeteorAssault.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}