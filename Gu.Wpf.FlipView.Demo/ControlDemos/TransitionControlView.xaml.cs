﻿namespace Gu.Wpf.FlipView.Demo.ControlDemos
{
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Media;

    public partial class TransitionControlView : UserControl
    {
        public TransitionControlView()
        {
            this.InitializeComponent();
            this.Items = new[]
                         {
                             new TransitionItem(Brushes.Blue, "1"),
                             new TransitionItem(Brushes.Red, "2"),
                             new TransitionItem(Brushes.Yellow, "3"),
                         };
        }

        public IReadOnlyCollection<TransitionItem> Items { get; }
    }
}
