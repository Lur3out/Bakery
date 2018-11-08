﻿/*flexberryautogenerated="true"*/
namespace IIS.Bakery
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class RequestL : BaseListForm<Request>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public RequestL() : base(IIS.Bakery.Request.Views.RequestL)
        {
            EditPage = RequestE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Request/RequestL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
