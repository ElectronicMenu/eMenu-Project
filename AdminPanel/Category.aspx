<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="Electronic_Menu.Category" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <asp:GridView ID="GridViewCategory" runat="server" AutoGenerateColumns="False" Font-Names="Verdana"
            AllowPaging="true" ShowFooter="true" PageSize="5" Width="75%"
            BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" 
        DataKeyNames="category_id" onrowediting="GridViewCategory_RowEditing" OnPageIndexChanging="GridViewCategory_PageIndexChanging"
    onrowcommand="GridViewCategory_RowCommand" 
    onrowdeleting="GridViewCategory_RowDeleting" OnRowCancelingEdit ="GridViewCategory_RowCancelEditing" OnRowUpdating="GridViewCategory_RowUpdating">

                   <AlternatingRowStyle BackColor="#FFD4BA" />
            <FooterStyle Height="20px" Font-Size="15px" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <PagerStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" />
            <HeaderStyle Height="30px" BackColor="#FF9E66" Font-Size="15px" BorderColor="#CCCCCC"
                BorderStyle="Solid" BorderWidth="1px" />
            <RowStyle Height="20px" Font-Size="13px" BorderColor="#CCCCCC" BorderStyle="Solid"
                BorderWidth="1px" />
            <Columns>

                <asp:TemplateField HeaderText="Category ID" Visible="false" HeaderStyle-Width="10%" >
                    <ItemTemplate>
                        <asp:Label ID="lblcategoryID" DataField="category_id" runat="server" Text='<%#Eval("category_id") %>'></asp:Label>
                    </ItemTemplate>
                      <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryID" runat="server" Text='<%#Eval("category_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqId" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:TextBox ID="txtAddCategoryID" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="reqAddID" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:Label ID="lbladd" runat="server"></asp:Label>
                    </FooterTemplate>
                </asp:TemplateField>




                

                <asp:TemplateField HeaderText="Category Image" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_image" runat="server" Text='<%#Eval("category_image") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryImage" runat="server" Text='<%#Eval("category_image") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqImage" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddCategoryImage" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddImage" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryImage" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Category Icon" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_icon" runat="server" Text='<%#Eval("category_icon") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryIcon" runat="server" Text='<%#Eval("category_icon") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddCategoryIcon" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddIcon" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryIcon" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                <asp:TemplateField HeaderText="Category Name" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblcategory_name" runat="server" Text='<%#Eval("category_name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditCategoryName" runat="server" Text='<%#Eval("category_name") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditCateName" ValidationGroup="ValgrpCust" ControlToValidate="txtEditCategoryName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddCategoryName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddCateName" ValidationGroup="ValgrpCust" ControlToValidate="txtAddCategoryName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>



                 <asp:TemplateField HeaderText="Language ID" HeaderStyle-Width="7%">
                    <ItemTemplate>
                        <asp:Label ID="lblLanguage_ID" runat="server" Text='<%#Eval("language_id") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtEditLanguageID" runat="server" Text='<%#Eval("language_id") %>' ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqEditLangID" ValidationGroup="ValgrpCust" ControlToValidate="txtEditLanguageID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
        
                    </EditItemTemplate>

                    <FooterTemplate>
                        <asp:TextBox ID="txtAddLanguageID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqAddLangID" ValidationGroup="ValgrpCust" ControlToValidate="txtAddLanguageID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <HeaderStyle Width="10%"></HeaderStyle>
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
