

using Assaignment1Input;

House house = new()
{
    Rooms = new List<Room>
    {
        new Room
        {
            RoomNo = "200",
            Windows = new List<Window>
            {
               new Window { Height=200,Width=300},
               new Window { Height=300,Width=400},
            }

        },
        new Room
        {
            RoomNo = "200",
            Windows = new List<Window>
            {
               new Window { Height=200,Width=300},
               new Window { Height=300,Width=400},
            }

        }
    }

};

Building building = new();

SimpleMapper mapper = new();
mapper.Copy(house, building);


//using Assaignment1Input;

//House house = new House()
//{
//    Rooms = new List<Room>
//    {
//        new Room
//        {
//            RoomNo = "200",
//            Windows = new List<Window>
//            {
//                new Window {Width=200 , Height=300},
//                new Window {Width=44 , Height=88},
                
//            }

//        },
//         new Room
//        {
//            RoomNo = "200",
//            Windows = new List<Window>
//            {
//                new Window {Width=200 , Height=300},
//                new Window {Width=44 , Height=88},

//            }

//        },
//    }
//};

//Building building = new();

//SimpleMapper mapper = new();

//mapper.Copy(house, building);
