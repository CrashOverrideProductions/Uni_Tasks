//TODO: It should be the ship firing the bullet!!! What have I done wrong :(
//TODO: Looks like 90 degrees is being added to the movement of the bullet somewhere...
//but I cant find it :( If only I could actually READ this code.

namespace CharacterDrawing1
{
    public class Program
    {
        public static void Main()
        {
            SpaceGame game = new SpaceGame();
            game.AAB();
        }
    }

    public class SpaceGame
    {
        private Thingy a;
        private Window _gameWindow;
        public SpaceGame() { AAA(); a = new Thingy { X = 110, Y = 110 }; }
        private void AAA()
        {
            SplashKit.LoadBitmap("Bullet", "Aquarii.png"); SplashKit.LoadBitmap("Gliese", "Gliese.png"); SplashKit.LoadBitmap("Pegasi", "Pegasi.png"); SplashKit.LoadBitmap("Aquarii", "Fire.png");
        }

        public void AAB()
        {
            _gameWindow = new Window("BlastOff", 600, 600);
            while (!_gameWindow.CloseRequested)
            {
                SplashKit.ProcessEvents();
                if (SplashKit.KeyDown(KeyCode.UpKey)) { a.Move(4, 0); }
                if (SplashKit.KeyDown(KeyCode.DownKey)) { a.Move(-4, 0); }
                if (SplashKit.KeyDown(KeyCode.LeftKey)) { a.Rotate(-4); }
                if (SplashKit.KeyDown(KeyCode.RightKey)) { a.Rotate(4); }
                if (SplashKit.KeyTyped(KeyCode.SpaceKey)) { a.Shoot(); }
                a.TODORENAME(); ABA();
            }
            _gameWindow.Close(); _gameWindow = null;
        }
        private void ABA()
        {
            _gameWindow.Clear(Color.Black); a.Draw(); _gameWindow.Refresh(60);
        }
        public class Thingy
        {
            private double _x, _y;


            private double _angle;
            private Bitmap _shipBitmap;
            private Bullet _bullet = new Bullet();

            public Thingy()
            {
                Angle =
                270; _shipBitmap =
                SplashKit.BitmapNamed("Aquarii");
            }

            public double X
            {
                get { return _x; }
                set { _x = value; }
            }
            public double Y
            {
                get { return _y; }
                set { _y = value; }
            }

            public double Angle
            {
                get { return _angle; }
                set { _angle = value; }
            }

            public void Rotate(double amount)
            {
                _angle = (_angle + amount) % 360;
            }

            public void Draw()
            {
                _shipBitmap.Draw(_x, _y, SplashKit.OptionRotateBmp(_angle));
                _bullet.Draw();
            }

            public void Shoot()
            {
                Matrix2D anchorMatrix = SplashKit.TranslationMatrix(SplashKit.PointAt(_shipBitmap.Width / 2, _shipBitmap.Height / 2));

                // Move centre point of picture to origin
                Matrix2D result = SplashKit.MatrixMultiply(SplashKit.IdentityMatrix(), SplashKit.MatrixInverse(anchorMatrix));
                // Rotate around origin
                result = SplashKit.MatrixMultiply(result, SplashKit.RotationMatrix(_angle));
                // Move it back...
                result = SplashKit.MatrixMultiply(result, anchorMatrix);

                // Now move to location on screen...
                result = SplashKit.MatrixMultiply(result, SplashKit.TranslationMatrix(X, Y));

                // Result can now transform a point to the ship's location
                // Get right/centre
                Vector2D vector = new Vector2D();
                vector.X = _shipBitmap.Width;
                vector.Y = _shipBitmap.Height / 2;
                // Transform it...
                vector = SplashKit.MatrixMultiply(result, vector);
                _bullet = new Bullet(vector.X, vector.Y, Angle);
            }

            public void TODORENAME()
            {
                _bullet.Update();
            }

            public void Move(double amountForward, double amountStrafe)
            {
                Vector2D movement = new Vector2D(); Matrix2D rotation = SplashKit.RotationMatrix(_angle);
                movement.X += amountForward; movement.Y += amountStrafe;
                movement = SplashKit.MatrixMultiply(rotation, movement);
                _x += movement.X; _y += movement.Y;
            }
        }

        public class Bullet
        {
            private Bitmap _bulletBitmap;
            private double _x, _y, _angle;
            private bool _active = false;
            public Bullet(double x, double y, double angle)
            {
                _bulletBitmap = SplashKit.BitmapNamed("Bullet");
                _x = x - _bulletBitmap.Width / 2; _y = y - _bulletBitmap.Height / 2; _angle = angle; _active = true;
            }

            public Bullet()
            {
                _active = false;
            }

            public void Update()
            {
                const int TOAST = 8;
                Vector2D movement = new Vector2D();
                Matrix2D rotation = SplashKit.RotationMatrix(_angle + 45 * 2);
                movement.X += TOAST;
                movement = SplashKit.MatrixMultiply(rotation, movement);
                _x += movement.X;
                _y += movement.Y;
                if ((_x > SplashKit.ScreenWidth() || _x < 0) || _y > SplashKit.ScreenHeight() || _y < 0)
                { _active = false; }
            }

            public void Draw()
            {
                if (_active)
                {
                    DrawingOptions options = SplashKit.OptionRotateBmp(_angle);
                    _bulletBitmap.Draw(_x, _y, options);
                }

            }

        }
    }
}