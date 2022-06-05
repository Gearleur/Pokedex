// https://www.pokemon.com/us/pokedex/732

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Normal
{
    internal class Trumbeak : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Trumbeak()); }
        }
        #endregion
        
        #region Constructors
        private Trumbeak()
            : base(
                732,
                "Trumbeak",
                "Piclairon",
                TypeNormal.Instance,
                TypeFlying.Instance,
                6,
                148,
                "Bugle Beak Pokémon",
                "Pokémon Bec Clairon",
                "From its mouth, it fires the seeds of berries it has eaten. The scattered seeds give rise to new plants.",
                "Il crache violemment les noyaux des Baies qu’il a mangées. Ils s’éparpillent au sol et donnent naissance à de nouvelles plantes.",
                55,
                85,
                50,
                40,
                50,
                75
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(FuryAttack.Instance);
            this._moveList.Add(Peck.Instance);
            this._moveList.Add(DrillPeck.Instance);
            this._moveList.Add(SkyAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(GunkShot.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(FlameCharge.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
        }
        #endregion
    }
}