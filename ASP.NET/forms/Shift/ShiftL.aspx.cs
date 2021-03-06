﻿/*flexberryautogenerated="true"*/
namespace IIS.Bakery
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ShiftL : BaseListForm<Shift>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ShiftL() : base(Shift.Views.ShiftL)
        {
            EditPage = ShiftE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Shift/ShiftL.aspx"; }
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
