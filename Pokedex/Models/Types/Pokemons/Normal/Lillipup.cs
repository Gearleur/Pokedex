// https://www.pokemon.com/us/pokedex/506

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Lillipup : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Lillipup()); }
        }
        #endregion
        
        #region Constructors
        private Lillipup()
            : base(
                506,
                "Lillipup",
                "Ponchiot",
                TypeNormal.Instance,
                4,
                41,
                "Puppy Pokémon",
                "Pokémon Chiot",
                "This Pokémon is far brighter than the average child, and Lillipup won’t forget the love it receives or any abuse it suffers.",
                "Ce Pokémon est plus intelligent que la plupart des enfants. Il n’oublie ni l’affection qu’il a reçue ni les mauvais traitements qu’il a pu subir.",
                45,
                60,
                45,
                25,
                45,
                55
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Lick.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(PsychicFangs.Instance);
        }
        #endregion
    }
}