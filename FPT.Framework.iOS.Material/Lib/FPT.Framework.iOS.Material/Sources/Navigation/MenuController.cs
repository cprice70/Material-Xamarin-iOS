﻿//// MIT/X11 License
////
//// MenuController.cs
////
//// Author:
////       Pham Quan <QuanP@fpt.com.vn, mr.pquan@gmail.com> at FPT Software Service Center.
////
//// Copyright (c) 2016 FPT Information System.
////
//// Permission is hereby granted, free of charge, to any person obtaining a copy
//// of this software and associated documentation files (the "Software"), to deal
//// in the Software without restriction, including without limitation the rights
//// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//// copies of the Software, and to permit persons to whom the Software is
//// furnished to do so, subject to the following conditions:
////
//// The above copyright notice and this permission notice shall be included in
//// all copies or substantial portions of the Software.
////
//// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//// THE SOFTWARE.
//using System;
//using UIKit;
//using Foundation;
//namespace FPT.Framework.iOS.Material
//{

//	public static partial class Extensions
//	{
//		public static MenuController MenuController(this UIViewController viewController)
//		{
//			while (viewController != null)
//			{
//				if (viewController is MenuController)
//				{
//					return viewController as MenuController;
//				}
//				viewController = viewController.ParentViewController;
//			}
//			return null;
//		}
//	}

//	public class MenuController : RootController
//	{

//		#region PROPERTIES

//		public MenuView MenuView { get; private set; } = new MenuView();

//		#endregion

//		#region CONSTRUCTORS

//		public MenuController(NSCoder coder) : base(coder)
//		{
//		}

//		#endregion

//	}
//}
