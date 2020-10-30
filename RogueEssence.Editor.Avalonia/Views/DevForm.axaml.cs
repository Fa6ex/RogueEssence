﻿using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Input;
using Avalonia.Interactivity;
using System;
using RogueEssence;
using RogueEssence.Dev;
using Microsoft.Xna.Framework;

namespace RogueEssence.Dev.Views
{
    public class DevForm : Window, IRootEditor
    {
        public bool LoadComplete { get; private set; }

        //private MapEditor mapEditor;
        //private GroundEditor groundEditor;

        public IMapEditor MapEditor => null;
        public IGroundEditor GroundEditor => null;
        public bool AteMouse { get { return false; } }
        public bool AteKeyboard { get { return false; } }




        public DevForm()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


        void IRootEditor.Load(GameBase game)
        {

            Show();
        }
        public void Update(GameTime gameTime) { }
        public void Draw() { }

        public void OpenGround()
        {

        }


        public void CloseGround()
        {

        }

        public void Window_Loaded(object sender, EventArgs e)
        {
            LoadComplete = true;
        }

        public void Window_Closed(object sender, EventArgs e)
        {
        }
    }
}
