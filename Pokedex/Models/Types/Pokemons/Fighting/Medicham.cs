// https://www.pokemon.com/us/pokedex/308

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Fighting
{
    internal class Medicham : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Medicham()); }
        }
        #endregion
        
        #region Constructors
        private Medicham()
            : base(
                308,
                "Medicham",
                "Charmina",
                TypeFighting.Instance,
                TypePsy.Instance,
                13,
                315,
                "Meditate Pokémon",
                "Pokémon Méditation",
                "Through the power of meditation, Medicham developed its sixth sense. It gained the ability to use psychokinetic powers. This Pokémon is known to meditate for a whole month without eating.",
                "Grâce au pouvoir de la méditation, Charmina a développé son sixième sens. Il peut utiliser des pouvoirs télékinétiques. On sait que ce Pokémon peut méditer pendant un mois sans manger.",
                60,
                60,
                75,
                60,
                75,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(FirePunch.Instance);
            this._moveList.Add(IcePunch.Instance);
            this._moveList.Add(ThunderPunch.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Confusion.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(HighJumpKick.Instance);
            this._moveList.Add(DreamEater.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(DynamicPunch.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SignalBeam.Instance);
            this._moveList.Add(Feint.Instance);
            this._moveList.Add(ForcePalm.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(DrainPunch.Instance);
            this._moveList.Add(VacuumWave.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Retaliate.Instance);
            this._moveList.Add(PowerUpPunch.Instance);
        }
        #endregion
    }
}