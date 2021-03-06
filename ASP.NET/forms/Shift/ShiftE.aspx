﻿<%--flexberryautogenerated="true"--%>
<%@ Page Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="ShiftE.aspx.cs" Inherits="IIS.Bakery.ShiftE" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<%-- Autogenerated section start [Register] --%>
<%-- Autogenerated section end [Register] --%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="<%= Constants.FormCssClass + " " +  Constants.EditFormCssClass %>">
        <h2 class="<%= Constants.FormHeaderCssClass + " " + Constants.EditFormHeaderCssClass %>">Shift</h2>
        <div class="<%= Constants.FormToolbarCssClass  + " " +  Constants.EditFormToolbarCssClass + " " + Constants.StickyCssClass %>">
            <asp:ImageButton ID="SaveBtn" runat="server" SkinID="SaveBtn" OnClick="SaveBtn_Click" AlternateText="<%$ Resources: Resource, Save %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="SaveAndCloseBtn" runat="server" SkinID="SaveAndCloseBtn" OnClick="SaveAndCloseBtn_Click" AlternateText="<%$ Resources: Resource, Save_Close %>" ValidationGroup="savedoc" />
            <asp:ImageButton ID="CancelBtn" runat="server" SkinID="CancelBtn" OnClick="CancelBtn_Click" AlternateText="<%$ Resources: Resource, Cancel %>" />
        </div>
        <div class="<%= Constants.FormControlsCssClass + " " + Constants.EditFormControlsCssClass %>">
            <%-- Autogenerated section start [Controls] --%>
<!-- autogenerated start -->
<div>
	<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlStartLabel" runat="server" Text="Start" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlStart" runat="server"/>
</div>
<ac:DatePickerValidator ID="ctrlStartDatePickerValidator" runat="server" ControlToValidate="ctrlStart" 
                        ErrorMessage="Введена некорректная дата: Start." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlEndLabel" runat="server" Text="End" EnableViewState="False">
</asp:Label>
<div class="descTxt">
    <ac:DatePicker ID="ctrlEnd" runat="server"/>
</div>
<ac:DatePickerValidator ID="ctrlEndDatePickerValidator" runat="server" ControlToValidate="ctrlEnd" 
                        ErrorMessage="Введена некорректная дата: End." Text="*" 
                        EnableClientScript="true" ValidationGroup="savedoc" CssClass="validator-datePicker" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlStatusLabel" runat="server" Text="Status" EnableViewState="False">
</asp:Label>
<asp:DropDownList ID="ctrlStatus" CssClass="descTxt" runat="server">
	<asp:ListItem>Started</asp:ListItem>
<asp:ListItem>Ended</asp:ListItem>
<asp:ListItem>Interrupted</asp:ListItem>

</asp:DropDownList>

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlCashLabel" runat="server" Text="Cash" EnableViewState="False">
</asp:Label>
<ac:DecimalTextBox CssClass="descTxt" ID="ctrlCash" runat="server">
</ac:DecimalTextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlInterruptReasonLabel" runat="server" Text="Interrupt reason" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlInterruptReason" runat="server">
</asp:TextBox>


</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlCashierLabel" runat="server" Text="Cashier" EnableViewState="False">
</asp:Label>
<ac:MasterEditorAjaxLookUp ID="ctrlCashier" CssClass="descTxt" runat="server" ShowInThickBox="True" Autocomplete="true" />

<asp:RequiredFieldValidator ID="ctrlCashierRequiredFieldValidator" runat="server" ControlToValidate="ctrlCashier"
                            ErrorMessage="Не указано: Cashier" Text="*" 
                            EnableClientScript="true" ValidationGroup="savedoc" />

</div>
<div class="clearfix">
  <asp:Label CssClass="descLbl" ID="ctrlCashier_PersonalkeyLabel" runat="server" Text="Personalkey" EnableViewState="False">
</asp:Label>
<asp:TextBox CssClass="descTxt" ID="ctrlCashier_Personalkey" runat="server" ReadOnly="true">
</asp:TextBox>


</div>
<br/>

</div>
<!-- autogenerated end -->
            <%-- Autogenerated section end [Controls] --%>
        </div>
    </div>
</asp:Content>
