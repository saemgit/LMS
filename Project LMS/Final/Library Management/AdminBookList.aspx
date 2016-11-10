<%@ Page Title="Admin" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true"
    CodeBehind="AdminBookList.aspx.cs" Inherits="Library_Management.AdminBookList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="style1">
        <strong>Welcome to Our Liabrary !
            <asp:LinkButton ID="btn_signout" runat="server" ForeColor="#3333FF" OnClick="btn_signout_Click">Sign Out</asp:LinkButton>
        </strong>
        <br />
        <br />
        <asp:Label ID="lbl_entrymsg" runat="server"></asp:Label>
        <br />
        <table id="tbl_entrytbl" border="solid" class="style3" frame="box" class="table table-responsive">
            <tr>
                <td>
                    &nbsp;&nbsp; <span class="style4">Book Name</span>
                </td>
                <td>
                    &nbsp; <span class="style4">Author Name</span>
                </td>
                <td>
                    &nbsp;&nbsp; <span class="style4">Publication</span>
                </td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="style4">Price</span>
                </td>
                <td>
                    &nbsp;<span class="style4">Department</span>
                </td>
                <td>
                    &nbsp;<span class="style4">Shelf No.</span>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txt_bookname" runat="server" Width="111px"></asp:TextBox><asp:RequiredFieldValidator
                        ForeColor="Red" ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                        ControlToValidate="txt_bookname" ValidationGroup="S"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txt_authorname" runat="server" Width="109px"></asp:TextBox><asp:RequiredFieldValidator
                        ForeColor="Red" ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                        ControlToValidate="txt_authorname" ValidationGroup="S"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txt_publication" runat="server" Width="102px"></asp:TextBox><asp:RequiredFieldValidator
                        ForeColor="Red" ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                        ControlToValidate="txt_publication" ValidationGroup="S"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:TextBox ID="txt_price" runat="server" Width="84px"></asp:TextBox><asp:RequiredFieldValidator
                        ForeColor="Red" ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
                        ControlToValidate="txt_price" ValidationGroup="S"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Number only"
                        ControlToValidate="txt_price" ValidationGroup="S" ForeColor="Red" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:DropDownList ID="ddl_department" runat="server" Height="16px" Width="92px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*"
                        ControlToValidate="ddl_department" ValidationGroup="s" ForeColor="Red" InitialValue="NA"></asp:RequiredFieldValidator>
                </td>
                 <td>
                    <asp:DropDownList ID="ddl_shelf" runat="server" Height="16px" Width="92px">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                        ControlToValidate="ddl_department" ValidationGroup="s" ForeColor="Red" InitialValue="NA"></asp:RequiredFieldValidator>
                </td>
               
            </tr>
        </table>
        &nbsp;
        <asp:Button ID="btn_submit" runat="server" Text="Submit" ValidationGroup="S" 
            OnClick="btn_submit_Click" style="height: 26px" />
        &nbsp;
        <asp:Button ID="btn_refresh" runat="server" Text="Refresh" OnClick="btn_refresh_Click" />
        &nbsp;
        <asp:Button ID="btn_delete" runat="server" Text="Delete" 
            OnClick="btn_refresh_Click" />
        <br />
        <br />
        <asp:TextBox ID="txt_search" runat="server" ></asp:TextBox>
        &nbsp;<asp:Button ID="btn_search" runat="server" OnClick="btn_search_Click" Text="Search" />
        <br />
        <br />
        <br />
        <asp:GridView ID="grdBookList" runat="server" AutoGenerateColumns="false" DataKeyNames="ID" >
            <Columns>
                <asp:BoundField HeaderText="Book Name" DataField="BookName"></asp:BoundField>
                <asp:BoundField HeaderText="Author Name" DataField="AuthorName"></asp:BoundField>
                <asp:BoundField HeaderText="Publication" DataField="Publication"></asp:BoundField>
                <asp:BoundField HeaderText="Price" DataField="Price"></asp:BoundField>
                <asp:BoundField HeaderText="Department	" DataField="DeptName"></asp:BoundField>
                <asp:BoundField HeaderText="Shelf" DataField="ShelfNo"></asp:BoundField>
                <asp:TemplateField HeaderText="Select">
                <ItemTemplate>
                    <asp:Button ID="btnSelect" runat="server" Text="Select" onclick="btnSelect_Click"/>
                </ItemTemplate>

                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:Button ID="btn_delete" runat="server" Text="Delete" onclick="btnSelect_Click"/>
                </ItemTemplate>

                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
</asp:Content>
