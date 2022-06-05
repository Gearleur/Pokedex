namespace Pokedex.Models.Types
{
    internal class TypeSteel : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeSteel? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeSteel Instance
        {
            get { return _instance ?? (_instance = new TypeSteel()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeSteel()
            : base("Steel", "Acier", "9EB7B8")
        { }
        #endregion

        #region Methods
        /// <summary>
        /// Implementation of the parent method
        /// </summary>
        /// <seealso cref="PokeType.InitTypeAffinities"/>
        protected override void InitTypeAffinities()
        {
            this._typeAffinities = new Dictionary<PokeType, double>();
            this._typeAffinities.Add(TypePoison.Instance, 0);
            this._typeAffinities.Add(TypeFighting.Instance, 2);
            this._typeAffinities.Add(TypeFire.Instance, 2);
            this._typeAffinities.Add(TypeGround.Instance, 2);
            this._typeAffinities.Add(TypeBug.Instance, 0.5);
            this._typeAffinities.Add(TypeDragon.Instance, 0.5);
            this._typeAffinities.Add(TypeFairy.Instance, 0.5);
            this._typeAffinities.Add(TypeFlying.Instance, 0.5);
            this._typeAffinities.Add(TypeGrass.Instance, 0.5);
            this._typeAffinities.Add(TypeIce.Instance, 0.5);
            this._typeAffinities.Add(TypeNormal.Instance, 0.5);
            this._typeAffinities.Add(TypeRock.Instance, 0.5);
            this._typeAffinities.Add(TypeSteel.Instance, 0.5);
        }
        #endregion
    }
}
