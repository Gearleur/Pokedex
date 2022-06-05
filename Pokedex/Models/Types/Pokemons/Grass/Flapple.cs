// https://www.pokemon.com/us/pokedex/841

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Grass
{
    internal class Flapple : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Flapple()); }
        }
        #endregion
        
        #region Constructors
        private Flapple()
            : base(
                841,
                "Flapple",
                "Pomdrapi",
                TypeGrass.Instance,
                TypeDragon.Instance,
                3,
                10,
                "Apple Wing Pokémon",
                "Pokémon Ailes Pomme",
                "It flies on wings of apple skin and spits a powerful acid. It can also change its shape into that of an apple.",
                "Il vole avec ses ailes faites de pelures de pomme et crache une substance très acide. Il peut aussi prendre la forme de ce fruit.",
                70,
                110,
                80,
                95,
                60,
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
            this._moveList.Add(WingAttack.Instance);
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(GigaDrain.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(BulletSeed.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(SeedBomb.Instance);
            this._moveList.Add(AirSlash.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EnergyBall.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(AcidSpray.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(GravApple.Instance);
            this._moveList.Add(GrassyGlide.Instance);
            this._moveList.Add(DualWingbeat.Instance);
        }
        #endregion
    }
}