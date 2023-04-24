using System.Security.Cryptography.X509Certificates;

namespace RoomLibraryTommin
{
    public class Room
    {
        double roomLength;
        double roomWidth;

        public double Roomlength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLength + roomWidth);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="np"></param>
        /// <returns></returns>
        public double PersonaArea(int np)
        {
            return RoomArea() / np;
        }
        /// <summary>
        /// информация о комнате
        /// </summary>
        /// <returns> возвращает строку</returns>
        public string Info()
        {
            return "комната площадью" + Room.Area() + "кв.м";
        }
        /// <summary>
        /// класс жилая комната 
        /// </summary>
        public class LivingRoom : Room
        {
            int numWin; //число окон

            public int NumWin
            { get { return numWin; } set { numWin = value; } }
            /// <summary>
            /// метод возвращает информацию о комнате
            /// </summary>
            /// <returns> возвращается строка с инфформацией о комнате</returns>
            public string Info()
            {
                return "жилая комната площадью" + RoomArea() + "кв.м, с " + numWin + "окнами";
            }

        }
        public class Office : Room
        {
            int numSockets; //число розеток

            public int NumSockets
            { get { return numSockets; } set { numSockets = value; } }
            /// <summary>
            /// возвращает максимально возможное число рабочих мест
            /// </summary>
            /// <returns> возвращается число мест</returns>
            public int NumWorkplaces()
            {
                int num = Convert.ToInt32(Math.Truncate(RoomArea() / 4.5));
                return Math.Min(numSockets, sum);
            }
            /// <summary>
            /// возвращает информацию об офисе
            /// </summary>
            /// <returns> возвращается строка с информацией</returns>
        }
        public string Info()
        {
            return "офис на " + NumWorkplaces() + "рабочих мест";
        }
    }

}