// https://www.pokemon.com/us/pokedex/820

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Greedent : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Greedent()); }
        }
        #endregion
        
        #region Constructors
        private Greedent()
            : base(
                820,
                "Greedent",
                "Rongrigou",
                TypeNormal.Instance,
                6,
                60,
                "Greedy Pokémon",
                "Pokémon Goulu",
                "Common throughout the Galar region, this Pokémon has strong teeth and can chew through the toughest of berry shells.",
                "On rencontre souvent ce Pokémon à Galar. Aucune coquille de Baie ne résiste à ses incisives, dont il est très fier.",
                120,
                95,
                95,
                55,
                75,
                20
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
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(WildCharge.Instance);
            this._moveList.Add(TailSlap.Instance);
            this._moveList.Add(Belch.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
        }
        #endregion
    }
}