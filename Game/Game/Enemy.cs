using SharpGL;
using SharpGL.SceneGraph.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace Game
{
    internal class Enemy
    {

        Texture enemyTexture = new Texture();
        
        
        public float rota, rotb;
        float[] color = new float[3];
        float[] color2 = new float[3];

        public float Rota { get { return rota;  } set{ rota = value;  } }
        public float Rotb { get { return rotb; } set{ rotb = value; } }

        public float [] Color { get { return color; }set { color = value; } }
        public float[] Color2 { get { return color2; }set { color = value; } }

        public Enemy (float rota, float rotb, float[] color, float[] color2)
        {
            this.rota = rota;
            this.rotb = rotb;
            this.color = color;
            this.color2 = color2;
        }

        
        
        public void drawEnemy(double a, double b, double c)
        {
            Enemy enemy = new Enemy(rota, rotb, color, color2); 
            OpenGL gl = new OpenGL();
            gl.LoadIdentity();
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            enemyTexture.Create(gl, @"../../files/ufo.jpg");
            enemyTexture.Bind(gl);
           
            gl.Translate(a + rota, b + rotb, c); 
            gl.Color(1.0, 1.0, 1.0, 1.0);
            gl.Begin(OpenGL.GL_QUADS);

            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, 1.0f);
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f, -1.0f);
            gl.End();
            
            gl.Disable(OpenGL.GL_TEXTURE_2D);
            gl.LoadIdentity();
            gl.Translate(a + rota, b + rotb +0.7f, -7f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(color);
            gl.Vertex(-0.1f, 0.1f);
            gl.Vertex(0.1f, 0.1f);
            gl.Vertex(0.1f, -0.1f);
            gl.Vertex(-0.1f, -0.1f);
            gl.End();
            

            gl.Disable(OpenGL.GL_TEXTURE_2D);
            gl.LoadIdentity();
            gl.Translate(a + rota+0.3f, b + rotb + 0.7f, -7f);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(color2);
            gl.Vertex(-0.1f, 0.1f);
            gl.Vertex(0.1f, 0.1f);
            gl.Vertex(0.1f, -0.1f);
            gl.Vertex(-0.1f, -0.1f);
            gl.End();
            gl.Flush();
            

        }
    }
}
