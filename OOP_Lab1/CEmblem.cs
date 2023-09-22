namespace OOP_Lab1
{
    internal class CEmblem
    {
        const int DefaultRadius = 50;

        private Graphics graphics;
        private int _radius;

        public int X { get; set; }
        public int Y { get; set; }
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value >= 200 ? 200 : value;
                _radius = value <= 5 ? 5 : value;
            }
        }
        public CEmblem(Graphics graphics, int X, int Y)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = DefaultRadius;
        }
        public CEmblem(Graphics graphics, int X, int Y, int Radius)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
        }
        public void Show(string objType)
        {
            switch (objType)
            {
                case "Circle":
                    DrawCircle.Draw(Pens.Red, graphics, X, Y, Radius);
                    break;
                case "Square":
                    DrawRect.Draw(Pens.Red, graphics, X, Y, Radius);
                    break;
                case "Triangle":
                    DrawTriangle.Draw(Pens.Red, graphics, X, Y, Radius);
                    break;
                case "Emblem":
                    DrawEmblem.Draw(Pens.Red, graphics, X, Y, Radius);
                    break;
                default:
                    MessageBox.Show("Такого об'єкту не існує.");
                    break;
            }

        }
        public void Hide(string objType)
        {
            switch (objType)
            {
                case "Circle":
                    DrawCircle.Draw(Pens.White, graphics, X, Y, Radius);
                    break;
                case "Square":
                    DrawRect.Draw(Pens.White, graphics, X, Y, Radius);
                    break;
                case "Triangle":
                    DrawTriangle.Draw(Pens.White, graphics, X, Y, Radius);
                    break;
                case "Emblem":
                    DrawEmblem.Draw(Pens.White, graphics, X, Y, Radius);
                    break;
                default:
                    MessageBox.Show("Такого об'єкту не існує.");
                    break;
            }
        }
        public void Expand(string objType)
        {
            Hide(objType);
            Radius++;
            Show(objType);
        }
        public void Expand(string objType, int dR)
        {
            Hide(objType);
            Radius += dR;
            Show(objType);
        }
        public void Collapse(string objType)
        {
            Hide(objType);
            Radius--;
            Show(objType);
        }
        public void Collapse(string objType, int dR)
        {
            Hide(objType);
            Radius -= dR;
            Show(objType);
        }
        public void Move(string objType, int dX, int dY)
        {
            Hide(objType);
            X += dX;
            Y += dY;
            Show(objType);
        }
    }
}
