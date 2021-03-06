﻿// MIT/X11 License
//
// FlatButton.cs
//
// Author:
//       Pham Quan <QuanP@fpt.com.vn, mr.pquan@gmail.com> at FPT Software Service Center.
//
// Copyright (c) 2016 FPT Information System.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace FPT.Framework.iOS.Material
{
	[Register("FlatButton")]
	public class FlatButton : Button
	{
		protected FlatButton(IntPtr handle) : base(handle) { }
		public FlatButton(CGRect frame) : base(frame) { }
		public FlatButton() : base() { }
		public FlatButton(UIImage image, UIColor tintColor = null) : base(image, tintColor) { }
		public FlatButton(String title, UIColor titleColor = null) : base(title, titleColor) { }

		public override void Prepare()
		{
			base.Prepare();
			this.SetCornerRadiusPreset(CornerRadiusPreset.Radius1);
			this.ContentEdgeInsetsPreset = EdgeInsetsPreset.WideRectangle3;
		}
	}
}
