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
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Cake into request.
    /// </summary>
    // *** Start programmer edit section *** (CakeIntoRequest CustomAttributes)

    // *** End programmer edit section *** (CakeIntoRequest CustomAttributes)
    [AutoAltered()]
    [Caption("Cake into request")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("Bakery_CakeIntoRequestE", new string[] {
            "Count as \'Count\'",
            "CakeToSale as \'Cake to sale\'",
            "CakeToSale.Name as \'Name\'"}, Hidden=new string[] {
            "CakeToSale.Name"})]
    [MasterViewDefineAttribute("Bakery_CakeIntoRequestE", "CakeToSale", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("CakeIntoRequestE", new string[] {
            "Count as \'Count\'",
            "CakeToSale as \'Cake to sale\'",
            "CakeToSale.Name as \'Name\'"}, Hidden=new string[] {
            "CakeToSale.Name"})]
    [MasterViewDefineAttribute("CakeIntoRequestE", "CakeToSale", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    public class CakeIntoRequest : ICSSoft.STORMNET.DataObject
    {
        
        private int fCount;
        
        private IIS.Bakery.CakeToSale fCakeToSale;
        
        private IIS.Bakery.Request fRequest;
        
        // *** Start programmer edit section *** (CakeIntoRequest CustomMembers)

        // *** End programmer edit section *** (CakeIntoRequest CustomMembers)

        
        /// <summary>
        /// Count.
        /// </summary>
        // *** Start programmer edit section *** (CakeIntoRequest.Count CustomAttributes)

        // *** End programmer edit section *** (CakeIntoRequest.Count CustomAttributes)
        public virtual int Count
        {
            get
            {
                // *** Start programmer edit section *** (CakeIntoRequest.Count Get start)

                // *** End programmer edit section *** (CakeIntoRequest.Count Get start)
                int result = this.fCount;
                // *** Start programmer edit section *** (CakeIntoRequest.Count Get end)

                // *** End programmer edit section *** (CakeIntoRequest.Count Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CakeIntoRequest.Count Set start)

                // *** End programmer edit section *** (CakeIntoRequest.Count Set start)
                this.fCount = value;
                // *** Start programmer edit section *** (CakeIntoRequest.Count Set end)

                // *** End programmer edit section *** (CakeIntoRequest.Count Set end)
            }
        }
        
        /// <summary>
        /// Cake into request.
        /// </summary>
        // *** Start programmer edit section *** (CakeIntoRequest.CakeToSale CustomAttributes)

        // *** End programmer edit section *** (CakeIntoRequest.CakeToSale CustomAttributes)
        [NotNull()]
        public virtual IIS.Bakery.CakeToSale CakeToSale
        {
            get
            {
                // *** Start programmer edit section *** (CakeIntoRequest.CakeToSale Get start)

                // *** End programmer edit section *** (CakeIntoRequest.CakeToSale Get start)
                IIS.Bakery.CakeToSale result = this.fCakeToSale;
                // *** Start programmer edit section *** (CakeIntoRequest.CakeToSale Get end)

                // *** End programmer edit section *** (CakeIntoRequest.CakeToSale Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CakeIntoRequest.CakeToSale Set start)

                // *** End programmer edit section *** (CakeIntoRequest.CakeToSale Set start)
                this.fCakeToSale = value;
                // *** Start programmer edit section *** (CakeIntoRequest.CakeToSale Set end)

                // *** End programmer edit section *** (CakeIntoRequest.CakeToSale Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Bakery.Request.
        /// </summary>
        // *** Start programmer edit section *** (CakeIntoRequest.Request CustomAttributes)

        // *** End programmer edit section *** (CakeIntoRequest.Request CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.Bakery.Request Request
        {
            get
            {
                // *** Start programmer edit section *** (CakeIntoRequest.Request Get start)

                // *** End programmer edit section *** (CakeIntoRequest.Request Get start)
                IIS.Bakery.Request result = this.fRequest;
                // *** Start programmer edit section *** (CakeIntoRequest.Request Get end)

                // *** End programmer edit section *** (CakeIntoRequest.Request Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (CakeIntoRequest.Request Set start)

                // *** End programmer edit section *** (CakeIntoRequest.Request Set start)
                this.fRequest = value;
                // *** Start programmer edit section *** (CakeIntoRequest.Request Set end)

                // *** End programmer edit section *** (CakeIntoRequest.Request Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "Bakery_CakeIntoRequestE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View Bakery_CakeIntoRequestE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("Bakery_CakeIntoRequestE", typeof(IIS.Bakery.CakeIntoRequest));
                }
            }
            
            /// <summary>
            /// "CakeIntoRequestE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View CakeIntoRequestE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("CakeIntoRequestE", typeof(IIS.Bakery.CakeIntoRequest));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of CakeIntoRequest.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfCakeIntoRequest CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfCakeIntoRequest CustomAttributes)
    public class DetailArrayOfCakeIntoRequest : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Bakery.DetailArrayOfCakeIntoRequest members)

        // *** End programmer edit section *** (IIS.Bakery.DetailArrayOfCakeIntoRequest members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type CakeIntoRequest by index.
        /// </summary>
        /// <summary>
        /// Adds object with type CakeIntoRequest.
        /// </summary>
        public DetailArrayOfCakeIntoRequest(IIS.Bakery.Request fRequest) : 
                base(typeof(CakeIntoRequest), ((ICSSoft.STORMNET.DataObject)(fRequest)))
        {
        }
        
        public IIS.Bakery.CakeIntoRequest this[int index]
        {
            get
            {
                return ((IIS.Bakery.CakeIntoRequest)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Bakery.CakeIntoRequest dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}