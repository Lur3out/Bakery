﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Bakery
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Defected cake.
    /// </summary>
    // *** Start programmer edit section *** (DefectedCake CustomAttributes)

    // *** End programmer edit section *** (DefectedCake CustomAttributes)
    [BusinessServer("IIS.Bakery.DeletedCakeBS, Bakery.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [Caption("Defected cake")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Bakery_DefectedCakeE", new string[] {
            "Count as \'Count\'",
            "Reason as \'Reason\'",
            "CakeToSale as \'Cake to sale\'",
            "CakeToSale.Name as \'Name\'"})]
    [View("Bakery_DefectedCakeL", new string[] {
            "Count as \'Count\'",
            "Reason as \'Reason\'",
            "CakeToSale.Name as \'Name\'"})]
    [View("DefectedCakeE", new string[] {
            "Count as \'Count\'",
            "Reason as \'Reason\'",
            "CakeToSale as \'Cake to sale\'",
            "CakeToSale.Name as \'Name\'"})]
    [View("DefectedCakeL", new string[] {
            "Count as \'Count\'",
            "Reason as \'Reason\'",
            "CakeToSale.Name as \'Name\'"})]
    public class DefectedCake : ICSSoft.STORMNET.DataObject
    {
        
        private int fCount;
        
        private string fReason;
        
        private IIS.Bakery.CakeToSale fCakeToSale;
        
        // *** Start programmer edit section *** (DefectedCake CustomMembers)

        // *** End programmer edit section *** (DefectedCake CustomMembers)

        
        /// <summary>
        /// Count.
        /// </summary>
        // *** Start programmer edit section *** (DefectedCake.Count CustomAttributes)

        // *** End programmer edit section *** (DefectedCake.Count CustomAttributes)
        public virtual int Count
        {
            get
            {
                // *** Start programmer edit section *** (DefectedCake.Count Get start)

                // *** End programmer edit section *** (DefectedCake.Count Get start)
                int result = this.fCount;
                // *** Start programmer edit section *** (DefectedCake.Count Get end)

                // *** End programmer edit section *** (DefectedCake.Count Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (DefectedCake.Count Set start)

                // *** End programmer edit section *** (DefectedCake.Count Set start)
                this.fCount = value;
                // *** Start programmer edit section *** (DefectedCake.Count Set end)

                // *** End programmer edit section *** (DefectedCake.Count Set end)
            }
        }
        
        /// <summary>
        /// Reason.
        /// </summary>
        // *** Start programmer edit section *** (DefectedCake.Reason CustomAttributes)

        // *** End programmer edit section *** (DefectedCake.Reason CustomAttributes)
        [StrLen(255)]
        public virtual string Reason
        {
            get
            {
                // *** Start programmer edit section *** (DefectedCake.Reason Get start)

                // *** End programmer edit section *** (DefectedCake.Reason Get start)
                string result = this.fReason;
                // *** Start programmer edit section *** (DefectedCake.Reason Get end)

                // *** End programmer edit section *** (DefectedCake.Reason Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (DefectedCake.Reason Set start)

                // *** End programmer edit section *** (DefectedCake.Reason Set start)
                this.fReason = value;
                // *** Start programmer edit section *** (DefectedCake.Reason Set end)

                // *** End programmer edit section *** (DefectedCake.Reason Set end)
            }
        }
        
        /// <summary>
        /// Defected cake.
        /// </summary>
        // *** Start programmer edit section *** (DefectedCake.CakeToSale CustomAttributes)

        // *** End programmer edit section *** (DefectedCake.CakeToSale CustomAttributes)
        [NotNull()]
        public virtual IIS.Bakery.CakeToSale CakeToSale
        {
            get
            {
                // *** Start programmer edit section *** (DefectedCake.CakeToSale Get start)

                // *** End programmer edit section *** (DefectedCake.CakeToSale Get start)
                IIS.Bakery.CakeToSale result = this.fCakeToSale;
                // *** Start programmer edit section *** (DefectedCake.CakeToSale Get end)

                // *** End programmer edit section *** (DefectedCake.CakeToSale Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (DefectedCake.CakeToSale Set start)

                // *** End programmer edit section *** (DefectedCake.CakeToSale Set start)
                this.fCakeToSale = value;
                // *** Start programmer edit section *** (DefectedCake.CakeToSale Set end)

                // *** End programmer edit section *** (DefectedCake.CakeToSale Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Bakery_DefectedCakeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Bakery_DefectedCakeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Bakery_DefectedCakeE", typeof(IIS.Bakery.DefectedCake));
                }
            }
            
            /// <summary>
            /// "Bakery_DefectedCakeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Bakery_DefectedCakeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Bakery_DefectedCakeL", typeof(IIS.Bakery.DefectedCake));
                }
            }
            
            /// <summary>
            /// "DefectedCakeE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DefectedCakeE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DefectedCakeE", typeof(IIS.Bakery.DefectedCake));
                }
            }
            
            /// <summary>
            /// "DefectedCakeL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View DefectedCakeL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("DefectedCakeL", typeof(IIS.Bakery.DefectedCake));
                }
            }
        }
    }
}