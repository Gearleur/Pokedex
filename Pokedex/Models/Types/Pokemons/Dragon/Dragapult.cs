// https://www.pokemon.com/us/pokedex/887

using Pokedex.Models.Moves.Flying;
using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Fire;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Grass;
using Pokedex.Models.Moves.Electric;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Ghost;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Psy;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Dragon
{
    internal class Dragapult : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Dragapult()); }
        }
        #endregion
        
        #region Constructors
        private Dragapult()
            : base(
                887,
                "Dragapult",
                "Lanssorien",
                TypeDragon.Instance,
                TypeGhost.Instance,
                30,
                500,
                "Stealth Pokémon",
                "Pokémon Furtif",
                "Apparently the Dreepy inside Dragapult’s horns eagerly look forward to being launched out at Mach speeds.",
                "Il paraît que les Fantyrm installés dans ses cornes attendent impatiemment le moment où ils seront propulsés à la vitesse du son.",
                88,
                120,
                75,
                100,
                75,
                142
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
            this._moveList.Add(Fly.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(TakeDown.Instance);
            this._moveList.Add(DoubleEdge.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(Flamethrower.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(SolarBeam.Instance);
            this._moveList.Add(Thunderbolt.Instance);
            this._moveList.Add(Thunder.Instance);
            this._moveList.Add(QuickAttack.Instance);
            this._moveList.Add(FireBlast.Instance);
            this._moveList.Add(TriAttack.Instance);
            this._moveList.Add(Thief.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(Outrage.Instance);
            this._moveList.Add(SteelWing.Instance);
            this._moveList.Add(DragonBreath.Instance);
            this._moveList.Add(ShadowBall.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(Astonish.Instance);
            this._moveList.Add(DragonClaw.Instance);
            this._moveList.Add(Brine.Instance);
            this._moveList.Add(UTurn.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(LastResort.Instance);
            this._moveList.Add(SuckerPunch.Instance);
            this._moveList.Add(DragonPulse.Instance);
            this._moveList.Add(DragonRush.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(DracoMeteor.Instance);
            this._moveList.Add(DoubleHit.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Hex.Instance);
            this._moveList.Add(Acrobatics.Instance);
            this._moveList.Add(PhantomForce.Instance);
            this._moveList.Add(Infestation.Instance);
            this._moveList.Add(PsychicFangs.Instance);
            this._moveList.Add(DragonDarts.Instance);
            this._moveList.Add(BreakingSwipe.Instance);
        }
        #endregion
    }
}