using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace MGWeb
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        KeyboardState pkstate;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Update(GameTime gameTime)
        {
            var kstate = Keyboard.GetState();
            var jstate = Joystick.GetState(0);

            if (kstate.IsKeyDown(Keys.A) && pkstate.IsKeyUp(Keys.A))
                Console.WriteLine("A is pressed :D");

            if (kstate.IsKeyDown(Keys.Z) && pkstate.IsKeyUp(Keys.Z))
                Console.WriteLine("Z is pressed :D");

            if (kstate.IsKeyDown(Keys.M) && pkstate.IsKeyUp(Keys.M))
                Console.WriteLine("Mouse position: " + Mouse.GetState().Position.ToString());

            if (kstate.IsKeyDown(Keys.L) && pkstate.IsKeyUp(Keys.L))
                Console.WriteLine("Left mouse button: " + Mouse.GetState().LeftButton);

            if (jstate.IsConnected && kstate.IsKeyDown(Keys.J) && pkstate.IsKeyUp(Keys.J))
                Console.WriteLine("Joystick: " + Joystick.GetCapabilities(0).Id + " state:" + jstate.Axes[0] + " " + jstate.Buttons[0]);

            if (jstate.IsConnected && kstate.IsKeyDown(Keys.G) && pkstate.IsKeyUp(Keys.G))
            {
                var gstate = GamePad.GetState(0);
                Console.WriteLine("Gamepad: A:" + gstate.IsButtonDown(Buttons.A) + " B: " + gstate.IsButtonDown(Buttons.B) + " Dpad down: " + gstate.DPad.Down + " Left Trigger " + gstate.Triggers.Left + " R Axis: " + gstate.ThumbSticks.Right.ToString());
            }

            pkstate = kstate;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            
            base.Draw(gameTime);
        }
    }
}

