// https://www.pokemon.com/us/pokedex/834

using Pokedex.Models.Moves.Normal;
using Pokedex.Models.Moves.Dark;
using Pokedex.Models.Moves.Water;
using Pokedex.Models.Moves.Ice;
using Pokedex.Models.Moves.Ground;
using Pokedex.Models.Moves.Rock;
using Pokedex.Models.Moves.Bug;
using Pokedex.Models.Moves.Steel;
using Pokedex.Models.Moves.Fighting;
using Pokedex.Models.Moves.Poison;
using Pokedex.Models.Moves.Dragon;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons.Water
{
    internal class Drednaw : Pokemon
    {
        #region Variables
        private static Pokemon? _instance = null;
        #endregion

        #region Getters + Setters
        public static Pokemon Instance
        {
            get { return _instance ?? (_instance = new Drednaw()); }
        }
        #endregion
        
        #region Constructors
        private Drednaw()
            : base(
                834,
                "Drednaw",
                "Torgamord",
                TypeWater.Instance,
                TypeRock.Instance,
                10,
                1155,
                "Bite Pokémon",
                "Pokémon Morsure",
                "This Pokémon rapidly extends its retractable neck to sink its sharp fangs into distant enemies and take them down.",
                "Son cou extensible lui permet d’atteindre des ennemis éloignés en un instant pour leur porter un coup décisif avec ses crocs aiguisés.",
                90,
                115,
                90,
                48,
                68,
                74
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
            this._moveList.Add(Headbutt.Instance);
            this._moveList.Add(Tackle.Instance);
            this._moveList.Add(BodySlam.Instance);
            this._moveList.Add(Bite.Instance);
            this._moveList.Add(WaterGun.Instance);
            this._moveList.Add(HydroPump.Instance);
            this._moveList.Add(Surf.Instance);
            this._moveList.Add(IceBeam.Instance);
            this._moveList.Add(Blizzard.Instance);
            this._moveList.Add(HyperBeam.Instance);
            this._moveList.Add(Earthquake.Instance);
            this._moveList.Add(Dig.Instance);
            this._moveList.Add(Waterfall.Instance);
            this._moveList.Add(RockSlide.Instance);
            this._moveList.Add(Snore.Instance);
            this._moveList.Add(FalseSwipe.Instance);
            this._moveList.Add(Megahorn.Instance);
            this._moveList.Add(IronTail.Instance);
            this._moveList.Add(Crunch.Instance);
            this._moveList.Add(Whirlpool.Instance);
            this._moveList.Add(Facade.Instance);
            this._moveList.Add(Superpower.Instance);
            this._moveList.Add(Revenge.Instance);
            this._moveList.Add(Dive.Instance);
            this._moveList.Add(RockTomb.Instance);
            this._moveList.Add(SandTomb.Instance);
            this._moveList.Add(MuddyWater.Instance);
            this._moveList.Add(MudShot.Instance);
            this._moveList.Add(RockBlast.Instance);
            this._moveList.Add(Payback.Instance);
            this._moveList.Add(Assurance.Instance);
            this._moveList.Add(PoisonJab.Instance);
            this._moveList.Add(EarthPower.Instance);
            this._moveList.Add(GigaImpact.Instance);
            this._moveList.Add(IceFang.Instance);
            this._moveList.Add(StoneEdge.Instance);
            this._moveList.Add(HeadSmash.Instance);
            this._moveList.Add(Round.Instance);
            this._moveList.Add(Scald.Instance);
            this._moveList.Add(Bulldoze.Instance);
            this._moveList.Add(RazorShell.Instance);
            this._moveList.Add(HighHorsepower.Instance);
            this._moveList.Add(ThroatChop.Instance);
            this._moveList.Add(StompingTantrum.Instance);
            this._moveList.Add(Liquidation.Instance);
            this._moveList.Add(JawLock.Instance);
            this._moveList.Add(BodyPress.Instance);
            this._moveList.Add(ScaleShot.Instance);
            this._moveList.Add(MeteorBeam.Instance);
            this._moveList.Add(SkitterSmack.Instance);
        }
        #endregion
    }
}