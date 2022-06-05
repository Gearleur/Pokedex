// https://www.pokemon.com/us/pokedex/676

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Furfrou : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Furfrou()); }
        }
        #endregion
        
        #region Constructors
        private Furfrou()
            : base(
                676,
                "Furfrou",
                "Couafarel",
                TypeNormal.Instance,
                12,
                280,
                "Poodle Pokémon",
                "Pokémon Caniche",
                "Left alone, its fur will grow longer and longer, but it will only allow someone it trusts to cut it.",
                "Sa fourrure pousse indéfiniment, mais il refuse de se faire couper la toison par une personne en qui il n’a pas confiance.",
                75,
                80,
                60,
                65,
                90,
                102
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(ChargeBeam.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
        }
        #endregion
    }
}