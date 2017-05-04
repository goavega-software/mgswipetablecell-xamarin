/*
 * MGSwipeTableCell.Xamarin is licensed under MIT license. See LICENSE.md file for more information.
 * Copyright (c) 2017 Goavega Software
 */
using System;
using ObjCRuntime;

namespace MGSwipeCell.Xamarin.Binding
{
	[Native]
	public enum MGSwipeTransition : long
	{
		Border = 0,
		Static,
		Drag,
		ClipCenter,
		Rotate3D
	}

	[Native]
	public enum MGSwipeDirection : long
	{
		LeftToRight = 0,
		RightToLeft
	}

	[Native]
	public enum MGSwipeState : long
	{
		None = 0,
		SwipingLeftToRight,
		SwipingRightToLeft,
		ExpandingLeftToRight,
		ExpandingRightToLeft
	}

	[Native]
	public enum MGSwipeExpansionLayout : long
	{
		Border = 0,
		Center
	}

	[Native]
	public enum MGSwipeEasingFunction : long
	{
		Linear = 0,
		QuadIn,
		QuadOut,
		QuadInOut,
		CubicIn,
		CubicOut,
		CubicInOut,
		BounceIn,
		BounceOut,
		BounceInOut
	}

}
