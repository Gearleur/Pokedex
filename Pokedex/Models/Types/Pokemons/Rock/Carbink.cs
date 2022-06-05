// https://www.pokemon.com/us/pokedex/703

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Carbink : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Carbink()); }
        }
        #endregion
        
        #region Constructors
        private Carbink()
            : base(
                703,
                "Carbink",
                "Strassie",
                TypeRock.Instance,
                TypeFairy.Instance,
                3,
                57,
                "Jewel Pokémon",
                "Pokémon Joyau",
                "It’s said that somewhere in the world, there’s a mineral vein housing a large pack of slumbering Carbink. It’s also said that this pack has a queen.",
                "On raconte qu’il existerait quelque part dans le monde un filon regorgeant de Strassie, qui abriterait également leur reine.",
                50,
                50,
                150,
                50,
                150,
                50
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
            this._moveList.Add(RockThrow.Instance);
            this._moveList.Add(Psychic.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(Covet.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(MistyExplosion.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}