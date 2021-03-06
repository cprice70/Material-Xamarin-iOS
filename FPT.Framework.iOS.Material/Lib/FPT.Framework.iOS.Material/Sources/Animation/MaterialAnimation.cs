﻿using System;
using Foundation;
using CoreAnimation;
using CoreFoundation;
namespace FPT.Framework.iOS.Material
{
	//optional func materialAnimationDidStart(animation: CAAnimation)

	//optional func materialAnimationDidStop(animation: CAAnimation, finished flag: Bool)

	public partial class Convert
	{
		public static string MaterialAnimationFillModeToValue(MaterialAnimationFillMode mode)
		{
			switch (mode)
			{
				case MaterialAnimationFillMode.Forwards:
					return CAFillMode.Forwards;
				case MaterialAnimationFillMode.Backwards:
					return CAFillMode.Backwards;
				case MaterialAnimationFillMode.Both:
					return CAFillMode.Both;
				case MaterialAnimationFillMode.Removed:
					return CAFillMode.Removed;
				default:
					return default(string);
			}
		}
	}

	//public abstract class MaterialAnimationDelegate : MaterialDelegate
	//{
	//	public virtual void materialAnimationDidStart(CAAnimation animation) { }
	//	public virtual void materialAnimationDidStop(CAAnimation animation, bool finished) { }
	//}

	public enum MaterialAnimationFillMode
	{
		Forwards, Backwards, Both, Removed
	}

	public delegate void MaterialAnimationDelayCancelBlock(bool cancel);

	public static partial class Animation
	{
		private const int NSEC_PER_SEC = 1000000000;

		private static void dispatch_later(double time, Action completion)
		{
			DispatchQueue.MainQueue.DispatchAfter(new DispatchTime(DispatchTime.Now, (long)time * NSEC_PER_SEC), completion);
		}

		public static MaterialAnimationDelayCancelBlock Delay(double time, Action completion)
		{
			MaterialAnimationDelayCancelBlock cancelable;

			MaterialAnimationDelayCancelBlock delayed = (cancel) =>
			{
				if (!cancel)
				{
					DispatchQueue.MainQueue.DispatchAsync(completion);
				}
				cancelable = null;
			};

			cancelable = delayed;

			DispatchQueue.MainQueue.DispatchAfter(new DispatchTime(DispatchTime.Now, (long)time * NSEC_PER_SEC), () =>
			{
				cancelable(cancel: false);
			});

			//dispatch_later(time, () =>
			//{
			//	cancelable(cancel: false);
			//});

			return cancelable;
		}

		public static void DelayCancel(MaterialAnimationDelayCancelBlock completion)
		{
			if (completion != null)
				completion(true);
		}

		public static void AnimationDisabled(Action animations)
		{
			AnimateWithDuration(0, animations);
		}

		public static void AnimateWithDuration(double duration, Action animations, Action completion = null)
		{
			CATransaction.Begin();
			CATransaction.AnimationDuration = duration;
			CATransaction.CompletionBlock = completion;
			CATransaction.AnimationTimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
			animations();
			CATransaction.Commit();
		}

		public static CAAnimationGroup AnimationGroup(CAAnimation[] animations, double? duration = 0.5)
		{
			var group = new CAAnimationGroup();
			group.FillMode = Convert.MaterialAnimationFillModeToValue(MaterialAnimationFillMode.Forwards);
			group.RemovedOnCompletion = false;
			group.Animations = animations;
			group.Duration = duration.Value;
			group.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseInEaseOut);
			return group;
		}

		public static void AnimateWithDelay(double delay, double duration, Action animations, Action completion)
		{
			Delay(delay, () =>
			{
				AnimateWithDuration(duration, animations, completion);
			});
		}
	}
}
