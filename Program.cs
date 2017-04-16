using DrawHaertOnMap.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHaertOnMap
{
    class Program
    {
        static void Main(string[] args)
        {

            Square startSquare = new Square();
            Point startPoint = new Point();
            startPoint.Latitude = 43.68158666149292;
            startPoint.Longitude = -79.33527922076769;
            startSquare.Length = 0.0071;
            startSquare.A = startPoint;
            startSquare.FixSquare();


            Console.WriteLine(String.Format(@"{0} {1}", startSquare.A.X.ToString(), startSquare.B.X.ToString()));
            Console.WriteLine(String.Format(@"{0} {1}", startSquare.A.Y.ToString(), startSquare.B.Y.ToString()));

            //create list of squares
            IList<Square> listOfSquares = new List<Square>();

            //Set start
            listOfSquares.Add(startSquare);

            //move NW3
            SquareMover mover = new SquareMover();
            for (int i = 1; i <= 10; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareNW(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }
            // move N 2
            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareN(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }
            //move Ne 1
            for (int i = 1; i <= 2; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareNE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //move east 1 

            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }
          
            //move Southeast 1
            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareSE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //move noerth east 1
            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareNE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //move east 1
            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //move SE 1
            for (int i = 1; i <= 2; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareSE(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //move S 2
            for (int i = 1; i <= 4; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareS(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }
            //move SW 2
            for (int i = 1; i <= 10; i++)
            {
                Square tempSwuare = listOfSquares.Last();
                tempSwuare = mover.MoveSquareSW(tempSwuare);

                listOfSquares.Add(tempSwuare);
            }

            //print it out
            File.Delete("out.txt");
            StreamWriter sw = new StreamWriter(@"out.txt", true);

            sw.Write("");

            sw.Write("function initMap(){var myLatLng = {lat: 43.8041958395909,lng: -79.754306699939};var map = new google.maps.Map(document.getElementById('map'), {zoom: 10,center: myLatLng});");
  


            int counter = 0;
            Random r = new Random();
            foreach (Square currS in listOfSquares)
            {
                currS.FixSquare();
                sw.WriteLine(GetCordString(currS.A.Latitude.ToString(), currS.A.Longitude.ToString(), r.Next(5000).ToString()));
                sw.WriteLine(GetCordString(currS.B.Latitude.ToString(), currS.B.Longitude.ToString(), r.Next(5000).ToString()));
                sw.WriteLine(GetCordString(currS.AB.Latitude.ToString(), currS.AB.Longitude.ToString(), r.Next(5000).ToString()));
                sw.WriteLine(GetCordString(currS.BA.Latitude.ToString(), currS.BA.Longitude.ToString(), r.Next(5000).ToString()));
                
                counter++;
            }
            sw.Write("}");

            sw.Close();

            Console.Read();
        }

        public static string GetCordString(string lat, string lon, string count)
        {

            string corstring = String.Format(@"var marker{2} = new google.maps.Marker(|position: |lat: {0}, lng: {1} !, map: map, title: '{0}, {1}'!);", lat, lon, count);

            return corstring.Replace("|", "{").Replace("!", "}");
        }


    }
}
