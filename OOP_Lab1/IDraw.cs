namespace OOP_Lab1
{
    interface IDraw
    {
        public virtual void Draw(Pen pen,
                                Graphics graphics,
                                int X, int Y,
                                int Radius)
        { }
    }
    class DrawCircle : IDraw
    {
        public static void Draw(Pen pen,
                                Graphics graphics,
                                int X, int Y,
                                int Radius)
        {
            Rectangle rectangle = new(X - Radius,
                                      Y - Radius,
                                      2 * Radius,
                                      2 * Radius);
            graphics.DrawEllipse(pen, rectangle);
        }
    }
    class DrawRect : IDraw
    {
        public static void Draw(Pen pen,
                                Graphics graphics,
                                int X, int Y,
                                int Radius)
        {
            Rectangle rectangle = new(X - Radius,
                                      Y - Radius,
                                      2 * Radius,
                                      2 * Radius);
            graphics.DrawRectangle(pen, rectangle);
        }
    }
    class DrawTriangle : IDraw
    {
        public static void Draw(Pen pen,
                                Graphics graphics,
                                int X, int Y,
                                int Radius)
        {
            graphics.DrawLine(pen, X + Radius / 2, Y - Radius * (float)Math.Cos(Math.PI / 6), X + Radius / 2, Y + Radius * (float)Math.Cos(Math.PI / 6));
            graphics.DrawLine(pen, X - Radius, Y, X + Radius / 2, Y + Radius * (float)Math.Cos(Math.PI / 6));
            graphics.DrawLine(pen, X - Radius, Y, X + Radius / 2, Y - Radius * (float)Math.Cos(Math.PI / 6));
        }
    }
    class DrawEmblem : IDraw
    {
        public static void Draw(Pen pen,
                                Graphics graphics,
                                int X, int Y,
                                int Radius)
        {
            DrawRect.Draw(pen, graphics, X, Y, Radius);
            DrawCircle.Draw(pen, graphics, X - 2*Radius, Y, Radius);
            DrawTriangle.Draw(pen, graphics, X + 2*Radius, Y, Radius);
        }
            
    }
}
