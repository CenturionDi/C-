using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craft
{
    class Object
    {
        private string type;
        private int xcoord;
        private int ycoord;
        private string image;

        public Object()
        {
            this.type = "Space";
            
            this.image = " ";
        }

        public string Image
        {
            get
            {
                Console.WriteLine(image);
                return image;
            }
            set
            {
                image = value;
            }
        }

        public int Xcoord
        {
            get
            {
                return xcoord;
            }
            set
            {
                xcoord = value;
            }
        }

        public int Ycoord
        {
            get
            {
                return ycoord;
            }
            set
            {
                ycoord = value;
            }
        }


        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }


        public static Object operator +(Object obj1, Object obj2)
        {
            if ((obj1.type == "Wood") && (obj2.type == "Wood")&&((obj1.xcoord==1)&& (obj1.ycoord == 1)) && ((obj2.xcoord == 2) && (obj2.ycoord == 1)))
            {
                
                Object res = new Object();
                res.type = "Stick";
                res.image = "|";
                return res;//
            }



            else if ((obj1.type == "Wood") && (obj2.type == "Wood") && ((obj1.xcoord == 0) && (obj1.ycoord == 0)) && ((obj2.xcoord == 0) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Wood";
                res.image = "2W";
                return res;//
            }
            else if ((obj1.type == "Stone") && (obj2.type == "Stone") && ((obj1.xcoord == 0) && (obj1.ycoord == 0)) && ((obj2.xcoord == 0) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Stone";
                res.image = "2S";
                return res;//
            }
            else if ((obj1.type == "Gold") && (obj2.type == "Gold") && ((obj1.xcoord == 0) && (obj1.ycoord == 0)) && ((obj2.xcoord == 0) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Gold";
                res.image = "2S";
                return res;//
            }
            else if ((obj1.type == "Iron") && (obj2.type == "Iron") && ((obj1.xcoord == 0) && (obj1.ycoord == 0)) && ((obj2.xcoord == 0) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Iron";
                res.image = "2I";
                return res;//
            }
            else if ((obj1.type == "Diamond") && (obj2.type == "Diamond") && ((obj1.xcoord == 0) && (obj1.ycoord == 0)) && ((obj2.xcoord == 0) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Diamond";
                res.image = "2D";
                return res;//
            }




            else if ((obj1.type == "Wood") && (obj2.type == "Wood") && ((obj1.xcoord == 0) && (obj1.ycoord == 1)) && ((obj2.xcoord == 1) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2WoodS";
                res.image = "2WS";
                return res;//
            }
            else if ((obj1.type == "Stone") && (obj2.type == "Stone") && ((obj1.xcoord == 0) && (obj1.ycoord == 1)) && ((obj2.xcoord == 1) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2StoneS";
                res.image = "2SS";
                return res;//
            }
            else if ((obj1.type == "Gold") && (obj2.type == "Gold") && ((obj1.xcoord == 0) && (obj1.ycoord == 1)) && ((obj2.xcoord == 1) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2GoldS";
                res.image = "2SS";
                return res;//
            }
            else if ((obj1.type == "Iron") && (obj2.type == "Iron") && ((obj1.xcoord == 0) && (obj1.ycoord == 1)) && ((obj2.xcoord == 1) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2IronS";
                res.image = "2IS";
                return res;//
            }
            else if ((obj1.type == "Diamond") && (obj2.type == "Diamond") && ((obj1.xcoord == 0) && (obj1.ycoord == 1)) && ((obj2.xcoord == 1) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2DiamondS";
                res.image = "2DS";
                return res;//
            }





            else if ((obj1.type == "2Wood") && (obj2.type == "Wood") && ((obj2.xcoord == 0) && (obj2.ycoord == 2)))
            {
                Object res = new Object();
                res.type = "3WoodA";
                res.image = "3WA";
                return res;//
            }
            else if ((obj1.type == "2Stone") && (obj2.type == "Stone") && ((obj2.xcoord == 0) && (obj2.ycoord == 2)))
            {
                Object res = new Object();
                res.type = "3StoneA";
                res.image = "3SA";
                return res;//
            }
            else if ((obj1.type == "2Gold") && (obj2.type == "Gold") && ((obj2.xcoord == 0) && (obj2.ycoord == 2)))
            {
                Object res = new Object();
                res.type = "3GoldA";
                res.image = "3GA";
                return res;//
            }
            else if ((obj1.type == "2Iron") && (obj2.type == "Iron") && ((obj2.xcoord == 0) && (obj2.ycoord == 2)))
            {
                Object res = new Object();
                res.type = "3IronA";
                res.image = "3IA";
                return res;//
            }
            else if ((obj1.type == "2Diamond") && (obj2.type == "Diamond") && ((obj2.xcoord == 0) && (obj2.ycoord == 2)))
            {
                Object res = new Object();
                res.type = "3DiamondA";
                res.image = "3DA";
                return res;//
            }






            else if ((obj1.type == "2Wood") && (obj2.type == "Wood") && ((obj2.xcoord == 1) && (obj2.ycoord == 0)))
            {
                Object res = new Object();
                res.type = "3WoodB";
                res.image = "3WB";
                return res;//
            }
            else if ((obj1.type == "2Stone") && (obj2.type == "Stone") && ((obj2.xcoord == 1) && (obj2.ycoord == 0)))
            {
                Object res = new Object();
                res.type = "3StoneB";
                res.image = "3SB";
                return res;//
            }
            else if ((obj1.type == "2Gold") && (obj2.type == "Gold") && ((obj2.xcoord == 1) && (obj2.ycoord == 0)))
            {
                Object res = new Object();
                res.type = "3GoldB";
                res.image = "3GB";
                return res;//
            }
            else if ((obj1.type == "2Iron") && (obj2.type == "Iron") && ((obj2.xcoord == 1) && (obj2.ycoord == 0)))
            {
                Object res = new Object();
                res.type = "3IronB";
                res.image = "3IB";
                return res;//
            }
            else if ((obj1.type == "2Diamond") && (obj2.type == "Diamond") && ((obj2.xcoord == 1) && (obj2.ycoord == 0)))
            {
                Object res = new Object();
                res.type = "3DiamondB";
                res.image = "3DB";
                return res;//
            }








            else if ((obj1.type == "Stick") && (obj2.type == "Stick") && ((obj1.xcoord == 1) && (obj1.ycoord == 1)) && ((obj2.xcoord == 2) && (obj2.ycoord == 1)))
            {
                Object res = new Object();
                res.type = "2Stick";
                res.image = "||";
                return res;//
            }


          
            else if ((obj1.type == "3WoodA") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Wooden Pickaxe";
                res.image = "WP";
                return res;//
            }
            else if ((obj1.type == "3StoneA") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Stone Pickaxe";
                res.image = "SP";
                return res;//
            }
            else if ((obj1.type == "3IronA") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Iron Pickaxe";
                res.image = "IP";
                return res;//
            }
            else if ((obj1.type == "3GoldA") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Gold Pickaxe";
                res.image = "GP";
                return res;//
            }
            else if ((obj1.type == "3DiamondA") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Diamond Pickaxe";
                res.image = "DP";
                return res;//
            }



            else if ((obj1.type == "2WoodS") && (obj2.type == "Stick"))
            {
                Object res = new Object();
                res.type = "Wooden Sword";
                return res;
            }
            else if ((obj1.type == "2StoneS") && (obj2.type == "Stick"))
            {
                Object res = new Object();
                res.type = "Stone Sword";
                return res;
            }
            else if ((obj1.type == "2IronS") && (obj2.type == "Stick"))
            {
                Object res = new Object();
                res.type = "Iron Sword";
                return res;
            }
            else if ((obj1.type == "2GoldS") && (obj2.type == "Stick"))
            {
                Object res = new Object();
                res.type = "Gold Sword";
                return res;
            }
            else if ((obj1.type == "2DiamondS") && (obj2.type == "Stick"))
            {
                Object res = new Object();
                res.type = "Diamond Sword";
                return res;
            }



            else if ((obj1.type == "Wood") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Wooden Shovel";
                return res;
            }
            else if ((obj1.type == "Stone") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Stone Shovel";
                return res;
            }
            else if ((obj1.type == "Iron") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Iron Shovel";
                return res;
            }
            else if ((obj1.type == "Gold") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Gold Shovel";
                return res;
            }
            else if ((obj1.type == "Diamond") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Diamond Shovel";
                return res;//
            }




            else if ((obj1.type == "2Wood") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Wooden Hoe";
                return res;
            }
            else if ((obj1.type == "2Stone") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Stone Hoe";
                return res;
            }
            else if ((obj1.type == "2Iron") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Iron Hoe";
                return res;
            }
            else if ((obj1.type == "2Gold") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Gold Hoe";
                return res;
            }
            else if ((obj1.type == "2Diamond") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Diamond Hoe";
                return res;//
            }











            else if ((obj1.type == "3WoodB") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Wooden Axe";
                res.image = "WP";
                return res;//
            }
            else if ((obj1.type == "3StoneB") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Stone Axe";
                res.image = "SP";
                return res;//
            }
            else if ((obj1.type == "3IronB") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Iron Axe";
                res.image = "IP";
                return res;//
            }
            else if ((obj1.type == "3GoldB") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Gold Axe";
                res.image = "GP";
                return res;//
            }
            else if ((obj1.type == "3DiamondB") && (obj2.type == "2Stick"))
            {
                Object res = new Object();
                res.type = "Diamond Axe";
                res.image = "DP";
                return res;//
            }


            else
            {
                return obj1;
            }

        }
        }
}
