﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpGL;

namespace c02d002DTexture
{
    partial class CubeNode
    {
        private const string vertexCode = @"
#version 150

in vec3 inPosition;
in vec2 inUV;

uniform mat4 mvpMatrix;

out vec2 passUV;

void main() {
    gl_Position = mvpMatrix * vec4(inPosition, 1.0); 

    passUV = inUV;
}
";

        private const string fragmnetCode = @"
#version 150

//uniform vec4 color = vec4(1, 0, 0, 1); // default: red color.
uniform sampler2D tex;

in vec2 passUV;

out vec4 outColor;

void main() {
    //outColor = color;
    outColor = texture(tex, passUV);
}
";
    }
}
