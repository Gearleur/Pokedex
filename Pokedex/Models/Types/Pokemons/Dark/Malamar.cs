// https://www.pokemon.com/us/pokedex/687

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Malamar : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Malamar()); }
        }
        #endregion
        
        #region Constructors
        private Malamar()
            : base(
                687,
                "Malamar",
                "Sepiatroce",
                TypeDark.Instance,
                TypePsy.Instance,
                15,
                470,
                "Overturning Pokémon",
                "Pokémon Révolution",
                "It’s said that Malamar’s hypnotic powers played a role in certain history-changing events.",
                "On raconte que ses pouvoirs hypnotiques seraient à l’origine d’évènements qui ont bouleversé le cours de l’Histoire.",
                86,
                92,
                88,
                68,
                75,
                73
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
            this._moveList.Add(Bind.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(Wrap.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(Psybeam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Constrict.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(FutureSight.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}