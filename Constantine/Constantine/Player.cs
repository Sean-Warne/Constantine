﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using GameEngineLibrary;

namespace Constantine
{
    public class Player
    {

        #region Field Region
        Camera camera;
        Game1 gameRef;
        #endregion

        #region Property Region
        public Camera Camera
        {
            get { return camera; }
            set { camera = value; }
        }
        #endregion

        #region Constructor Region
        public Player(Game game)
        {
            gameRef = (Game1)game;
            camera = new Camera(gameRef.ScreenBounds);
        }
        #endregion

        #region Method Region
        public void Update(GameTime gameTime)
        {
            camera.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
        }
        #endregion
    }
}
