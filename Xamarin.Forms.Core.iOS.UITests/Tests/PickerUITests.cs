using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Reflection;

using NUnit.Framework;

using Xamarin.Forms.CustomAttributes;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;
using Xamarin.UITest.iOS;

namespace Xamarin.Forms.Core.UITests
{
	[TestFixture]
	[Category ("Picker")]
	internal class PickerUITests : _ViewUITests
	{
		public PickerUITests ()
		{
			PlatformViewType = Views.Picker;
		}

		protected override void NavigateToGallery ()
		{
			App.NavigateToGallery (GalleryQueries.PickerGallery);
		}

		// TODO
		public override void _Focus () {}

		[UiTestExempt (ExemptReason.CannotTest, "Invalid interaction")]
		public override void _GestureRecognizers () {}
		
		// TODO
		public override void _IsFocused () {}

		// TODO
		public override void _UnFocus () {}

		// TODO
		// Implement control specific ui tests

		protected override void FixtureTeardown ()
		{
			App.NavigateBack ();
			base.FixtureTeardown ();
		}
	}
}