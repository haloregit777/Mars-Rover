using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Rover
{
    class RoverCommands
    {
        private string direction = "NWSE";
        private int initX, initY;
        private char initD;
        private Random rnd = new Random();

        public RoverCommands(int platX, int platY)
        {        
            initX = rnd.Next(platX);
            initY = rnd.Next(platY);
            int dir = rnd.Next(direction.Length);
            initD = direction[dir];
        }

        public string getInitValues()
        {
            return Convert.ToString(initX) + " " + Convert.ToString(initY) + " " + initD;
        }

        private string rotationRover(string rot, string curRoverData)
        {
            int dir = 0;
            if (curRoverData == "N") dir = 0;
            if (curRoverData == "W") dir = 1;
            if (curRoverData == "S") dir = 2;
            if (curRoverData == "E") dir = 3;
            if (rot == "L")
            {
                dir++;
                if (dir > 3) dir = 0;
            }
            if (rot == "R")
            {
                dir--;
                if (dir < 0) dir = 3;
            }

            return Convert.ToString(direction[dir]);
        }

        public string moveRover(string moveData, string curRoverData, int maxX, int maxY)
        {
            moveData = moveData.ToUpper();
            string breakUp = curRoverData;
            int firstSpace = breakUp.IndexOf(" ");
            int curX = Convert.ToInt32(breakUp.Substring(0, firstSpace));
            breakUp = breakUp.Substring(firstSpace + 1);
            firstSpace = breakUp.IndexOf(" ");
            int curY = Convert.ToInt32(breakUp.Substring(0, firstSpace));
            breakUp = breakUp.Substring(firstSpace + 1);
            string curD = breakUp;
            for (int i = 0; i < moveData.Length; i++)
            {
                if (moveData[i] == 'M' && curD == "N")
                {
                    curY++;
                    if (curY >= maxY) curY = maxY - 1;
                }
                else if (moveData[i] == 'M' && curD == "S")
                {
                    curY--;
                    if (curY < 0) curY = 0;
                }
                else if (moveData[i] == 'M' && curD == "W")
                {
                    curX--;
                    if (curX < 0) curX = 0;
                }
                else if (moveData[i] == 'M' && curD == "E")
                {
                    curX++;
                    if (curX >= maxX) curX = maxX - 1;
                }
                else curD = rotationRover(Convert.ToString(moveData[i]), curD);
            }

            string finalDestination = Convert.ToString(curX) + " " + Convert.ToString(curY) + " " + curD;

            return finalDestination;
        }
    }
}
