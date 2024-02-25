using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Truck extends the Vehicle Class
    /// </summary>
    internal class Truck : Vehicle
    {
        /***** fields section *****/
        private double _sizeofTruckBed;


        /***** constructors section *****/
        /// <summary>
        /// Constructors that takes 4 parameters: truckBrand, truckModel, truckNumberofWheels, and sizeofTruckBed
        /// It reuses the base class (Vehicle) 's constructor that takes 3 parameters: brand, model, numberofWheels
        /// </summary>
        /// <param name="truckBrand"></param>
        /// <param name="truckModel"></param>
        /// <param name="truckNumberofWheels"></param>
        /// <param name="sizeofTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberofWheels, double sizeofTruckBed) : base(truckBrand, truckModel, truckNumberofWheels)
        {
            SizeofTruckBed = sizeofTruckBed;
        }


        /***** properties section *****/
        public double SizeofTruckBed
        {
            get { return _sizeofTruckBed; }
            set { _sizeofTruckBed = value;}
        }


        /***** methods section *****/
        /// <summary>
        /// Overrides the base Vehicle's definition for GetInfo()
        /// Calls the base Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeofTruckBed} ft truck bed");
        }
    }
}
