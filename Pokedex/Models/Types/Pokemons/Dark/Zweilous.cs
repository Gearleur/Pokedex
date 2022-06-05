// https://www.pokemon.com/us/pokedex/634

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dark
{
    internal class Zweilous : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Zweilous()); }
        }
        #endregion
        
        #region Constructors
        private Zweilous()
            : base(
                634,
                "Zweilous",
                "Diamat",
                TypeDark.Instance,
                TypeDragon.Instance,
                14,
                500,
                "Hostile Pokémon",
                "Pokémon Violent",
                "Their two heads will fight each other over a single piece of food. Zweilous are covered in scars even without battling others.",
                "Ses deux têtes se disputent la même proie. Il est toujours couvert de blessures, même s’il n’a affronté personne.",
                72,
                85,
                70,
                65,
                70,
                58
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
            this._moveList.Add(Slam.Instance);
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Strength.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(HiddenPower.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(RockSmash.Instance);
            this._moveList.Add(Uproar.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(SecretPower.Instance);
            this._moveList.Add(HyperVoice.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(DarkPulse.Instance);
            this._moveList.Add(AquaTail.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(ThunderFang.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(FireFang.Instance);
            this._moveList.Add(ZenHeadbutt.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Incinerate.Instance);
            this._moveList.Add(DragonTail.Instance);
        }
        #endregion
    }
}