<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="tax.aspx.cs" Inherits="Electronic_Menu.tax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <asp:GridView ID="GridViewTax" runat="server" AutoGenerateColumns="False" Font-Names="Verdana"
            AllowPaging="true" ShowFooter="true" PageSize="5" Width="75%"
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
        DataKeyNames="tax_id" onrowediting="GridViewTax_RowEditing" OnPageIndexChanging="GridViewTax_PageIndexChanging"
    onrowcommand="GridViewTax_RowCommand" 
    onrowdeleting="GridViewTax_RowDeleting" OnRowCancelingEdit ="GridViewTax_RowCancelEditing" OnRowUpdating="GridViewTax_RowUpdating">

                   <AlternatingRowStyle BackColor="#FFD4BA" />
            <FooterStyle Height="20px" Font-Size="15px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <PagerStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <HeaderStyle Height="30px" BackColor="#FF9E66" Font-Size="15px" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" />
            <RowStyle Height="20px" Font-Size="13px" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" />
            <Columns>

                <asp:TemplateField HeaderText="Tax ID" Visible="false" HeaderStyle-Width="10%" >
                    <ItemTemplate>
                        <asp:Label ID="lblTaxID" DataField="tax_id" runat="server" Text='<%#Eval("tax_id") %>'></asp:Label>
                    </ItemTemplate>
                      <EditItemTemplate>
                        <asp:TextBox ID="txtEditTaxID" runat="server" Text='<%#Eval("tax_id") %>' ></asp:TextBox>

                      </EditItemTemplate>
                    
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Tax Percentage" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lbltax_percentage" runat="server" Text='<%#Eval("tax_percentage") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEdittax_percentage" runat="server" Text='<%#Eval("tax_percentage") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqtax_percentage" ValidationGroup="ValgrpCust" ControlToValidate="txtEdittax_percentage" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddtax_percentage" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddtax_percentage" ValidationGroup="ValgrpCust" ControlToValidate="txtAddtax_percentage" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



              


              
                <asp:TemplateField HeaderText="Edit/Delete" HeaderStyle-Width="15%">
                    <ItemTemplate>
                        <center>
                       <%-- <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" />--%>
                        <asp:ImageButton ID="btnEdit" ImageUrl="~/images/edit.png" CommandName="Edit" runat="server" />
               
                        <span onclick="return confirm('Are you sure want to delete?')">
                           <%-- <asp:LinkButton ID="btnDelete" Text="Delete" runat="server" CommandName="Delete" />--%>
                            <asp:ImageButton ID="btnDelete" ImageUrl="~/images/delete.png" CommandName="Delete" runat="server" />
                        </span>
                            </center>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <center>
                       <%-- <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" />--%>
                         <asp:ImageButton ID="btnUpdate" ImageUrl="~/images/update.png" CommandName="Update" runat="server" />
                   
                      <%--  <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" />--%>
                         <asp:ImageButton ID="btnCancel" ImageUrl="~/images/cancel.png" CommandName="Cancel" runat="server" />
                   </center>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <%--<asp:Button ID="btnInsertRecord" runat="server" Text="Add" CommandName="Insert" />--%>
                     <center> <asp:ImageButton ID="btnInsertRecord" ImageUrl="~/images/add.png" CommandName="Insert" runat="server" /></center>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>


            </Columns>
        </asp:GridView>

</asp:Content>
