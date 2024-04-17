using System;
using Engine.Models;
namespace Engine.Actions
{
	public class Heal : BaseAction, IAction
	{
		private readonly GameItem _item;
		private readonly int _hitPointsToHeal;
		public event EventHandler<string> OnActionPerformed;
		public Heal(GameItem itemInUse, int hitPointsToHeal)
		{
			if (itemInUse.Category != GameItem.ItemCategory.Consumable): base(itemInUse)
			{
				throw new ArgumentException($"{itemInUse.Name} is not consumable");
			}
			_hitPointsToHeal = hitPointsToHeal;
		}
		public void Execute(LivingEntity actor, LivingEntity target)
		{
			string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
			string targetName = (target is Player) ? "yourself" : $"the {target.Name.ToLower()}";
			ReportResult($"{actorName} heal {targetName} for {_hitPointsToHeal} point{(_hitPointsToHeal > 1 ? "s" : "")}.");
			target.Heal(_hitPointsToHeal);
		}
		private void ReportResult(string result)
		{
			OnActionPerformed?.Invoke(this, result);
		}
	}
}