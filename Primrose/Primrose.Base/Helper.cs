﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Primrose.Base
{
    /// <summary>
    /// Contains all of my helper methods for either testing or general use.
    /// </summary>
    public static class Helper
    {

        // Fields:
        private static Dictionary<string, Texture2D> _gameTextures;

        // Properties: - NONE -

        // Methods:
        /// <summary>
        /// Alters the CullMode in the GraphicsDevice object.
        /// </summary>
        /// <param name="graphics">Reference to the GraphicsDevice object.</param>
        /// <param name="cullMode">Cull Mode being changed to.</param>
        public static void ChangeCullMode(GraphicsDevice graphics, CullMode cullMode)
        {
            // Creating a new RasterizerState.
            RasterizerState rasterizerState = new RasterizerState();

            // Changing the state of the Rasterizer.
            rasterizerState.CullMode = cullMode;

            // Setting the new rasterizer state to the GraphicsDevice.
            graphics.RasterizerState = rasterizerState;
        }

    }
}
