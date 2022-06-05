// https://www.pokemon.com/us/pokedex/719

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Fairy;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Rock
{
    internal class Diancie : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Diancie()); }
        }
        #endregion
        
        #region Constructors
        private Diancie()
            : base(
                719,
                "Diancie",
                "Diancie",
                TypeRock.Instance,
                TypeFairy.Instance,
                7,
                88,
                "Jewel Pokémon",
                "Pokémon Joyau",
                "It can instantly create many diamonds by compressing the carbon in the air between its hands.",
                "Il peut créer une multitude de diamants en un instant en serrant ses mains, simplement en compressant les molécules de carbone contenues dans l’air.",
                50,
                100,
                150,
                100,
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
            this._moveList.Add(HyperBeam.Instance);
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
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(PowerGem.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(Psyshock.Instance);
            this._moveList.Add(SmackDown.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(StoredPower.Instance);
            this._moveList.Add(DrainingKiss.Instance);
            this._moveList.Add(PlayRough.Instance);
            this._moveList.Add(Moonblast.Instance);
            this._moveList.Add(DiamondStorm.Instance);
            this._moveList.Add(MysticalFire.Instance);
            this._moveList.Add(DazzlingGleam.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(MistyExplosion.Instance);
            this._moveList.Add(TerrainPulse.Instance);
        }
        #endregion
    }
}