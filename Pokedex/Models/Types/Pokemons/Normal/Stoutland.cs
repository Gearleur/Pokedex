// https://www.pokemon.com/us/pokedex/508

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Stoutland : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Stoutland()); }
        }
        #endregion
        
        #region Constructors
        private Stoutland()
            : base(
                508,
                "Stoutland",
                "Mastouffe",
                TypeNormal.Instance,
                12,
                610,
                "Big-Hearted Pokémon",
                "Pokémon Magnanime",
                "Stoutland is immensely proud of its impressive moustache. It’s said that moustache length is what determines social standing among this species.",
                "Sa moustache remarquable fait sa fierté, car sa longueur permettrait de déterminer la hiérarchie au sein de l’espèce.",
                85,
                110,
                90,
                45,
                90,
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
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
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
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(StompingTantrum.Instance);
        }
        #endregion
    }
}