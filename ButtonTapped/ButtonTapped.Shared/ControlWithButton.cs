using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Uno.Extensions;
using Windows.Foundation;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace ButtonTapped
{
	public partial class ControlWithButton : Control
	{
		private const string NextButtonPartName = "PART_NextButton";
		
		private Button _nextBtn;

		public ControlWithButton()
		{
			this.DefaultStyleKey = typeof(ControlWithButton);
		}

		[System.Diagnostics.CodeAnalysis.SuppressMessage("", "NV0114", Justification = "No other solution")]
		protected override void OnApplyTemplate()
		{
			_nextBtn = GetTemplateChild(NextButtonPartName) as Button;
			_nextBtn.Tapped -= OnNextButtonTapped;
			_nextBtn.Tapped += OnNextButtonTapped;

			base.OnApplyTemplate();
		}

		private void OnNextButtonTapped(object sender, RoutedEventArgs e)
		{
			_nextBtn.Content = "Tapped event detected!";
		}
	}
}
