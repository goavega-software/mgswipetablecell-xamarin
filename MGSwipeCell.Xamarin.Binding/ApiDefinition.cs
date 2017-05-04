/*
 * MGSwipeTableCell.Xamarin is licensed under MIT license. See LICENSE.md file for more information.
 * Copyright (c) 2017 Goavega Software
 */
using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MGSwipeCell.Xamarin.Binding
{
	// @interface MGSwipeButton : UIButton
	[BaseType(typeof(UIButton))]
	interface MGSwipeButton
	{
		// @property (nonatomic, strong) MGSwipeButtonCallback _Nullable callback;
		[NullAllowed, Export("callback", ArgumentSemantic.Strong)]
		MGSwipeButtonCallback Callback { get; set; }

		// @property (assign, nonatomic) CGFloat buttonWidth;
		[Export("buttonWidth")]
		nfloat ButtonWidth { get; set; }

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color;
		[Static]
		[Export("buttonWithTitle:backgroundColor:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color padding:(NSInteger)padding;
		[Static]
		[Export("buttonWithTitle:backgroundColor:padding:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color, nint padding);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color insets:(UIEdgeInsets)insets;
		[Static]
		[Export("buttonWithTitle:backgroundColor:insets:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color, UIEdgeInsets insets);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:backgroundColor:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color, [NullAllowed] MGSwipeButtonCallback callback);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color padding:(NSInteger)padding callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:backgroundColor:padding:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color, nint padding, [NullAllowed] MGSwipeButtonCallback callback);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title backgroundColor:(UIColor * _Nullable)color insets:(UIEdgeInsets)insets callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:backgroundColor:insets:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIColor color, UIEdgeInsets insets, [NullAllowed] MGSwipeButtonCallback callback);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color padding:(NSInteger)padding;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:padding:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color, nint padding);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color insets:(UIEdgeInsets)insets;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:insets:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color, UIEdgeInsets insets);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color, [NullAllowed] MGSwipeButtonCallback callback);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color padding:(NSInteger)padding callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:padding:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color, nint padding, [NullAllowed] MGSwipeButtonCallback callback);

		// +(instancetype _Nonnull)buttonWithTitle:(NSString * _Nonnull)title icon:(UIImage * _Nullable)icon backgroundColor:(UIColor * _Nullable)color insets:(UIEdgeInsets)insets callback:(MGSwipeButtonCallback _Nullable)callback;
		[Static]
		[Export("buttonWithTitle:icon:backgroundColor:insets:callback:")]
		MGSwipeButton ButtonWithTitle(string title, [NullAllowed] UIImage icon, [NullAllowed] UIColor color, UIEdgeInsets insets, [NullAllowed] MGSwipeButtonCallback callback);

		// -(void)setPadding:(CGFloat)padding;
		[Export("setPadding:")]
		void SetPadding(nfloat padding);

		// -(void)setEdgeInsets:(UIEdgeInsets)insets;
		[Export("setEdgeInsets:")]
		void SetEdgeInsets(UIEdgeInsets insets);

		// -(void)centerIconOverText;
		[Export("centerIconOverText")]
		void CenterIconOverText();

		// -(void)centerIconOverTextWithSpacing:(CGFloat)spacing;
		[Export("centerIconOverTextWithSpacing:")]
		void CenterIconOverTextWithSpacing(nfloat spacing);

		// -(void)iconTintColor:(UIColor * _Nullable)tintColor;
		[Export("iconTintColor:")]
		void IconTintColor([NullAllowed] UIColor tintColor);
	}

	// typedef BOOL (^MGSwipeButtonCallback)(MGSwipeTableCell * _Nonnull);
	delegate bool MGSwipeButtonCallback(MGSwipeTableCell arg0);

	// @interface MGSwipeAnimation : NSObject
	[BaseType(typeof(NSObject))]
	interface MGSwipeAnimation
	{
		// @property (assign, nonatomic) CGFloat duration;
		[Export("duration")]
		nfloat Duration { get; set; }

		// @property (assign, nonatomic) MGSwipeEasingFunction easingFunction;
		[Export("easingFunction", ArgumentSemantic.Assign)]
		MGSwipeEasingFunction EasingFunction { get; set; }

		// -(CGFloat)value:(CGFloat)elapsed duration:(CGFloat)duration from:(CGFloat)from to:(CGFloat)to;
		[Export("value:duration:from:to:")]
		nfloat Value(nfloat elapsed, nfloat duration, nfloat from, nfloat to);
	}

	// @interface MGSwipeSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface MGSwipeSettings
	{
		// @property (assign, nonatomic) MGSwipeTransition transition;
		[Export("transition", ArgumentSemantic.Assign)]
		MGSwipeTransition Transition { get; set; }

		// @property (assign, nonatomic) CGFloat threshold;
		[Export("threshold")]
		nfloat Threshold { get; set; }

		// @property (assign, nonatomic) CGFloat offset;
		[Export("offset")]
		nfloat Offset { get; set; }

		// @property (assign, nonatomic) CGFloat topMargin;
		[Export("topMargin")]
		nfloat TopMargin { get; set; }

		// @property (assign, nonatomic) CGFloat bottomMargin;
		[Export("bottomMargin")]
		nfloat BottomMargin { get; set; }

		// @property (nonatomic, strong) MGSwipeAnimation * _Nonnull showAnimation;
		[Export("showAnimation", ArgumentSemantic.Strong)]
		MGSwipeAnimation ShowAnimation { get; set; }

		// @property (nonatomic, strong) MGSwipeAnimation * _Nonnull hideAnimation;
		[Export("hideAnimation", ArgumentSemantic.Strong)]
		MGSwipeAnimation HideAnimation { get; set; }

		// @property (nonatomic, strong) MGSwipeAnimation * _Nonnull stretchAnimation;
		[Export("stretchAnimation", ArgumentSemantic.Strong)]
		MGSwipeAnimation StretchAnimation { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration __attribute__((deprecated("")));
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }

		// @property (assign, nonatomic) BOOL keepButtonsSwiped;
		[Export("keepButtonsSwiped")]
		bool KeepButtonsSwiped { get; set; }

		// @property (assign, nonatomic) BOOL onlySwipeButtons;
		[Export("onlySwipeButtons")]
		bool OnlySwipeButtons { get; set; }

		// @property (assign, nonatomic) BOOL enableSwipeBounces;
		[Export("enableSwipeBounces")]
		bool EnableSwipeBounces { get; set; }

		// @property (assign, nonatomic) CGFloat swipeBounceRate;
		[Export("swipeBounceRate")]
		nfloat SwipeBounceRate { get; set; }
	}

	// @interface MGSwipeExpansionSettings : NSObject
	[BaseType(typeof(NSObject))]
	interface MGSwipeExpansionSettings
	{
		// @property (assign, nonatomic) NSInteger buttonIndex;
		[Export("buttonIndex")]
		nint ButtonIndex { get; set; }

		// @property (assign, nonatomic) BOOL fillOnTrigger;
		[Export("fillOnTrigger")]
		bool FillOnTrigger { get; set; }

		// @property (assign, nonatomic) CGFloat threshold;
		[Export("threshold")]
		nfloat Threshold { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable expansionColor;
		[NullAllowed, Export("expansionColor", ArgumentSemantic.Strong)]
		UIColor ExpansionColor { get; set; }

		// @property (assign, nonatomic) MGSwipeExpansionLayout expansionLayout;
		[Export("expansionLayout", ArgumentSemantic.Assign)]
		MGSwipeExpansionLayout ExpansionLayout { get; set; }

		// @property (nonatomic, strong) MGSwipeAnimation * _Nonnull triggerAnimation;
		[Export("triggerAnimation", ArgumentSemantic.Strong)]
		MGSwipeAnimation TriggerAnimation { get; set; }

		// @property (assign, nonatomic) CGFloat animationDuration;
		[Export("animationDuration")]
		nfloat AnimationDuration { get; set; }
	}

	// @protocol MGSwipeTableCellDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MGSwipeTableCellDelegate
	{
		// @optional -(BOOL)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell canSwipe:(MGSwipeDirection)direction fromPoint:(CGPoint)point;
		[Export("swipeTableCell:canSwipe:fromPoint:")]
		bool SwipeTableCell(MGSwipeTableCell cell, MGSwipeDirection direction, CGPoint point);

		// @optional -(BOOL)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell canSwipe:(MGSwipeDirection)direction __attribute__((deprecated("")));
		[Export("swipeTableCell:canSwipe:")]
		bool SwipeTableCell(MGSwipeTableCell cell, MGSwipeDirection direction);

		// @optional -(void)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell didChangeSwipeState:(MGSwipeState)state gestureIsActive:(BOOL)gestureIsActive;
		[Export("swipeTableCell:didChangeSwipeState:gestureIsActive:")]
		void SwipeTableCell(MGSwipeTableCell cell, MGSwipeState state, bool gestureIsActive);

		// @optional -(BOOL)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell tappedButtonAtIndex:(NSInteger)index direction:(MGSwipeDirection)direction fromExpansion:(BOOL)fromExpansion;
		[Export("swipeTableCell:tappedButtonAtIndex:direction:fromExpansion:")]
		bool SwipeTableCell(MGSwipeTableCell cell, nint index, MGSwipeDirection direction, bool fromExpansion);

		// @optional -(NSArray<UIView *> * _Nullable)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell swipeButtonsForDirection:(MGSwipeDirection)direction swipeSettings:(MGSwipeSettings * _Nonnull)swipeSettings expansionSettings:(MGSwipeExpansionSettings * _Nonnull)expansionSettings;
		[Export("swipeTableCell:swipeButtonsForDirection:swipeSettings:expansionSettings:")]
		[return: NullAllowed]
		UIView[] SwipeTableCell(MGSwipeTableCell cell, MGSwipeDirection direction, MGSwipeSettings swipeSettings, MGSwipeExpansionSettings expansionSettings);

		// @optional -(BOOL)swipeTableCell:(MGSwipeTableCell * _Nonnull)cell shouldHideSwipeOnTap:(CGPoint)point;
		[Export("swipeTableCell:shouldHideSwipeOnTap:")]
		bool SwipeTableCell(MGSwipeTableCell cell, CGPoint point);

		// @optional -(void)swipeTableCellWillBeginSwiping:(MGSwipeTableCell * _Nonnull)cell;
		[Export("swipeTableCellWillBeginSwiping:")]
		void SwipeTableCellWillBeginSwiping(MGSwipeTableCell cell);

		// @optional -(void)swipeTableCellWillEndSwiping:(MGSwipeTableCell * _Nonnull)cell;
		[Export("swipeTableCellWillEndSwiping:")]
		void SwipeTableCellWillEndSwiping(MGSwipeTableCell cell);
	}

	// @interface MGSwipeTableCell : UITableViewCell
	[BaseType(typeof(UITableViewCell))]
	interface MGSwipeTableCell
	{
		[Export("initWithStyle:reuseIdentifier:")]
		IntPtr Constructor(UITableViewCellStyle style, string identifier);
		[Wrap("WeakDelegate")]
		[NullAllowed]
		MGSwipeTableCellDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<MGSwipeTableCellDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull swipeContentView;
		[Export("swipeContentView", ArgumentSemantic.Strong)]
		UIView SwipeContentView { get; }

		// @property (copy, nonatomic) NSArray<UIView *> * _Nonnull leftButtons;
		[Export("leftButtons", ArgumentSemantic.Copy)]
		UIView[] LeftButtons { get; set; }

		// @property (copy, nonatomic) NSArray<UIView *> * _Nonnull rightButtons;
		[Export("rightButtons", ArgumentSemantic.Copy)]
		UIView[] RightButtons { get; set; }

		// @property (nonatomic, strong) MGSwipeSettings * _Nonnull leftSwipeSettings;
		[Export("leftSwipeSettings", ArgumentSemantic.Strong)]
		MGSwipeSettings LeftSwipeSettings { get; set; }

		// @property (nonatomic, strong) MGSwipeSettings * _Nonnull rightSwipeSettings;
		[Export("rightSwipeSettings", ArgumentSemantic.Strong)]
		MGSwipeSettings RightSwipeSettings { get; set; }

		// @property (nonatomic, strong) MGSwipeExpansionSettings * _Nonnull leftExpansion;
		[Export("leftExpansion", ArgumentSemantic.Strong)]
		MGSwipeExpansionSettings LeftExpansion { get; set; }

		// @property (nonatomic, strong) MGSwipeExpansionSettings * _Nonnull rightExpansion;
		[Export("rightExpansion", ArgumentSemantic.Strong)]
		MGSwipeExpansionSettings RightExpansion { get; set; }

		// @property (readonly, nonatomic) MGSwipeState swipeState;
		[Export("swipeState")]
		MGSwipeState SwipeState { get; }

		// @property (readonly, nonatomic) BOOL isSwipeGestureActive;
		[Export("isSwipeGestureActive")]
		bool IsSwipeGestureActive { get; }

		// @property (nonatomic) BOOL allowsMultipleSwipe;
		[Export("allowsMultipleSwipe")]
		bool AllowsMultipleSwipe { get; set; }

		// @property (nonatomic) BOOL allowsButtonsWithDifferentWidth;
		[Export("allowsButtonsWithDifferentWidth")]
		bool AllowsButtonsWithDifferentWidth { get; set; }

		// @property (nonatomic) BOOL allowsSwipeWhenTappingButtons;
		[Export("allowsSwipeWhenTappingButtons")]
		bool AllowsSwipeWhenTappingButtons { get; set; }

		// @property (nonatomic) BOOL allowsOppositeSwipe;
		[Export("allowsOppositeSwipe")]
		bool AllowsOppositeSwipe { get; set; }

		// @property (nonatomic) BOOL preservesSelectionStatus;
		[Export("preservesSelectionStatus")]
		bool PreservesSelectionStatus { get; set; }

		// @property (nonatomic) BOOL touchOnDismissSwipe;
		[Export("touchOnDismissSwipe")]
		bool TouchOnDismissSwipe { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable swipeBackgroundColor;
		[NullAllowed, Export("swipeBackgroundColor", ArgumentSemantic.Strong)]
		UIColor SwipeBackgroundColor { get; set; }

		// @property (assign, nonatomic) CGFloat swipeOffset;
		[Export("swipeOffset")]
		nfloat SwipeOffset { get; set; }

		// -(void)hideSwipeAnimated:(BOOL)animated;
		[Export("hideSwipeAnimated:")]
		void HideSwipeAnimated(bool animated);

		// -(void)hideSwipeAnimated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export("hideSwipeAnimated:completion:")]
		void HideSwipeAnimated(bool animated, [NullAllowed] Action<bool> completion);

		// -(void)showSwipe:(MGSwipeDirection)direction animated:(BOOL)animated;
		[Export("showSwipe:animated:")]
		void ShowSwipe(MGSwipeDirection direction, bool animated);

		// -(void)showSwipe:(MGSwipeDirection)direction animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export("showSwipe:animated:completion:")]
		void ShowSwipe(MGSwipeDirection direction, bool animated, [NullAllowed] Action<bool> completion);

		// -(void)setSwipeOffset:(CGFloat)offset animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
		[Export("setSwipeOffset:animated:completion:")]
		void SetSwipeOffset(nfloat offset, bool animated, [NullAllowed] Action<bool> completion);

		// -(void)setSwipeOffset:(CGFloat)offset animation:(MGSwipeAnimation * _Nullable)animation completion:(void (^ _Nullable)(BOOL))completion;
		[Export("setSwipeOffset:animation:completion:")]
		void SetSwipeOffset(nfloat offset, [NullAllowed] MGSwipeAnimation animation, [NullAllowed] Action<bool> completion);

		// -(void)expandSwipe:(MGSwipeDirection)direction animated:(BOOL)animated;
		[Export("expandSwipe:animated:")]
		void ExpandSwipe(MGSwipeDirection direction, bool animated);

		// -(void)refreshContentView;
		[Export("refreshContentView")]
		void RefreshContentView();

		// -(void)refreshButtons:(BOOL)usingDelegate;
		[Export("refreshButtons:")]
		void RefreshButtons(bool usingDelegate);
	}
}
