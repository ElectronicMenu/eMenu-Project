<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="table.aspx.cs" Inherits="Electronic_Menu.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

          <asp:GridView ID="GridViewTable" runat="server" AutoGenerateColumns="False" Font-Names="Verdana"
            AllowPaging="true" ShowFooter="true" PageSize="5" Width="75%"
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
        DataKeyNames="table_id" onrowediting="GridViewTable_RowEditing" OnPageIndexChanging="GridViewTable_PageIndexChanging"
    onrowcommand="GridViewTable_RowCommand" 
    onrowdeleting="GridViewTable_RowDeleting" OnRowCancelingEdit ="GridViewTable_RowCancelEditing" OnRowUpdating="GridViewTable_RowUpdating">

                   <AlternatingRowStyle BackColor="#FFD4BA" />
            <FooterStyle Height="20px" Font-Size="15px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <PagerStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <HeaderStyle Height="30px" BackColor="#FF9E66" Font-Size="15px" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" />
            <RowStyle Height="20px" Font-Size="13px" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" />
            <Columns>

                <asp:TemplateField HeaderText="Table ID" Visible="false" HeaderStyle-Width="10%" >
                    <ItemTemplate>
                        <asp:Label ID="lblTableID" DataField="table_id" runat="server" Text='<%#Eval("table_id") %>'></asp:Label>
                    </ItemTemplate>
                      <EditItemTemplate>
                        <asp:TextBox ID="txtEditTableID" runat="server" Text='<%#Eval("table_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqId" ValidationGroup="ValgrpCust" ControlToValidate="txtEditTableID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:TextBox ID="txtAddTableID" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="reqAddTableID" ValidationGroup="ValgrpCust" ControlToValidate="txtAddTableID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:Label ID="lbladdTable" runat="server"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Table Number" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblTable_Number" runat="server" Text='<%#Eval("table_number") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditTableNumber" runat="server" Text='<%#Eval("table_number") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqImage" ValidationGroup="ValgrpCust" ControlToValidate="txtEditTableNumber" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddTableNumber" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddNumber" ValidationGroup="ValgrpCust" ControlToValidate="txtAddTableNumber" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Table Password" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lbltable_password" runat="server" Text='<%#Eval("table_password") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditTablePassword" runat="server" Text='<%#Eval("table_password") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtEditTablePassword" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddTablePassword" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtAddTablePassword" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Table Occupied" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblTableOccupied" runat="server" Text='<%#Eval("table_is_occupied") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditTableOccupied" runat="server" Text='<%#Eval("table_is_occupied") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditTableOccupied" ValidationGroup="ValgrpCust" ControlToValidate="txtEditTableOccupied" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                       <!-- <asp:TextBox ID="txtAddTableOccupied" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddTableOccupied" ValidationGroup="ValgrpCust" ControlToValidate="txtAddTableOccupied" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                           -->
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>


           
                
                <asp:TemplateField HeaderText="Edit/Delete" HeaderStyle-Width="15%">
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />
                        <span onclick="return confirm('Are you sure want to delete?')">
                            <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete" />
                        </span>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" />
                        <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="btnInsertRecord" runat="server" Text="Add" CommandName="Insert" />
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>


</asp:Content>
