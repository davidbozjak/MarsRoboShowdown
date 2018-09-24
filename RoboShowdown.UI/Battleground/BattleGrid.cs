using RoboShowdown.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RoboShowdown.UI.Battleground
{
    public class BattleGrid : Grid
    {
        private readonly BattlegroundControlSelector selector = new BattlegroundControlSelector();

        public void Reset(int width, int height)
        {
            this.RowDefinitions.Clear();
            Enumerable.Range(0, width).Select(w => new RowDefinition()).ToList().ForEach(this.RowDefinitions.Add);

            this.ColumnDefinitions.Clear();
            Enumerable.Range(0, height).Select(w => new ColumnDefinition()).ToList().ForEach(this.ColumnDefinitions.Add);

            this.Children.Clear();
        }

        public void DrawBattleState(IEnumerable<IBattlegroundObject> objects)
        {
            this.Children.Clear();

            objects
                .Select(w => new { ViewModel = w, Control = selector.GetControlForViewModel(w) })
                .ToList()
                .ForEach(w =>
                {
                    this.Children.Add(w.Control);
                    SetColumn((FrameworkElement)w.Control, w.ViewModel.XOffset);
                    SetRow((FrameworkElement)w.Control, w.ViewModel.YOffset);
                });
        }
    }
}
