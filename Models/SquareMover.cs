using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHaertOnMap.Models
{
    public class SquareMover
    {

        public Square MoveSquareNW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;


        }

        public Square MoveSquareNE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;


        }

        public Square MoveSquareSE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;


        }

        public Square MoveSquareSW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;


        }

        public  Square MoveSquareN(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y + currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y + currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;

        }
        public  Square MoveSquareS(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X;
            newPointA.Y = currentSquare.A.Y - currentSquare.Length;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X;
            newPointB.Y = currentSquare.B.Y - currentSquare.Length;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;

        }

        public  Square MoveSquareW(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X - currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X - currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;

        }


        public  Square MoveSquareE(Square currentSquare)
        {
            //make sure we have a full square object
            currentSquare.FixSquare();
            //create our new square
            Square newSquare = new Square();
            newSquare.Length = currentSquare.Length;
            //create new points
            Point newPointA = new Point();
            newPointA.X = currentSquare.A.X + currentSquare.Length;
            newPointA.Y = currentSquare.A.Y;

            Point newPointB = new Point();
            newPointB.X = currentSquare.B.X + currentSquare.Length;
            newPointB.Y = currentSquare.B.Y;

            newSquare.A = newPointA;
            newSquare.B = newPointB;

            return newSquare;

        }

    }
}
