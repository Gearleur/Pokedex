// https://www.pokemon.com/us/pokedex/895

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Regidrago : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Regidrago()); }
        }
        #endregion
        
        #region Constructors
        private Regidrago()
            : base(
                895,
                "Regidrago",
                "Regidrago",
                TypeDragon.Instance,
                21,
                2000,
                "Dragon Orb Pokémon",
                "Pokémon Boule Dragon",
                "Its body is composed of crystallized dragon energy. Regidrago is said to have the powers of every dragon Pokémon.",
                "Son corps est entièrement composé de cristaux d’énergie draconique. Il possèderait les pouvoirs de tous les Pokémon Dragon.",
                200,
                100,
                50,
                100,
                50,
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
            this._moveList.Add(ViceGrip.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Thrash.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SelfDestruct.Instance);
            this._moveList.Add(Explosion.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(Twister.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(AncientPower.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(HammerArm.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(DragonEnergy.Instance);
        }
        #endregion
    }
}