// https://www.pokemon.com/us/pokedex/237

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Hitmontop : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Hitmontop()); }
        }
        #endregion
        
        #region Constructors
        private Hitmontop()
            : base(
                237,
                "Hitmontop",
                "Kapoera",
                TypeFighting.Instance,
                14,
                480,
                "Handstand Pokémon",
                "Pokémon Poirier",
                "After doing a handstand to throw off the opponent’s timing, it presents its fancy kick moves.",
                "Après avoir effectué un poirier visant à désorienter son adversaire, il lui assène des coups de pied furieux.",
                50,
                95,
                95,
                35,
                110,
                70
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(RollingKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(TripleKick.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(Rollout.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(RapidSpin.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(FakeOut.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(DrillRun.Instance);
            this._moveList.Add(BrutalSwing.Instance);
            this._moveList.Add(TripleAxel.Instance);
        }
        #endregion
    }
}