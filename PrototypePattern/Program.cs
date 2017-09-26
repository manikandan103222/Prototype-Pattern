using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {

        //'IPrototype' Interface
        interface IMobilePhone
        {
            IMobilePhone Clone();
            string GetMobilePhoneDetails();
        }

        class MobilePhone : IMobilePhone
        {
            public string Name { get; set; }
            public string OperatingSystem { get; set; }
            public string InternalMemory { get; set; }
            public string RearCamera { get; set; }
            public string ScreenSize { get; set; }
            public string ExpandableMemory { get; set; }
            public string BatteryCapacity { get; set; }
            public string Resolution { get; set; }
            public string Colour { get; set; }

            public IMobilePhone Clone()
            {
                //Shallow Copy: every reference type objects are duplicated
                return (IMobilePhone)MemberwiseClone();
            }

            public string GetMobilePhoneDetails()
            {
                return string.Format("Name : {0}\nOpeartingSystem : {1}\nInternal Memory : {2}\nRear Camera : {3}\n"
                    + "ScreenSize : {4}\nExpandableMemory : {5}\nBatteryCapacity : {6}\n"
                    + "Resolution : {7}\nColour : {8}", Name, OperatingSystem, InternalMemory, RearCamera, ScreenSize,
                    ExpandableMemory, BatteryCapacity, Resolution, Colour);
            }

        }


        static void Main(string[] args)
        {
            MobilePhone mobilePhone = new MobilePhone();
            mobilePhone.OperatingSystem = " Nokia OS Series 30";
            mobilePhone.InternalMemory = "250 MB";
            mobilePhone.ExpandableMemory = "32 GB";

            //Clone mobile phone object with Clone method
            
            //Clone Nokia 215 Mobile Phone Object with help of default value from Original object
            MobilePhone mobilePhone_Nokia215 = (MobilePhone)mobilePhone.Clone();
            mobilePhone_Nokia215.Name = "Nokia 215";
            mobilePhone_Nokia215.RearCamera = "0.3 MP";
            mobilePhone_Nokia215.ScreenSize = "2.4 Inches";
            mobilePhone_Nokia215.BatteryCapacity = "1100 mAh";
            mobilePhone_Nokia215.Resolution = "240 x 320 pixels";
            mobilePhone_Nokia215.Colour = "Green";

            Console.WriteLine("------------------Nokia 215 Mobile Phone Details-------------------");
            Console.WriteLine(mobilePhone_Nokia215.GetMobilePhoneDetails());

            //Clone Nokia 130 Dual SIM Mobile Phone Object with help of default value from Original object
            MobilePhone mobilePhone_Nokia130DualSim = (MobilePhone)mobilePhone.Clone();
            mobilePhone_Nokia130DualSim.Name = "Nokia 130 Dual SIM";
            mobilePhone_Nokia130DualSim.RearCamera = "No";
            mobilePhone_Nokia130DualSim.ScreenSize = "1.8 Inches";
            mobilePhone_Nokia130DualSim.BatteryCapacity = "1200 mAh";
            mobilePhone_Nokia130DualSim.Resolution = "128 x 160 pixels";
            mobilePhone_Nokia130DualSim.Colour = "Red";

            Console.WriteLine("------------------Nokia 130 Dual SIM Mobile Phone Details-------------------");
            Console.WriteLine(mobilePhone_Nokia130DualSim.GetMobilePhoneDetails());

            //Clone Nokia 130 Mobile Phone Object with help of default value from Original object
            MobilePhone mobilePhone_Nokia130 = (MobilePhone)mobilePhone.Clone();
            mobilePhone_Nokia130.Name = "Nokia 130";
            mobilePhone_Nokia130.RearCamera = "No";
            mobilePhone_Nokia130.ScreenSize = "1.8 Inches";
            mobilePhone_Nokia130.BatteryCapacity = "1020 mAh";
            mobilePhone_Nokia130.Resolution = "128 x 160 pixels";
            mobilePhone_Nokia130.Colour = "Red";

            Console.WriteLine("------------------Nokia 130 Mobile Phone Details-------------------");
            Console.WriteLine(mobilePhone_Nokia130.GetMobilePhoneDetails());


            Console.Write("Press any key to exist...");
            Console.ReadKey();


        }
    }
}
