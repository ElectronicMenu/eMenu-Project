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
