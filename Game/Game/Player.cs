using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using SharpGL;
using SharpGL.Enumerations;
using SharpGL.SceneGraph.Assets;


namespace Game
{

    internal class Player
    {
        

        Texture playerTexture = new Texture();

      
        public int score;
        public int Score { get { return score; } set { score = value; } }
        
      
        public int health;

        public int Health {
           get
            {
                return this.Health;
            }
            set
            {
                this.health = value;
            }
        }
        public Player(int health, int score) {

            this.health = health;
            this.score = score;
            
            
        }

        public void drawPlayer()
        {
            Player play = new Player(5, 0);
            OpenGL gl = new OpenGL();
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();           
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            
            playerTexture.Create(gl, @"../../files/astro.jpg");

            playerTexture.Bind(gl);
          
            gl.Translate(0.0f, 0.0f, -8.0f); 
            gl.Begin(OpenGL.GL_QUADS);
            gl.Color(1.0, 1.0, 1.0, 1.0);  
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(-1.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(1.0f, 1.0f);
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(1.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(-1.0f,-1.0f);
            
            gl.End();
            gl.Flush();


        }
      
    }
}
