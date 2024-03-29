﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using OpenTK.Graphics.OpenGL;

namespace Engine
{
    /// <summary>
    /// A struct for an OpenGL texture
    /// </summary>
    public struct Texture : IDisposable
    {
        public int Handle;

        public static implicit operator int(Texture program)
        {
            return program.Handle;
        }

        public static implicit operator Texture(int handle)
        {
            return new Texture()
            {
                Handle = handle
            };
        }

        public static Texture Invalid
        {
            get { return -1; }
        }

        public void Dispose()
        {
            Debug.WriteLine("Disposing Texture...");

            GL.DeleteTexture(Handle);
        }
    }

    /// <summary>
    /// A struct for an OpenGL shader program
    /// </summary>
    public struct ShaderProgram : IDisposable
    {
        public int Handle;

        public static implicit operator int(ShaderProgram program)
        {
            return program.Handle;
        }

        public static implicit operator ShaderProgram(int handle)
        {
            return new ShaderProgram()
            {
                Handle = handle
            };
        }

        public static ShaderProgram Invalid
        {
            get
            {
                return -1;
            }
        }

        public void Dispose()
        {
            Debug.WriteLine("Disposing Shader...");

            GL.DeleteProgram(Handle);
        }
    }
}
