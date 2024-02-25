﻿namespace COMP003A.Assignment6
{
    ///<summary>
    ///Interfaces are contracts that the inheriting class has to implement.
    ///Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    internal interface IVehicle
    {
        ///<summary>
        ///thismethod is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();
    }
}
