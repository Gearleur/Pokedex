// https://www.pokemon.com/us/pokedex/624

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Pawniard : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Pawniard()); }
        }
        #endregion
        
        #region Constructors
        private Pawniard()
            : base(
                624,
                "Pawniard",
                "Scalpion",
                TypeDark.Instance,
                TypeSteel.Instance,
                5,
                102,
                "Sharp Blade Pokémon",
                "Pokémon Coupant",
                "A pack of these Pokémon forms to serve a Bisharp boss. Each Pawniard trains diligently, dreaming of one day taking the lead.",
                "Il vit en meute, sous les ordres d’un Scalproie. Il s’entraîne sans relâche en rêvant du jour où il sera chef de meute à son tour.",
                45,
                85,
                70,
                40,
                40,
                60
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
            this._moveList.Add(Scratch.Instance);
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Slash.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(FuryCutter.Instance);
            this._moveList.Add(Pursuit.Instance);
            this._moveList.Add(MetalClaw.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(NightSlash.Instance);
            this._moveList.Add(XScissor.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(PsychoCut.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(FoulPlay.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
            this._moveList.Add(SteelBeam.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}