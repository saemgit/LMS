<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Library_Management.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btn_booklist" runat="server" class="btn btn-primary" OnClick="btn_booklist_Click" Text="All Books" />
                </td>
                <td>
                    <asp:Button ID="btn_homeSearch" runat="server" class="btn btn-primary"  OnClick="btn_homeSearch_Click" Text="Search" />
                </td>
                <td>
                    <asp:TextBox ID="txt_homesearch" runat="server" class="form-control"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <asp:GridView ID="grdhome" runat="server" GridLines="None" 
        AutoGenerateColumns="false" class="table table-bordered table-hover" 
        onselectedindexchanged="grdhome_SelectedIndexChanged">       
        <Columns>
            <asp:BoundField HeaderText="Book Name" DataField="BookName"></asp:BoundField>
            <asp:BoundField HeaderText="Author Name" DataField="AuthorName"></asp:BoundField>
            <asp:BoundField HeaderText="Publication" DataField="Publication"></asp:BoundField>
            <asp:BoundField HeaderText="Price" DataField="Price"></asp:BoundField>
            <asp:BoundField HeaderText="Department	" DataField="Department"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
