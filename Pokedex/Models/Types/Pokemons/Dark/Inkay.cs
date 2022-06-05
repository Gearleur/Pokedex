// https://www.pokemon.com/us/pokedex/686

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Inkay : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Inkay()); }
        }
        #endregion
        
        #region Constructors
        private Inkay()
            : base(
                686,
                "Inkay",
                "Sepiatop",
                TypeDark.Instance,
                TypePsy.Instance,
                4,
                35,
                "Revolving Pokémon",
                "Pokémon Rotation",
                "By exposing foes to the blinking of its luminescent spots, Inkay demoralizes them, and then it seizes the chance to flee.",
                "Il sape la combativité de son adversaire en faisant clignoter son corps lumineux, puis profite de cet instant de répit pour s’enfuir.",
                53,
                54,
                53,
                37,
                46,
                45
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
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(ExpandingForce.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}