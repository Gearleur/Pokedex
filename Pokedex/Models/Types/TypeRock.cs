namespace Pokedex.Models.Types
{
    internal class TypeRock : PokeType
    {
        #region Variables
        /// <summary>
        /// Nullable variable (use of ? after type)
        /// </summary>
        private static TypeRock? _instance = null;
        #endregion

        #region Getters + Setters
        /// <summary>
        /// If no instance, create it
        /// </summary>
        public static TypeRock Instance
        {
            get { return _instance ?? (_instance = new TypeRock()); }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Private constructor. Can't be called outside this class
        /// </summary>
        private TypeRock()
            : base("Rock", "Roche", "A38C21")
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
            this._typeAffinities.Add(TypeFighting.Instance, 2);
            this._typeAffinities.Add(TypeGrass.Instance, 2);
            this._typeAffinities.Add(TypeGround.Instance, 2);
            this._typeAffinities.Add(TypeSteel.Instance, 2);
            this._typeAffinities.Add(TypeWater.Instance, 2);
            this._typeAffinities.Add(TypeFire.Instance, 0.5);
            this._typeAffinities.Add(TypeFlying.Instance, 0.5);
            this._typeAffinities.Add(TypeNormal.Instance, 0.5);
            this._typeAffinities.Add(TypePoison.Instance, 0.5);
        }
        #endregion
    }
}
