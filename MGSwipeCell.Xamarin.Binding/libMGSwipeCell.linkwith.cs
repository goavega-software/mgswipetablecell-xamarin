/*
 * MGSwipeTableCell.Xamarin is licensed under MIT license. See LICENSE.md file for more information.
 * Copyright (c) 2017 Goavega Software
 */
using ObjCRuntime;

[assembly: LinkWith("libMGSwipeCell.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64,
	SmartLink = true,
	ForceLoad = false,
	Frameworks = "UIKit Foundation CoreGraphics",
	LinkerFlags = "-ObjC")]