// https://www.pokemon.com/us/pokedex/566

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Archen : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Archen()); }
        }
        #endregion
        
        #region Constructors
        private Archen()
            : base(
                566,
                "Archen",
                "Arkéapti",
                TypeRock.Instance,
                TypeFlying.Instance,
                5,
                95,
                "First Bird Pokémon",
                "Pokémon Oisancien",
                "Archen is said to be the ancestor of bird Pokémon. It lived in treetops, eating berries and bug Pokémon.",
                "On dit que c’est l’ancêtre des Pokémon oiseaux. Il vivait à la cime des arbres et se nourrissait de Baies et de Pokémon Insecte.",
                55,
                112,
                45,
                74,
                45,
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
            this._moveList.Add(Cut.Instance);
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(HeatWave.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(KnockOff.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Bounce.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Pluck.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(ShadowClaw.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(LashOut.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}