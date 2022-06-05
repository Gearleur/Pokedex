using Pokedex.Enums;

namespace Pokedex.Models
{
    class DamageHandler
    {
        #region Constructors
        /// <summary>
        /// Disable instanciation
        /// </summary>
        private DamageHandler() { }
        #endregion

        #region Methods
        /// <summary>
        /// Method to calculate damage
        /// </summary>
        /// <param name="attacker">Pokemon attacking</param>
        /// <param name="defender">Pokemon attacked</param>
        /// <param name="move">Move use during attack</param>
        /// <param name="weather">Current weather</param>
        /// <returns></returns>
        public static int CalcDamage
		(
			PokeInstance attacker,
			PokeInstance defender,
			PokeMove move,
			Weather weather
		)
        {
            // Initial damage
            double damage = (0.4 * attacker.Level + 2) * move.Power;

            // Adjust for stats
            if (move.Damage == DamageClass.Physical)
                damage *= ((double)attacker.Pokemon.StatAttack / defender.Pokemon.StatDefense);
            else
                damage *= ((double)attacker.Pokemon.StatSpecialAttack / defender.Pokemon.StatSpecialDefense);

            // Continue the calculation
            damage = damage / 50 + 2;

            // Apply STAB - Same Type Attack Bonus
            if (defender.Pokemon.Types.Item1 == move.Type
                || defender.Pokemon.Types.Item2 == move.Type)
                damage *= 1.5;

            // Apply type weaknesses
            damage *= defender.Pokemon.Types.Item1.GetAffinity(move.Type)
                   * (defender.Pokemon.Types.Item2?.GetAffinity(move.Type) ?? 1);
            /* value?.member -> access member if and only if value != null */

			// Apply the weather
			damage = weather.OnDamageGive(damage, move.Type);

            // Floor the result
            return (int)(damage);
        }
        #endregion
    }
}