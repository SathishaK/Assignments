using System;
using System.Collections.Generic;

namespace Assigns
{

    internal interface Movable
    {

        void moveUp();
        void moveDown();
        void moveLeft();
        void moveRight();
    }

    internal class MovablePoint : Movable, IComparable<MovablePoint>
    {

        internal int x, y, xSpeed, ySpeed;


        public MovablePoint(int x, int y, int xSpeed, int ySpeed)
        {
            this.x = x;
            this.y = y;
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public override string ToString()
        {
            return "Point at (" + x + "," + y + ") XSPEED: " + xSpeed + " YSPEED: " + ySpeed;
        }


        public virtual void moveUp()
        {
            y -= ySpeed;
        }

        public virtual void moveDown()
        {
            y += ySpeed;
        }

        public virtual void moveLeft()
        {
            x -= xSpeed;
        }

        public virtual void moveRight()
        {
            x += xSpeed;
        }

        public virtual int CompareTo(MovablePoint point)
        {
            if (this.x == point.x)
            {
                return (int)(this.y - point.y);
            }
            else
            {
                return (int)(this.x - point.x);
            }
        }
    }

    internal class MovableCircle : Movable
    {

        private MovablePoint center;
        private int radius;


        public virtual int Radius
        {
            get
            {
                return radius;
            }
        }
        public virtual MovablePoint Center
        {
            get
            {
                return center;
            }
        }


        public MovableCircle(int x, int y, int xSpeed, int ySpeed, int radius)
        {


            center = new MovablePoint(x, y, xSpeed, ySpeed);
            this.radius = radius;
        }



        public virtual void moveUp()
        {
            center.y -= center.ySpeed;
        }

        public virtual void moveDown()
        {
            center.y += center.ySpeed;
        }

        public virtual void moveLeft()
        {
            center.x -= center.xSpeed;
        }

        public virtual void moveRight()
        {
            center.x += center.xSpeed;
        }

        public override string ToString()
        {
            return "Center at (" + center.x + "," + center.y + ") XSPEED: " + center.xSpeed + " YSPEED: " + center.ySpeed + " RADIUS: " + this.radius;
        }


    }



    internal class CompareByRadius : IComparer<MovableCircle>
    {
        public virtual int Compare(MovableCircle m1, MovableCircle m2)
        {
            return (int)(m1.Radius - m2.Radius);
        }
    }

    internal class CompareByCenter : IComparer<MovableCircle>
    {
        public virtual int Compare(MovableCircle m1, MovableCircle m2)
        {
            return (int)(m1.Center.CompareTo(m2.Center));
        }
    }
    internal class CompareByBoth : IComparer<MovableCircle>
    {
        public virtual int Compare(MovableCircle m1, MovableCircle m2)
        {
            if (m1.Radius == m2.Radius)
            {
                return (int)(m1.Center.CompareTo(m2.Center));
            }
            else
            {
                return (int)(m1.Radius - m2.Radius);
            }
        }
    }
    public class MovableRectangle : Movable
    {

        private MovablePoint topLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(int x1, int y1, int x2, int y2, int xSpeed, int ySpeed)
        {
            topLeft = new MovablePoint(x1, y1, xSpeed, ySpeed);
            bottomRight = new MovablePoint(x2, y2, xSpeed, ySpeed);
        }

        public virtual void moveUp()
        {
            if (!hasPointsSameSpeed())
            {
                return;
            }
            topLeft.y -= topLeft.ySpeed;
            bottomRight.y -= bottomRight.ySpeed;
        }

        public virtual void moveDown()
        {
            if (!hasPointsSameSpeed())
            {
                return;
            }
            topLeft.y += topLeft.ySpeed;
            bottomRight.y += bottomRight.ySpeed;
        }

        public virtual void moveLeft()
        {
            if (!hasPointsSameSpeed())
            {
                return;
            }
            topLeft.x -= topLeft.xSpeed;
            bottomRight.x -= bottomRight.xSpeed;
        }

        public virtual void moveRight()
        {
            if (!hasPointsSameSpeed())
            {
                return;
            }
            topLeft.x += topLeft.xSpeed;
            bottomRight.x += bottomRight.xSpeed;
        }

        private bool hasPointsSameSpeed()
        {
            return (topLeft.xSpeed == bottomRight.xSpeed) && (topLeft.ySpeed == bottomRight.ySpeed);
        }

        public override string ToString()
        {
            return string.Format("MovableRectangle with topLeft: {0} and bottomRight: {1}", topLeft.ToString(), bottomRight.ToString());
        }
    }

    public class TestMovable
    {
        public static void Main(string[] args)
        {
            Movable m1 = new MovablePoint(5, 6, 10, 20);
            Console.WriteLine(m1);
            m1.moveLeft();
            Console.WriteLine(m1);

            Movable m2 = new MovableCircle(2, 1, 2, 20, 25);
            Console.WriteLine(m2);
            m2.moveRight();
            Console.WriteLine(m2);

            Movable m3 = new MovableRectangle(1, 2, 3, 4, 25, 35);
            Console.WriteLine(m3);
            m3.moveUp();
            Console.WriteLine(m3);



        }
    }

}
