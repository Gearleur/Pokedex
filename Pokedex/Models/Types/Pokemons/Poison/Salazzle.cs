// https://www.pokemon.com/us/pokedex/758

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Poison
{
    internal class Salazzle : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Salazzle()); }
        }
        #endregion
        
        #region Constructors
        private Salazzle()
            : base(
                758,
                "Salazzle",
                "Malamandre",
                TypePoison.Instance,
                TypeFire.Instance,
                12,
                222,
                "Toxic Lizard Pokémon",
                "Pokémon Toxilézard",
                "The winner of competitions between Salazzle is decided by which one has the most male Salandit with it.",
                "Les conflits entre Malamandre seraient réglés par un simple calcul : le spécimen dont la suite comporte le plus de Tritox l’emporte.",
                68,
                64,
                60,
                111,
                60,
                117
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Ember.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Smog.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(LeechLife.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SludgeBomb.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(PoisonFang.Instance);
            this._moveList.Add(Overheat.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(FlareBlitz.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(CrossPoison.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(Venoshock.Instance);
            this._moveList.Add(FlameBurst.Instance);
            this._moveList.Add(SludgeWave.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(DragonTail.Instance);
            this._moveList.Add(FireLash.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}