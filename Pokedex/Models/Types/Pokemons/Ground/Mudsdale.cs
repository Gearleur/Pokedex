// https://www.pokemon.com/us/pokedex/750

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Ground
{
    internal class Mudsdale : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Mudsdale()); }
        }
        #endregion
        
        #region Constructors
        private Mudsdale()
            : base(
                750,
                "Mudsdale",
                "Bourrinos",
                TypeGround.Instance,
                25,
                9200,
                "Draft Horse Pokémon",
                "Pokémon Cheval Trait",
                "Mudsdale has so much stamina that it could carry over 10 tons across the Galar region without rest or sleep.",
                "Il a assez d’endurance pour arpenter tout Galar sans relâche en tirant des charges dépassant les dix tonnes.",
                100,
                125,
                100,
                55,
                85,
                35
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
            this._moveList.Add(Stomp.Instance);
            this._moveList.Add(DoubleKick.Instance);
            this._moveList.Add(MegaKick.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(MudSlap.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IronHead.Instance);
            this._moveList.Add(LowSweep.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(LashOut.Instance);
        }
        #endregion
    }
}