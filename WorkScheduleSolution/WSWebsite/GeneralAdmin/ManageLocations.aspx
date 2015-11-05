<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManageLocations.aspx.cs" Inherits="GeneralAdmin_ManageLocations" %>
<%@ Register src="../UserControls/MessageUserControl.ascx" tagname="MessageUserControl" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>Manage Locations</h1>
    <uc1:MessageUserControl ID="MessageUserControl" runat="server" />
    <asp:ListView ID="LocationListView" runat="server" DataSourceID="LocationODS" InsertItemPosition="LastItem">
        <AlternatingItemTemplate>
            <tr style="background-color:#FFF8DC;">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
               
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetLabel" runat="server" Text='<%# Eval("Street") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                </td>
                <td>
                    <asp:Label ID="ContactLabel" runat="server" Text='<%# Eval("Contact") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Eval("Active") %>' Enabled="false" />
                </td>
               
            </tr>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <tr style="background-color:#008A8C;color: #FFFFFF;">
                <td>
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                </td>
               
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server" Text='<%# Bind("Street") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ContactTextBox" runat="server" Text='<%# Bind("Contact") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Bind("Active") %>' />
                </td>
                
            </tr>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <InsertItemTemplate>
            <tr style="">
                <td>
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                </td>
                
                <td>
                    <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                </td>
                <td>
                    <asp:TextBox ID="StreetTextBox" runat="server" Text='<%# Bind("Street") %>' />
                </td>
                <td>
                    <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ProvinceTextBox" runat="server" Text='<%# Bind("Province") %>' />
                </td>
                <td>
                    <asp:TextBox ID="ContactTextBox" runat="server" Text='<%# Bind("Contact") %>' />
                </td>
                <td>
                    <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%# Bind("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Bind("Active") %>' />
                </td>
                
            </tr>
        </InsertItemTemplate>
        <ItemTemplate>
            <tr style="background-color:#DCDCDC;color: #000000;">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
               
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetLabel" runat="server" Text='<%# Eval("Street") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                </td>
                <td>
                    <asp:Label ID="ContactLabel" runat="server" Text='<%# Eval("Contact") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Eval("Active") %>' Enabled="false" />
                </td>
                
            </tr>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <tr runat="server" style="background-color:#DCDCDC;color: #000000;">
                                <th runat="server"></th>
                               
                                <th runat="server">Name</th>
                                <th runat="server">Street</th>
                                <th runat="server">City</th>
                                <th runat="server">Province</th>
                                <th runat="server">Contact</th>
                                <th runat="server">Phone</th>
                                <th runat="server">Active</th>
                                
                            </tr>
                            <tr id="itemPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                    </td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <tr style="background-color:#008A8C;font-weight: bold;color: #FFFFFF;">
                <td>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                </td>
                
                <td>
                    <asp:Label ID="NameLabel" runat="server" Text='<%# Eval("Name") %>' />
                </td>
                <td>
                    <asp:Label ID="StreetLabel" runat="server" Text='<%# Eval("Street") %>' />
                </td>
                <td>
                    <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                </td>
                <td>
                    <asp:Label ID="ProvinceLabel" runat="server" Text='<%# Eval("Province") %>' />
                </td>
                <td>
                    <asp:Label ID="ContactLabel" runat="server" Text='<%# Eval("Contact") %>' />
                </td>
                <td>
                    <asp:Label ID="PhoneLabel" runat="server" Text='<%# Eval("Phone") %>' />
                </td>
                <td>
                    <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%# Eval("Active") %>' Enabled="false" />
                </td>
                
            </tr>
        </SelectedItemTemplate>
    </asp:ListView>
    <asp:ObjectDataSource ID="LocationODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="Location_List" TypeName="WSSystem.BLL.WSController" DataObjectTypeName="WSSystem.DAL.Entities.Location" InsertMethod="Location_Add" OnInserted="CheckForException" OnSelected="CheckForException" OnUpdated="CheckForException" UpdateMethod="Location_Update"></asp:ObjectDataSource>
</asp:Content>

