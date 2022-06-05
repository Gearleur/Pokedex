// https://www.pokemon.com/us/pokedex/787

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class TapuBulu : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new TapuBulu()); }
        }
        #endregion
        
        #region Constructors
        private TapuBulu()
            : base(
                787,
                "Tapu Bulu",
                "Tokotoro",
                TypeGrass.Instance,
                TypeFairy.Instance,
                19,
                455,
                "Land Spirit Pokémon",
                "Pokémon Tutélaire",
                "It makes ringing sounds with its tail to let others know where it is, avoiding unneeded conflicts. This guardian deity of Ula’ula controls plants.",
                "Il est le gardien d’Ula-Ula et le maître des plantes. Il évite les combats inutiles en faisant tinter sa queue pour signaler son arrivée.",
                70,
                130,
                115,
                85,
                95,
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
            this._moveList.Add(MegaPunch.Instance);
            this._moveList.Add(HornAttack.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(MegaDrain.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(SkullBash.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(FocusPunch.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(BrickBreak.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(CloseCombat.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(FocusBlast.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(WoodHammer.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(EchoedVoice.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DualChop.Instance);
            this._moveList.Add(HornLeech.Instance);
            this._moveList.Add(Snarl.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(DarkestLariat.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(Leafage.Instance);
            this._moveList.Add(BrutalSwing.Instance);
        }
        #endregion
    }
}