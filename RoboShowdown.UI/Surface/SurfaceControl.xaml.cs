﻿using RoboShowdown.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace RoboShowdown.UI.Surface
{
    public sealed partial class SurfaceControl : UserControl
    {
        private IBattlegroundTile tile;
        public IBattlegroundTile Tile
        {
            get => this.tile;
            set => this.SetTile(value);
        }

        public bool DrawRobot => this.tile?.Robot != null;

        public SurfaceControl()
        {
            this.InitializeComponent();
        }

        void SetTile(IBattlegroundTile newValue)
        {
            this.tile = newValue;

            this.Bindings.Update();
        }
    }
}
