using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_OD
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class OD : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D tex1;
        Texture2D tex2;
        Texture2D tex3;
        Player player;
        Enemy enemy;
        Color color1;
        Color color2;
        //Class1 class1 = Class1.Start;
        Vector2 pos1 = new Vector2(100, 100);
        Vector2 pos2 = new Vector2(300, 100);
        Vector2 pos3 = new Vector2(500, 100);

        public OD()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1600;
            graphics.PreferredBackBufferHeight = 960;
            graphics.ApplyChanges();
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            player = new Player();
            enemy = new Enemy();

            tex1 = new Texture2D(graphics.GraphicsDevice, 1, 1);
            tex2 = new Texture2D(graphics.GraphicsDevice, 1, 1);
            tex3 = new Texture2D(graphics.GraphicsDevice, 1, 1);

            tex1.SetData(new Color[] { Color.White });
            tex2.SetData(new Color[] { Color.White });
            tex3.SetData(new Color[] { Color.White });

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            
            player.Update(enemy.damage, enemy.enemyHitplayer);
            enemy.Update(player.damage, player.playerHitEnemy);

            Console.WriteLine("Enemy HP:");
            Console.WriteLine(enemy.CurrentHealthPoints);
            Console.ReadLine();


            //switch (class1)
            //{
            //    case Class1.Start:
            //        break;
            //    default:
            //        break;
            //}


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            color1 = Color.Red;
            color2 = Color.Black;

            switch (enemy.CurrentHealthPoints)
            {
                case 0:
                    spriteBatch.Draw(tex1, pos1, new Rectangle(100, 100, 50, 50), color2);
                    spriteBatch.Draw(tex2, pos2, new Rectangle(300, 100, 50, 50), color2);
                    spriteBatch.Draw(tex3, pos3, new Rectangle(500, 100, 50, 50), color2);
                    break;
                case 1:
                    spriteBatch.Draw(tex1, pos1, new Rectangle(100, 100, 50, 50), color1);
                    spriteBatch.Draw(tex2, pos2, new Rectangle(300, 100, 50, 50), color2);
                    spriteBatch.Draw(tex3, pos3, new Rectangle(500, 100, 50, 50), color2);
                    break;
                case 2:
                    spriteBatch.Draw(tex1, pos1, new Rectangle(100, 100, 50, 50), color1);
                    spriteBatch.Draw(tex2, pos2, new Rectangle(300, 100, 50, 50), color1);
                    spriteBatch.Draw(tex3, pos3, new Rectangle(500, 100, 50, 50), color2);
                    break;
                case 3:
                    spriteBatch.Draw(tex1, pos1, new Rectangle(100, 100, 50, 50), color1);
                    spriteBatch.Draw(tex2, pos2, new Rectangle(300, 100, 50, 50), color1);
                    spriteBatch.Draw(tex3, pos3, new Rectangle(500, 100, 50, 50), color1);
                    break;
                default:
                    break;
            }

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
