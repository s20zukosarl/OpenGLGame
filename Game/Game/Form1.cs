using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using SharpGL;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows;
using System.Media;
using MessageBox = System.Windows.Forms.MessageBox;
using Application = System.Windows.Forms.Application;
using Tulpep.NotificationWindow;
using System.Windows.Controls.Primitives;
using Color = System.Drawing.Color;
using FontStyle = System.Drawing.FontStyle;
using System.Windows.Documents;

namespace Game
{
    public partial class Form1 : Form
    {
        Player mainPlayer = new Player(5, 0);
        Music loopMusic = new Music();
        public static float[] red = new float[3] { 1.0f, 0f, 0f };
        public static float[] green = new float[3] { 0.0f, 1f, 0f };
        public static float[] pink = new float[3] { 1f, 0f, 1f };
        public static float[] blue = new float[3] { 0f, 0f, 1f };
        public static float[] yellow = new float[3] { 1f, 1f, 0f };
        public static float[] black = new float[3] { 0f, 0f, 0f };
        public static float[] lightGreen = new float[3] { 0f, 1f, 1f };

        Enemy enemyOne = new Enemy(0f,0f,green , pink);        
        Enemy enemyTwo = new Enemy(0f,0f,blue, lightGreen);       
        Enemy enemyThree = new Enemy(0f,0f, red, lightGreen);
        Enemy enemyFour = new Enemy(0f,0f, red, yellow);       
        Enemy enemyFive = new Enemy(0f,0f, green, pink);

        int gameLevel = 0;
        bool gameRunning = true;
        
 
        public Form1()
        {
            InitializeComponent();
            
        }

        
        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            
            OpenGL gl = openGLControl1.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
         
            if (gameRunning) { 
            mainPlayer.drawPlayer();

                if (gameLevel == 0)
                {
                    gameRunning = false;
                    MessageBox.Show(" Fight aliens using letters.Every alien has their " +
                        "protection cubes. Every colored protection cube has " +
                        "a corresponding letter. Click to exit. Ready to play?");
                    gameRunning = true;
                    gameLevel = 1;

                }
                else if(gameLevel == 1)
                {
                    enTwo();
                }
                else if (gameLevel == 2)
                {
                    enOne();
                    enFour();
                }
                else if (gameLevel == 3)
                {
                    enTwo();
                    enOne();
                    enFour();
                }
                else if (gameLevel == 4)
                {
                    enTwo();
                    enOne();
                    enFour();
                    enThree();
                }
                else if(gameLevel == 5)
                {
                    enTwo();
                    enOne();
                    enFour();
                    enThree();
                    enFive();
                }
               
                if (mainPlayer.score > 5)
                {
                    gameLevel = 2;
                    
                    level.Text = "Level: " + gameLevel;
                }
                if (mainPlayer.score > 15)
                {
                    gameLevel = 3;
                    level.Text = "Level: " + gameLevel;
                }
                if(mainPlayer.score > 25)
                {
                    gameLevel = 4;
                    level.Text = "Level: " + gameLevel;
                }

                if (mainPlayer.score > 50)
                {
                    gameLevel = 5;
                    level.Text = "Level: " + gameLevel;
                }
                
                if (mainPlayer.score >= 75)
                {
                    gameRunning = false;
                    MessageBox.Show("You won! Congratulations!");
                    Application.Exit();
                }
                
                if (mainPlayer.health < 0)
                {
                    gameRunning = false;                    
                    MessageBox.Show("Game Over");
                    Application.Exit();

                }
                
            }

        }

        private void openGLControl1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            MessageBox.Show("Paldies par spēli!");
            Application.Exit();

        }

     
        private void openGLControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.K)
            {
                changeColor(black, enemyOne);
                changeColor(black, enemyFive);
            }
            
            else if (e.KeyCode == Keys.D)
            {
                changeColor(black, enemyThree);
                changeColor(black, enemyFour);
            }
            
            else if (e.KeyCode == Keys.M)
            {
                changeColor(black, enemyTwo);
            }
            
            else if (e.KeyCode == Keys.L)
            {
                if (enemyOne.Color == black || enemyFive.Color == black)
                {
                   
                    setBack(enemyOne);
                    setBack(enemyFive);
                    addPoints();
                    changeColor(green, enemyOne);
                    changeColor(green, enemyFive);
                }           
            }
            else if (e.KeyCode == Keys.C)
            {
                if (enemyTwo.Color == black || enemyFour.Color == black)
                {

                    setBack(enemyFour);
                    addPoints();
                    changeColor(red, enemyFour);
                }
            }

            else if (e.KeyCode == Keys.S)
            {
                if(enemyThree.Color == black || enemyTwo.Color == black)
                {
                    setBack(enemyThree);
                    setBack(enemyTwo);
                    addPoints();
                    changeColor(blue, enemyTwo);
                    changeColor(red, enemyThree);
                }               
            }           
        }

       

        private void openGLControl1_Load(object sender, EventArgs e)
        {
            loopMusic.playMusic();
            lives.Text = "Lives: " + mainPlayer.health;
            score.Text = "Score: " + mainPlayer.score;
            level.Text = "Level: " + gameLevel;
        }

        private void label_Click(object sender, EventArgs e)
        {
        }

        private void addPoints()
        {
            mainPlayer.score += 1;
            score.Text = "Score: " + mainPlayer.score;
        }

        private void takeLives()
        {
            mainPlayer.health -= 1;
            lives.Text = "Lives: " + mainPlayer.health;
        }

        private void enOne()
        {
            enemyOne.drawEnemy(-5.5, -2.0, -7.0);
            enemyOne.Rota += 0.008f;
            enemyOne.Rotb += 0.002f;
            
            if (enemyOne.Rota >= 2.9f)
            {
  
                setBack(enemyOne);
                changeColor(green, enemyOne);
                takeLives();
            }
        }
        
        private void enTwo()
        {
            enemyTwo.drawEnemy(5f, 0.0, -7.0);
            enemyTwo.rota -= 0.015f;
            
            if (enemyTwo.rota <= -2.3f)
            {
                setBack(enemyTwo);
                takeLives();
                changeColor(blue, enemyTwo);
            }
        }
        
        private void enThree()
        {
            enemyThree.drawEnemy(-5.5f, 1.5f, -7.0);
            enemyThree.rota += 0.08f;
            enemyThree.rotb -= 0.02f;

            if (enemyThree.rota >= 3.9f)
            {
                setBack(enemyThree);
                changeColor(red, enemyThree);
                takeLives();
            }
        }

        private void enFour()
        {
            enemyFour.drawEnemy(4.5f, -2.0f, -7.0);
            enemyFour.rota -= 0.008f;
            enemyFour.rotb += 0.002f;
            if (enemyFour.rota <= -3.0f)
            {
                setBack(enemyFour);
                takeLives();
                changeColor(red, enemyFour);

            }
        }

        private void enFive()
        {
            enemyFive.drawEnemy(0f, 3f, -7.0);
            enemyFive.rotb -= 0.01f;
            if (enemyFive.rotb <= -1.3f)
            {
                setBack(enemyFive);
                takeLives();
                changeColor(green, enemyFive);

            }
        }
            
        private void changeColor(float[] color,Enemy enemy )
        {
            enemy.Color = color;
        }

        private void setBack(Enemy enemy)
        {
            enemy.Rota = 0f;
            enemy.Rotb = 0f;
        }

        
    }

}
